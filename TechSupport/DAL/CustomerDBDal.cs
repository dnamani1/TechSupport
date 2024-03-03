using System.Collections.Generic;
using System.Data;
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


        /// <summary>
        /// Determines whether [is customer registered] [the specified customer name].
        /// </summary>
        /// <param name="customerName">Name of the customer.</param>
        /// <param name="productName">Name of the product.</param>
        /// <returns>
        ///   <c>true</c> if [is customer registered] [the specified customer name]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsCustomerRegistered(int customerID, string productCode)
        {
            bool isRegistered = false;
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
                                    SELECT COUNT(*) 
                                    FROM registrations  
                                    WHERE CustomerID = @customerId AND ProductCode = @productCode";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@customerId", SqlDbType.Int);
                    command.Parameters["@customerId"].Value = customerID;

                    command.Parameters.Add("@productCode", SqlDbType.VarChar, 50);
                    command.Parameters["@productCode"].Value = productCode;

                    int count = (int)command.ExecuteScalar();
                    isRegistered = count > 0;
                }
            }
            return isRegistered;
        }
    }
}
