using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Form to display main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private readonly IncidentController _incidentController;

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
        /// Handles the Click event of the AddIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            using (var addIncidentForm = new AddIncidentForm())
            {
                var result = addIncidentForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshIncidentsDataGrid();
                }

            }
        }

        /// <summary>
        /// Refreshes the incidents data grid.
        /// </summary>
        private void RefreshIncidentsDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = _incidentController.GetIncidents();
            incidentDataGridView.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the SearchIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            using (var searchIncidentForm = new SearchIncidentForm())
            { searchIncidentForm.ShowDialog(); }
        
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
