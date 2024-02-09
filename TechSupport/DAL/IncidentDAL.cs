using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data access layer between model and view for Incidents.
    /// </summary>
    public class IncidentDAL
    {
        // Static list to hold all incidents across sessions.
        private static readonly List<Incident> _incidents = new List<Incident>();

        /// <summary>
        /// Adds the specified incident to the list.
        /// </summary>
        /// <param name="incident">The incident to add.</param>
        public void Add(Incident incident)
        {
            if (incident != null)
            {
                _incidents.Add(incident);
            }
        }

        /// <summary>
        /// Retrieves all incidents stored in the list.
        /// </summary>
        /// <returns>A list of all incidents.</returns>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Searches the incidents by customer identifier.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <returns></returns>
        public List<Incident> SearchIncidentsByCustomerID(int customerID)
        {
            return _incidents.FindAll(incident => incident.CustomerID == customerID);
        }
    }
}
