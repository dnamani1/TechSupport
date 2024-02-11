using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Display Open Incidents
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class DisplayOpenIncident : UserControl
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayOpenIncident"/> class.
        /// </summary>
        public DisplayOpenIncident()
        {
            InitializeComponent();
            _incidentController = new IncidentController();
        }

        /// <summary>
        /// Displays the open incidents.
        /// </summary>
        public void DisplayOpenIncidentsInMainDashBoard()
        {
            incidentListView.Items.Clear();

            var openIncidents = _incidentController.GetDisplayOpenIncidents();

            foreach (var incident in openIncidents)
            {
                var listViewItem = new ListViewItem(incident.ProductCode);
                listViewItem.SubItems.Add(incident.DateOpened.ToShortDateString());
                listViewItem.SubItems.Add(incident.CustomerName);
                listViewItem.SubItems.Add(incident.TechnicianName);
                listViewItem.SubItems.Add(incident.Title);

                incidentListView.Items.Add(listViewItem);
            }

            incidentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            incidentListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

    }
}
