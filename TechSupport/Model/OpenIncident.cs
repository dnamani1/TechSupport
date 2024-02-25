using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an open incident.
    /// </summary>
    public class OpenIncident
    {
        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        /// <value>
        /// The product code.
        /// </value>
        public string ProductCode { get; set; }

        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        /// <value>
        /// The date opened.
        /// </value>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the name of the technician.
        /// </summary>
        /// <value>
        /// The name of the technician.
        /// </value>
        public string TechnicianName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}
