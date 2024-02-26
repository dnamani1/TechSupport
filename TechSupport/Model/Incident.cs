using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an incident in the system.
    /// </summary>
    public class Incident
    {
        private string _title;
        private string _description;
        private string _customerName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Incident"/> class.
        /// </summary>
        public Incident()
        {
            _title = string.Empty;
            _description = string.Empty;
            _customerName = string.Empty;
        }

        /// <summary>
        /// Gets or sets the title of the incident.
        /// </summary>
        /// <exception cref="Exception">Thrown when the provided title is null or empty.</exception>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new Exception("Title cannot be null or empty.");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Gets or sets the description of the incident.
        /// </summary>
        /// <exception cref="Exception">Thrown when the provided description is null or empty.</exception>
        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new Exception("Description cannot be null or empty.");
                }
                _description = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        /// <exception cref="System.Exception">Customer name cannot be null.</exception>
        public string CustomerName
        {
            get
            {
                return _customerName;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Customer name cannot be null.");
                }
                _customerName = value;
            }
        }

    }
}
