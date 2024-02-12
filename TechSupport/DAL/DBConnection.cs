using System.Data.SqlClient;

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
            const string connectionString = "Data source=CSDBLAB-VM17;Initial Catalog = TechSupport;Integrated Security = True";
            return new SqlConnection(connectionString);
        }
    }
}


