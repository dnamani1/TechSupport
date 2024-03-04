using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class TechnicianDBDal
    {

        /// <summary>
        /// Gets the technicians.
        /// </summary>
        /// <returns></returns>
        public List<UpdateIncident> GetTechnicians()
        {
            var technicians = new List<UpdateIncident>();
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                string query = "SELECT TechID, Name FROM Technicians";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        technicians.Add(new UpdateIncident
                        {
                            TechnicianID = reader.GetInt32(reader.GetOrdinal("TechID")),
                            TechnicianName = reader.GetString(reader.GetOrdinal("Name"))
                        });
                    }
                }
            }
            return technicians;
        }


    }
}
