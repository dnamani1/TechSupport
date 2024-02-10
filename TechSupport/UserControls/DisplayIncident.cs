using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Displays the Incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class DisplayIncident : UserControl
    {
        private IncidentController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayIncident"/> class.
        /// </summary>
        public DisplayIncident()
        {
            InitializeComponent();
            controller = new IncidentController();
        }

        /// <summary>
        /// Refreshes the incidents data grid.
        /// </summary>
        public bool RefreshIncidentsDataGrid()
        {
            if(controller.GetIncidents().Count == 0)
            {
                incidentDataGridView.Visible = false;
                return false;
            } else
            {
                incidentDataGridView.Visible = true;
                incidentDataGridView.DataSource = null;
                incidentDataGridView.DataSource = controller.GetIncidents();
                incidentDataGridView.Refresh();
                return true;
            }
           
        }
    }
}
