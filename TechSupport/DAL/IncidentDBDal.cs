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
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
            SELECT 
                Incidents.ProductCode, 
                Incidents.DateOpened, 
                Customers.Name AS CustomerName, 
                ISNULL(Technicians.Name, 'Not Assigned') AS TechnicianName, 
                Incidents.Title 
            FROM 
                Incidents 
                JOIN Customers ON Incidents.CustomerID = Customers.CustomerID 
                LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID 
            WHERE 
                Incidents.DateClosed IS NULL";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    var productCodeOrdinal = reader.GetOrdinal("ProductCode");
                    var dateOpenedOrdinal = reader.GetOrdinal("DateOpened");
                    var customerNameOrdinal = reader.GetOrdinal("CustomerName");
                    var technicianNameOrdinal = reader.GetOrdinal("TechnicianName");
                    var titleOrdinal = reader.GetOrdinal("Title");

                    while (reader.Read())
                    {
                        var productCode = reader.GetString(productCodeOrdinal);
                        var dateOpened = reader.GetDateTime(dateOpenedOrdinal);
                        var customerName = reader.GetString(customerNameOrdinal);
                        var technicianName = reader.GetString(technicianNameOrdinal); 
                        var title = reader.GetString(titleOrdinal);

                        openIncidents.Add(new OpenIncident
                        {
                            ProductCode = productCode,
                            DateOpened = dateOpened,
                            CustomerName = customerName,
                            TechnicianName = technicianName,
                            Title = title
                        });
                    }
                }
            }
            return openIncidents;
        }

    }
}
