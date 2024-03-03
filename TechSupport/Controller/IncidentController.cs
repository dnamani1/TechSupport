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
        private readonly CustomerDBDal _customerDBDal;
        private readonly ProductsDBDal _productsDBDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController() 
        {
            _incidentDAL = new IncidentDAL();
            _incidentDBDal = new IncidentDBDal();
            _customerDBDal = new CustomerDBDal();
            _productsDBDal = new ProductsDBDal();
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
        public List<Customer> GetCustomers()
        {
            return _customerDBDal.GetCustomers();
        }

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
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
            return _incidentDBDal.IsCustomerRegistered(customerId, productCode);  
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
        /// Searches the name of the incidents by customer.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <returns></returns>
        public List<Incident> SearchIncidentsByCustomerName(string customerName)
        {    
            return _incidentDBDal.SearchIncidentsByCustomerName(customerName);
        }

    }
}
