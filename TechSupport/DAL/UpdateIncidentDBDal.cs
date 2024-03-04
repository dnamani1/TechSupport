using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Data access layer class for Update Incident
    /// </summary>
    public class UpdateIncidentDBDal
    {
        /// <summary>
        /// Gets the incident identifier.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns></returns>
        public UpdateIncident GetIncidentID(int incidentID)
        {
            if (DoesIncidentExist(incidentID) == false)
            {
                return null;
            }

            UpdateIncident incident = new UpdateIncident();
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = @"
                                    SELECT Customers.Name AS CustomerName, 
                                    Incidents.ProductCode, 
                                    Technicians.Name AS TechnicianName, 
                                    Incidents.DateOpened, 
                                    Incidents.Title, 
                                    Incidents.Description 
                                    FROM Incidents
                                        LEFT JOIN Customers ON Incidents.CustomerID = Customers.CustomerID
                                    LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID
                                    WHERE Incidents.IncidentID = @incidentID";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@incidentID", SqlDbType.Int);
                    command.Parameters["@incidentID"].Value = incidentID;

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int customerNameIndex = reader.GetOrdinal("CustomerName");
                            int productCodeIndex = reader.GetOrdinal("ProductCode");
                            int technicianNameIndex = reader.GetOrdinal("TechnicianName");
                            int dateOpenedIndex = reader.GetOrdinal("DateOpened");
                            int titleIndex = reader.GetOrdinal("Title");
                            int descriptionIndex = reader.GetOrdinal("Description");

                            incident.IncidentID = incidentID;
                            incident.CustomerName = reader.GetString(customerNameIndex);
                            incident.ProductCode = reader.GetString(productCodeIndex);
                            incident.TechnicianName = reader.IsDBNull(technicianNameIndex) ? "Not Assigned" : reader.GetString(technicianNameIndex);
                            incident.Title = reader.GetString(titleIndex);
                            incident.Description = reader.GetString(descriptionIndex);
                            incident.OpenedDate = reader.GetDateTime(dateOpenedIndex);
                            
                        }
                    }
                }
            }
            return incident;
        }

        /// <summary>
        /// Doeses the incident exist.
        /// </summary>
        /// <param name="incidentID">The incident identifier.</param>
        /// <returns></returns>
        public bool DoesIncidentExist(int incidentID)
        {
            using (var connection = DBConnection.GetConnection())
            {
                connection.Open();
                const string query = "SELECT COUNT(*) FROM Incidents WHERE IncidentID = @incidentID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@incidentID", SqlDbType.Int);
                    command.Parameters["@incidentID"].Value = incidentID;
                        
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; 
                }
            }
        }
    }
}
