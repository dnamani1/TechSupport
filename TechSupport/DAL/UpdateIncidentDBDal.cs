using System.Data;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data access layer class for Update Incident
    /// </summary>
    public class UpdateIncidentDBDal
    {

        /// <summary>
        /// Updates the incident.
        /// </summary>
        /// <param name="myIncident">My incident.</param>
        public void UpdateIncident(UpdateIncident myIncident)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
                                     UPDATE incidents
                                     SET TechID = @techID, Description = @description
                                     WHERE IncidentID = @incidentID";

                using (var command = new SqlCommand(query, connection))
                {

                    var techIDParam = command.Parameters.Add("@techID", SqlDbType.Int);
                    techIDParam.Value = myIncident.TechnicianID;

                    var descriptionParam = command.Parameters.Add("@description", SqlDbType.VarChar);
                    descriptionParam.Value = myIncident.Description; 

                    var incidentIDParam = command.Parameters.Add("@incidentID", SqlDbType.Int);
                    incidentIDParam.Value = myIncident.IncidentID;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
