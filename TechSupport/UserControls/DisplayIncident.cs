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
        private readonly IncidentController controller;

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
        private void RefreshIncidentsDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = controller.GetIncidents();
            incidentDataGridView.Refresh();
        }
    }
}
