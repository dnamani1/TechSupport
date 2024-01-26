using System.Collections.Generic;

using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// data access layer between model and view for Instance
    /// </summary>
    public class IncidentDAL
    {
        private static readonly List<Incident> _incidents = new List<Incident>();
        private readonly List<Incident> customerIncidents = new List<Incident>();

        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Add(Incident incident)
        {
            _incidents.Add(incident);
        }

        /// <summary>
        /// Gets the incidents.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<Incident> GetIncidents()
        {
            return _incidents;
        }

    }
}
