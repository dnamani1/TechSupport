using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an open incident.
    /// </summary>
    public class OpenIncident
    {
        public string ProductCode { get; set; }
        public DateTime DateOpened { get; set; }
        public string CustomerName { get; set; }
        public string TechnicianName { get; set; }
        public string Title { get; set; }
    }
}
