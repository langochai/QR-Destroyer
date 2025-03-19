using System;
using System.Collections.Generic;

namespace wpf_in_winforms.Models
{
    internal class CusomersViewJSON
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Interests> Interests { get; set; }
        public List<Channels> Channels { get; set; }
        public int PlayTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}