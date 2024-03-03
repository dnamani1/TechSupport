using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    ///  Data access layer class for Products.
    /// </summary>
    public class ProductsDBDal
    {

        /// <summary>
        /// Gets the product names.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            var products = new List<Product>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT ProductCode, Name FROM Products";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new Product
                        {
                            Code = reader.GetString(reader.GetOrdinal("ProductCode")),
                            Name = reader.GetString(reader.GetOrdinal("Name"))
                        });
                    }
                }
            }
            return products;
        }
    }
}
