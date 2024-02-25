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
        private readonly IncidentDAL _incidentDAL;
        private readonly string _username = "jane";
        private readonly string _password = "test1234";
        private readonly IncidentDBDal _incidentDBDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController() 
        {
            _incidentDAL = new IncidentDAL();
            _incidentDBDal = new IncidentDBDal();
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

        /// <summary>
        /// Searches the incidents by customer identifier.
        /// </summary>
        /// <param name="customerID">The customer identifier.</param>
        /// <returns></returns>
        public List<Incident> SearchIncidentsByCustomerID(int customerID)
        {    
            return _incidentDAL.SearchIncidentsByCustomerID(customerID);
        }

        /// <summary>
        /// Gets the display open incidents.
        /// </summary>
        /// <returns></returns>
        public List<OpenIncident> GetDisplayOpenIncidents()
        {
            return _incidentDBDal.GetDisplayOpenIncidents();
        }

        /// <summary>
        /// Gets the customer names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetCustomerNames()
        {
            return _incidentDBDal.GetCustomerNames();
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<string> GetProductNames()
        {
            return _incidentDBDal.GetProductNames();
        }
    }
}
