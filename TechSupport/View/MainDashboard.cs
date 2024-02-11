using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.UserControls;

namespace TechSupport.View
{
    /// <summary>
    /// Main Dashboard
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashboard : Form
    {
        private IncidentController incidentController;
        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboard"/> class.
        /// </summary>
        public MainDashboard()
        {
            InitializeComponent();
            incidentController = new IncidentController();
            userLabel.Text = incidentController.GetUsername();
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void DisplayIncident(object sender, System.EventArgs e)
        {
            if(mainDashBoardTabControl.SelectedTab == displayIncidentTabPage)
            {
                var display = displayIncidentUserControls.RefreshIncidentsDataGrid();
                if (!display)
                {
                    displayMessageLabel.Text = "No Incident to Show!";
                }
                else
                {
                    displayMessageLabel.Text = "All Incidents";
                }
            }

            if (mainDashBoardTabControl.SelectedTab == displayOpenIncidentsTabPage)
            {
                displayOpenIncidentUserControls.DisplayOpenIncidentsInMainDashBoard();
            }
        }
    }
}
