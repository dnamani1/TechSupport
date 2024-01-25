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
    /// <summary>
    /// Form to display main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _incidentController = new IncidentController();
            usernameLable.Text = _incidentController.GetUsername();

        }

        /// <summary>
        /// Sets the controller.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public void SetController(IncidentController controller)
        {
            _incidentController = controller;
        }

        /// <summary>
        /// Handles the Click event of the AddIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            var addIncident = new AddIncidentForm();
            var result = addIncident.ShowDialog();

            if(result == DialogResult.OK)
            {
                dataGridView.DataSource = null;
                dataGridView.DataSource = _incidentController.GetIncidents();
            }

        }

        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
