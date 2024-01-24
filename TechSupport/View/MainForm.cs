using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;

        public MainForm()
        {
            InitializeComponent();

            _incidentController = new IncidentController();
            usernameLable.Text = _incidentController.GetUsername();

        }

        public void SetController(IncidentController controller)
        {
            _incidentController = controller;
        }

        private void AddIncidentButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
