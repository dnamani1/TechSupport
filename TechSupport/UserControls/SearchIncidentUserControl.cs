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
    public partial class SearchIncidentUserControl : UserControl
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIncidentUserControl"/> class.
        /// </summary>
        public SearchIncidentUserControl()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
            PopulateCustomersComboBox();
        }

        /// <summary>
        /// Populates the customer name ComboBox.
        /// </summary>
        private void PopulateCustomersComboBox()
        {
            var customerNames = _incidentController.GetCustomers();
            foreach (var name in customerNames)
            {
                customerComboBox.Items.Add(name);
            }

            if (customerComboBox.Items.Count > 0)
                customerComboBox.SelectedIndex = 0;
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
                var customerName = customerComboBox.SelectedItem.ToString();
                var incidents = _incidentController.SearchIncidentsByCustomerName(customerName);

                if (incidents.Count > 0)
                {
                    searchCustomerIDErrorLabel.Visible = false;
                    searchDataGridView.Visible = true;
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
            searchCustomerIDErrorLabel.Text = "No incidents found for the selected customer.";
            searchCustomerIDErrorLabel.ForeColor = Color.Red;
            searchCustomerIDErrorLabel.Visible = true;
        }

        /// <summary>
        /// Displays the invalid customer identifier error.
        /// </summary>
        private void DisplayInvalidCustomerIdError()
        {
            searchCustomerIDErrorLabel.Text = "Customer with no products";
            searchCustomerIDErrorLabel.ForeColor = Color.Red;
            searchCustomerIDErrorLabel.Visible = true;
            
        }

    }

}


