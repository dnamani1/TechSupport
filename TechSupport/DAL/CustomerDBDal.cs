using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data access layer class for Customers.
    /// </summary>
    public class CustomerDBDal
    {

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT CustomerID, Name FROM Customers";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customers.Add(new Customer
                        {
                            ID = reader.GetInt32(reader.GetOrdinal("CustomerID")),
                            Name = reader.GetString(reader.GetOrdinal("Name"))
                        });
                    }
                }
            }
            return customers;
        }
    }
}
