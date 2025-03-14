using System;

namespace wpf_in_winforms
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string InterestIds { get; set; }
        public string ChannelIds { get; set; }
        public int PlayTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}