using System;

namespace wpf_in_winforms.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        public string FullName { get; set; }

        public double PlayTime { get; set; }
        public int Stage { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}