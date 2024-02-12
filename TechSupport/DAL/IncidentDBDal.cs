using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;


namespace TechSupport.DAL
{
    /// <summary>
    /// Data access layer class for incidents.
    /// Provides functionality to retrieve open incident data from the database.
    /// </summary>
    public class IncidentDBDal
    {
        /// <summary>
        /// Retrieves a list of open incidents from the database.
        /// Open incidents are defined as incidents without a closed date.
        /// </summary>
        /// <returns>A list of open incidents.</returns>
        public List<OpenIncident> GetDisplayOpenIncidents()
        {
            var openIncidents = new List<OpenIncident>();
            var connection = DBConnection.GetConnection();
            connection.Open();
            const string query = "select Incidents.ProductCode,Incidents.DateOpened,Customers.Name as customerName,Technicians.Name,Incidents.Title from Incidents,Technicians,Customers where Incidents.CustomerID = Customers.CustomerID and Incidents.TechID = Technicians.TechID and Incidents.DateClosed is null";
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            var productCodeOrdinal = reader.GetOrdinal("ProductCode");
            var dateOpenedOrdinal = reader.GetOrdinal("DateOpened");
            var customersNameOrdinal = reader.GetOrdinal("customerName");
            var techniciansNameOrdinal = reader.GetOrdinal("Name");
            var titleOrdinal = reader.GetOrdinal("Title");
            while (reader.Read())
            {
                var productCode = reader.GetString(productCodeOrdinal);
                var dateOpened = reader.GetDateTime(dateOpenedOrdinal);
                var customersName = reader.GetString(customersNameOrdinal);
                var technicians = reader.GetString(techniciansNameOrdinal);
                var title = reader.GetString(titleOrdinal);

                openIncidents.Add(new OpenIncident
                {
                    ProductCode = productCode,
                    DateOpened = dateOpened,
                    CustomerName = customersName,
                    TechnicianName = technicians,
                    Title = title
                });
            }
            return openIncidents;
        }

    }
}
