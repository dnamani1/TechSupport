using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    /// <summary>
    /// Connects to the DB
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            const string connectionString = "Data source=(localdb)\\MSSQLLocalDB;Initial Catalog = TechSupport;Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}
