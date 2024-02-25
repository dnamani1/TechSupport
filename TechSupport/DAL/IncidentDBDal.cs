using System;
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

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns></returns>
        public List<string> GetCustomerNames()
        {
            var customers = new List<string>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT Name FROM Customers";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    var nameOrdinal = reader.GetOrdinal("Name");
                    while (reader.Read())
                    {
                        var customerName = reader.GetString(nameOrdinal); 
                        customers.Add(customerName);
                    }
                }
            }
            return customers;
        }

        public List<string> GetProductNames()
        {
            var products = new List<string>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT Name FROM Products";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    var nameOrdinal = reader.GetOrdinal("Name");
                    while (reader.Read()) {
                        var productName = reader.GetString(nameOrdinal);
                        products.Add(productName);
                    }
                }

            }
            return products;
        }

        //
        public bool IsCustomerRegistered(string customerName, string productName)
        {
            bool isRegistered = false;
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
                                    SELECT COUNT(*) 
                                    FROM registrations 
                                    JOIN customers ON registrations.CustomerID = customers.CustomerID 
                                    JOIN products ON registrations.ProductCode = products.ProductCode 
                                    WHERE customers.Name = @customerName AND products.Name = @productName";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Parameters.AddWithValue("@productName", productName);

                    int count = (int)command.ExecuteScalar();
                    isRegistered = count > 0;
                }
            }
            return isRegistered;
        }

        /// <summary>
        /// Adds the incident.
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="title">The title.</param>
        /// <param name="description">The description.</param>
        public void AddIncident(string customerName, string productName, string title, string description)
        {
            int customerID = 0;
            string productCode = string.Empty;

            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();

                const string customerQuery = "SELECT CustomerID FROM Customers WHERE Name = @customerName";
                using (var customerCommand = new SqlCommand(customerQuery, connection))
                {
                    customerCommand.Parameters.AddWithValue("@customerName", customerName);

                    using (var reader = customerCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int customerIDOrdinal = reader.GetOrdinal("CustomerID");
                            customerID = reader.GetInt32(customerIDOrdinal);
                        }
                    }
                }

                const string productQuery = "SELECT ProductCode FROM Products WHERE Name = @productName";
                using (var productCommand = new SqlCommand(productQuery, connection))
                {
                    productCommand.Parameters.AddWithValue("@productName", productName);

                    using (var reader = productCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productCodeOrdinal = reader.GetOrdinal("ProductCode");
                            productCode = reader.GetString(productCodeOrdinal);
                        }
                    }
                }

                const string insertQuery = @"
                                           INSERT INTO Incidents (CustomerID, ProductCode, DateOpened, Title, Description)
                                           VALUES (@customerID, @productCode, @dateOpened, @title, @description)";

                using (var insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@customerID", customerID);
                    insertCommand.Parameters.AddWithValue("@productCode", productCode);
                    insertCommand.Parameters.AddWithValue("@dateOpened", DateTime.Now);
                    insertCommand.Parameters.AddWithValue("@title", title);
                    insertCommand.Parameters.AddWithValue("@description", description);

                    insertCommand.ExecuteNonQuery();
                }
            }
        }

    }
}
