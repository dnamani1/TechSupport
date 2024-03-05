using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Addes the Incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class AddIncidentUserControl : UserControl
    {

        private readonly IncidentController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentUserControl"/> class.
        /// </summary>
        public AddIncidentUserControl()
        {
            InitializeComponent();
            controller = new IncidentController();
            PopulateCustomerComboBox();
            PopulateProductComboBox();
        }

        /// <summary>
        /// Populates the customer ComboBox.
        /// </summary>
        private void PopulateCustomerComboBox()
        {
            var customers = controller.GetCustomers();
            customerComboBox.DataSource = customers;
            customerComboBox.DisplayMember = "CustomerName";
            customerComboBox.ValueMember = "ID";
            if (customerComboBox.Items.Count > 0) customerComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Populates the product ComboBox.
        /// </summary>
        private void PopulateProductComboBox()
        {
            var products = controller.GetProducts();
            productComboBox.DataSource = products;
            productComboBox.DisplayMember = "ProductName";
            productComboBox.ValueMember = "ProductCode";
            if (productComboBox.Items.Count > 0) productComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles the TextChanged event of the TitleTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
            customerErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the TextChanged event of the DescriptionTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the AddIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            var customerId = Convert.ToInt32(customerComboBox.SelectedValue);
            var productCode = productComboBox.SelectedValue.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                if (string.IsNullOrEmpty(title))
                {
                    titleErrorLabel.Text = "Title cannot be empty.";
                    titleErrorLabel.ForeColor = Color.Red;
                    titleErrorLabel.Visible = true;
                }

                if (string.IsNullOrEmpty(description))
                {
                    descriptionErrorLabel.Text = "Description cannot be empty.";
                    descriptionErrorLabel.ForeColor = Color.Red;
                    descriptionErrorLabel.Visible = true;
                }
                return;
            }

            if (controller.IsCustomerRegistered(customerId, productCode))
            {
                controller.AddIncident(customerId, productCode, title, description);
                ClearFields();
                customerErrorLabel.Text = "Incident added sucessfully!";
                customerErrorLabel.ForeColor = Color.Green;
                customerErrorLabel.Visible = true;
                
            } 
            else
            {
                customerErrorLabel.Text = "Selected Customer is not registered with the Product!";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;

            }
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Clears the fields.
        /// </summary>
        private void ClearFields()
        {
            titleTextBox.Clear();
            descriptionTextBox.Clear();
            customerComboBox.SelectedIndex = 0;
            productComboBox.SelectedIndex = 0;
        }

    }
}
