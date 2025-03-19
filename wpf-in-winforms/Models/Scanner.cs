using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_in_winforms.Models
{
    public class Scanner
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Video { get; set; }
        public string Pairity { get; set; }
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public int StopBits { get; set; }
    }
}
