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
        private readonly string _username = "jane";
        private readonly string _password = "test1234";
        private readonly IncidentDBDal _incidentDBDal;
        private readonly CustomerDBDal _customerDBDal;
        private readonly ProductsDBDal _productsDBDal;
        private readonly UpdateIncidentDBDal _updateIncidentDBDal;
        private readonly TechnicianDBDal _technicianDBDal;
        private readonly ClosedIncidentDBDal _closedIncidentDBDal;


        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController() 
        {
            _incidentDBDal = new IncidentDBDal();
            _customerDBDal = new CustomerDBDal();
            _productsDBDal = new ProductsDBDal();
            _updateIncidentDBDal = new UpdateIncidentDBDal();
            _technicianDBDal = new TechnicianDBDal();
            _closedIncidentDBDal = new ClosedIncidentDBDal();
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
        public List<OpenIncident> GetCustomers()
        {
            return _customerDBDal.GetCustomers();
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<OpenIncident> GetProducts()
        {
            return _productsDBDal.GetProducts();
        }

        /// <summary>
        /// Determines whether [is customer registered] [the specified customer name].
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns>
        ///   <c>true</c> if [is customer registered] [the specified customer name]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCustomerRegistered(int customerId, string productCode)
        {
            return _customerDBDal.IsCustomerRegistered(customerId, productCode);  
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public void AddIncident(int customerName, string productCode, string title, string description)
        {
            _incidentDBDal.AddIncident(customerName, productCode, title, description);
        }

        /// <summary>
        /// Gets the incident identifier.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns></returns>
        public UpdateIncident GetIncidentID(int incidentID)
        {
            return _incidentDBDal.GetIncidentID(incidentID);
        }

        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
        public List<UpdateIncident> GetTechnicians()
        {
            return _technicianDBDal.GetTechnicians();
        }

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="myIncident">My incident.</param>
        public void UpdateIncident(UpdateIncident myIncident)
        {
            _updateIncidentDBDal.UpdateIncident(myIncident);
        }

        /// <summary>
        /// Closes the incident.
        /// </summary>
        /// <param name="myIncident">My incident.</param>
        public void CloseIncident(UpdateIncident myIncident)
        {
            _closedIncidentDBDal.CloseIncident(myIncident);
        }
    }
}
