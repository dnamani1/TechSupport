using System.Data.SqlClient;
using System.Data;
using TechSupport.Model;
using System;

namespace TechSupport.DAL
{
    /// <summary>
    ///  Data access layer class for Closed Incient 
    /// </summary>
    public class ClosedIncidentDBDal
    {
        /// <summary>
        /// Closes the incident.
        /// </summary>
        /// <param name="updateIncident">The update incident.</param>
        public void CloseIncident(UpdateIncident updateIncident)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
                                     UPDATE incidents
                                     SET DateClosed = @date
                                     WHERE IncidentID = @incidentID";

                using (var command = new SqlCommand(query, connection))
                {

                    var DateParam = command.Parameters.Add("@date", SqlDbType.Date);
                    DateParam.Value = DateTime.Now;

                    var incidentIDParam = command.Parameters.Add("@incidentID", SqlDbType.Int);
                    incidentIDParam.Value = updateIncident.IncidentID;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
