﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<OpenIncident> GetProducts()
        {
            var products = new List<OpenIncident>();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT ProductCode, Name FROM Products";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        products.Add(new OpenIncident
                        {
                            ProductCode = reader.GetString(reader.GetOrdinal("ProductCode")),
                            ProductName = reader.GetString(reader.GetOrdinal("Name"))
                        });
                    }
                }
            }
            return products;
        }
    }
}
