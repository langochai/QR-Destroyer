using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_in_winforms.Models
{
    public class Customers
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAdress { get; set; }

        public string Company { get; set; }

        public bool SmartWarehouseSolutions { get; set; }

        public bool MachineVisionSolutions { get; set; }

        public bool AGVnAMRSolutions { get; set; }

        public bool AutomaticMachineManufacturingSolutions { get; set; }

        public bool AutomationEquipmentinProduction { get; set; }

        public bool IoTSolutions { get; set; }

        public bool OtherSolutions { get; set; }

        public bool MailChannel { get; set; }

        public bool WebsiteChannel { get; set; }

        public bool FacebookChannel { get; set; }

        public bool PartnersChannel { get; set; }

        public bool OtherChannel { get; set; }

        public int LuckyNumber { get; set; }

        public int PlayTime { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
