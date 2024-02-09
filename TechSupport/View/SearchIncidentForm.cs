using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// This Form is to search Incidents from list.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIncidentForm"/> class.
        /// </summary>
        public SearchIncidentForm()
        {
            InitializeComponent();
            this._incidentController = new IncidentController();
        }

        /// <summary>
        /// Handles the TextChanged event of the CustomerIDTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
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
                var customerID = Convert.ToInt32(customerIDTextBox.Text);
                var incidents = _incidentController.SearchIncidentsByCustomerID(customerID);

                if (incidents.Count > 0)
                {
                    errorLabel.Visible = false;
                    incidentDataGridView2.Visible = true;
                    incidentDataGridView2.DataSource = null;
                    incidentDataGridView2.DataSource = incidents;
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
            incidentDataGridView2.Visible = false;
            errorLabel.Text = "Customer ID not found";
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
        }

        /// <summary>
        /// Displays the invalid customer identifier error.
        /// </summary>
        private void DisplayInvalidCustomerIdError()
        {
            errorLabel.Text = "Customer ID not valid!";
            errorLabel.ForeColor = Color.Red;
            errorLabel.Visible = true;
            customerIDTextBox.Clear();
        }

    }

}
    

