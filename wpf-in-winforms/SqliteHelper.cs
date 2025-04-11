using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

namespace wpf_in_winforms
{
    public class SqliteHelper<T> where T : new()
    {
        private static readonly string _connectionString = "Data Source=db.db";

        public SqliteHelper()
        {
        }

        public static int Insert(T model)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var properties = typeof(T).GetProperties()
                    .Where(p => p.Name.ToUpper() != "ID" && p.GetValue(model) != null);

                var columns = string.Join(", ", properties.Select(p => p.Name));
                var values = string.Join(", ", properties.Select(p => $"@{p.Name}"));

                var insertQuery = $"INSERT INTO {typeof(T).Name} ({columns}) VALUES ({values}); Select last_insert_rowid()";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    foreach (var property in properties)
                    {
                        command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(model));
                    }
                    int id = Convert.ToInt32(command.ExecuteScalar());
                    var idProperty = typeof(T).GetProperty("Id");
                    if (idProperty != null && idProperty.CanWrite)
                    {
                        idProperty.SetValue(model, id);
                    }
                    return id;
                }
            }
        }

        public static List<T> GetAll()
        {
            var results = new List<T>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var selectQuery = $"SELECT * FROM {typeof(T).Name}";

                using (var command = new SQLiteCommand(selectQuery, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new T();
                        foreach (var property in typeof(T).GetProperties())
                        {
                            var columnName = property.Name;
                            if (reader[columnName] != DBNull.Value)
                            {
                                var value = reader[columnName];
                                property.SetValue(model, Convert.ChangeType(value, property.PropertyType));
                            }
                        }
                        results.Add(model);
                    }
                }
            }

            return results;
        }

        public static List<T> GetByColumnValue(string columnName, object value)
        {
            var results = new List<T>();

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var selectQuery = $"SELECT * FROM {typeof(T).Name} WHERE {columnName} = @Value";

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var model = new T();
                            foreach (var property in typeof(T).GetProperties())
                            {
                                if (reader[property.Name] != DBNull.Value)
                                {
                                    var columnValue = reader[property.Name];
                                    property.SetValue(model, Convert.ChangeType(columnValue, property.PropertyType));
                                }
                            }
                            results.Add(model);
                        }
                    }
                }
            }

            return results;
        }

        public static void Update(T model)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var properties = typeof(T).GetProperties();
                var setClause = string.Join(", ", properties.Select(p => $"{p.Name} = @{p.Name}"));

                var updateQuery = $"UPDATE {typeof(T).Name} SET {setClause} WHERE Id = @Id";

                using (var command = new SQLiteCommand(updateQuery, connection))
                {
                    foreach (var property in properties)
                    {
                        command.Parameters.AddWithValue($"@{property.Name}", property.GetValue(model));
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var deleteQuery = $"DELETE FROM {typeof(T).Name} WHERE Id = @Id";

                using (var command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private static string GetSqliteType(Type type)
        {
            if (type == typeof(int)) return "INTEGER";
            if (type == typeof(string)) return "TEXT";
            if (type == typeof(double)) return "REAL";
            if (type == typeof(bool)) return "INTEGER";
            // Add more type mappings as needed
            throw new NotSupportedException($"Type {type} not supported");
        }

        public static List<T> GetCustomerView(int stage = 0)
        {
            var results = new List<T>();
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var where = stage == 0 ? "" : $"AND stage = {stage}";
                //string query = $@"SELECT ROW_NUMBER() OVER (ORDER BY PlayTime ASC) AS Rank, *
                //                FROM customers {where} ORDER BY PlayTime ASC LIMIT 10";
                string query = $@"
                            WITH
                                top10 AS (
                                    SELECT *
                                    FROM customers
                                    WHERE PlayTime < 100000
                                    {where}
                                    ORDER BY PlayTime ASC
                                    LIMIT 10
                                    ),
                                pad AS (
                                    SELECT *
                                    FROM customers
                                    WHERE stage IS NULL
                                    ORDER BY PlayTime ASC
                                    LIMIT (10 - (SELECT COUNT(*) FROM top10))
                                    ),
                                combined AS (
                                    SELECT * FROM top10
                                    UNION ALL
                                    SELECT * FROM pad
                                    )
                            SELECT
                                ROW_NUMBER() OVER (ORDER BY PlayTime ASC) AS Rank,
                                Id,
                                CustomerId,
                                FullName,
                                PlayTime,
                                Stage,
                                CreatedDate
                            FROM combined
                            ORDER BY Rank;
                ";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var model = new T();
                        foreach (var property in typeof(T).GetProperties())
                        {
                            var columnName = property.Name;
                            if (reader[columnName] != DBNull.Value)
                            {
                                var value = reader[columnName];
                                property.SetValue(model, Convert.ChangeType(value, property.PropertyType));
                            }
                        }
                        results.Add(model);
                    }
                }
            }
            return results;
        }

        public static T GetCustomerViewJSON()
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                string query = @"
                                SELECT json_group_array(
                                         json_object(
                                           'Id', c.Id,
                                           'Rank', c.Rank,
                                           'Name', c.Name,
                                           'Company', c.Company,
                                           'Email', c.Email,
                                           'PhoneNumber', c.PhoneNumber,
                                           'PlayTime', c.PlayTime,
                                           'CreatedDate', c.CreatedDate,
                                           'Interests', (
                                             SELECT json_group_array(
                                                      json_object(
                                                        'Id', i.Id,
                                                        'TextVN', i.TextVN,
                                                        'TextEN', i.TextEN
                                                      )
                                                    )
                                             FROM Interests i
                                             JOIN json_each(c.InterestIds) ON json_each.value = i.id
                                           ),
                                           'Channels', (
                                             SELECT json_group_array(
                                                      json_object(
                                                        'Id', ch.Id,
                                                        'TextVN', ch.TextVN,
                                                        'TextEN', ch.TextEN
                                                      )
                                                    )
                                             FROM Channels ch
                                             JOIN json_each(c.ChannelIds) ON json_each.value = ch.id
                                           )
                                         )
                                       ) AS customers_json
                                FROM (SELECT ROW_NUMBER() OVER (ORDER BY PlayTime ASC) AS Rank,
                                    * FROM customers ORDER BY PlayTime ASC LIMIT 10) c;";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar() ?? throw new SQLiteException("Couldn't get the data");
                    string jsonResult = result.ToString();
                    return JsonConvert.DeserializeObject<T>(jsonResult);
                }
            }
        }
        public static int GetRank(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string query = $@"
                                SELECT Rank FROM (
                                    SELECT ID, PlayTime, RANK() OVER (ORDER BY PlayTime ASC) AS Rank
                                    FROM Customers
                                ) Ranked
                                WHERE ID = {id};";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    object result = command.ExecuteScalar() ?? throw new SQLiteException("Couldn't get the data");
                    return Convert.ToInt32(result);
                }
            }
        }
    }
}