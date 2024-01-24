using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.DAL;

namespace TechSupport.Controller
{
    public class IncidentController
    {
        private IncidentDAL _incidentDAL;
        private string _username = "jane";
        private string _password = "test1234";

        public IncidentController() 
        {
            _incidentDAL = new IncidentDAL();
        }

        public string GetUsername() 
        {
            return _username;
        }

        public string GetPassword() 
        {
            return _password;
        }

    }
}
