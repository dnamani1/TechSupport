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
        private int _customerID;

        /// <summary>
        /// Initializes a new instance of the <see cref="Incident"/> class.
        /// </summary>
        public Incident()
        {
            _title = string.Empty;
            _description = string.Empty;
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
        /// Gets or sets the customer ID associated with the incident.
        /// </summary>
        /// <exception cref="Exception">Thrown when the provided customer ID is less than or equal to zero.</exception>
        public int CustomerID
        {
            get
            {
                return _customerID;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("CustomerID cannot be null or empty.");
                }
                _customerID = value;
            }
        }

    }
}
