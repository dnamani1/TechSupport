using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class OpenIncident
    {
        public string ProductCode { get; set; }
        public DateTime DateOpened { get; set; }
        public string CustomerName { get; set; }
        public string TechnicianName { get; set; }
        public string Title { get; set; }
    }
}
