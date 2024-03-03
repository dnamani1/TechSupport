using System;
using System.Collections.Generic;
using System.Data;
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


        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public void AddIncident(int customerId, string productCode, string title, string description)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string insertQuery = @"
            INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
            VALUES (@customerID, @productCode, @dateOpened, @title, @description)";

                using (var insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.Add("@customerId", SqlDbType.Int);
                    insertCommand.Parameters["@customerId"].Value = customerId;

                    insertCommand.Parameters.Add("@productCode", SqlDbType.VarChar, 50);
                    insertCommand.Parameters["@productCode"].Value = productCode;

                    insertCommand.Parameters.Add("@dateOpened", SqlDbType.DateTime);
                    insertCommand.Parameters["@dateOpened"].Value = DateTime.Now;

                    insertCommand.Parameters.Add("@title", SqlDbType.VarChar);
                    insertCommand.Parameters["@title"].Value = title;

                    insertCommand.Parameters.Add("@description", SqlDbType.VarChar);
                    insertCommand.Parameters["@description"].Value = description;

                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
