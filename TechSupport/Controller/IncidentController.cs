using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller class to manage incdents
    /// </summary>
    public class IncidentController
    {
        private IncidentDAL _incidentDAL;
        private string _username = "jane";
        private string _password = "test1234";

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController() 
        {
            _incidentDAL = new IncidentDAL();
        }

        /// <summary>
        /// Gets the username.
        /// </summary>
        /// <returns></returns>
        public string GetUsername() 
        {
            return _username;
        }

        /// <summary>
        /// Gets the password.
        /// </summary>
        /// <returns></returns>
        public string GetPassword() 
        {
            return _password;
        }

        /// <summary>
        /// Gets the incidents.
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetIncidents()
        {
            return _incidentDAL.GetIncidents();
        }

        /// <summary>
        /// Adds the specified incident.
        /// </summary>
        /// <param name="incident">The incident.</param>
        public void Add(Incident incident)
        {
            _incidentDAL.Add(incident);
        }

    }
}
