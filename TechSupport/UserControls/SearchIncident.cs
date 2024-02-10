using System;
using System.Drawing;

using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Search Incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchIncident : UserControl
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIncident"/> class.
        /// </summary>
        public SearchIncident()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }

        /// <summary>
        /// Handles the TextChanged event of the SearchCustomerIDTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchCustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            searchCustomerIDErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the SearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                var customerID = Convert.ToInt32(searchCustomerIDTextBox.Text);
                var incidents = _incidentController.SearchIncidentsByCustomerID(customerID);

                if (incidents.Count > 0)
                {
                    searchCustomerIDErrorLabel.Visible = false;
                    searchDataGridView.Visible = true;
                    searchDataGridView.DataSource = null;
                    searchDataGridView.DataSource = incidents;
                }
                else
                {
                    DisplayCustomerNotFoundError();
                }
            }
            catch (FormatException)
            {
                DisplayInvalidCustomerIdError();
            }
        }

        /// <summary>
        /// Displays the customer not found error.
        /// </summary>
        private void DisplayCustomerNotFoundError()
        {
            searchDataGridView.Visible = false;
            searchCustomerIDErrorLabel.Text = "Customer ID not found";
            searchCustomerIDErrorLabel.ForeColor = Color.Red;
            searchCustomerIDErrorLabel.Visible = true;
        }

        /// <summary>
        /// Displays the invalid customer identifier error.
        /// </summary>
        private void DisplayInvalidCustomerIdError()
        {
            searchCustomerIDErrorLabel.Text = "Customer ID not valid!";
            searchCustomerIDErrorLabel.ForeColor = Color.Red;
            searchCustomerIDErrorLabel.Visible = true;
            searchCustomerIDTextBox.Clear();
        }

    }

}


