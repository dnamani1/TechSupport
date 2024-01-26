using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Form for adding new incidents.
    /// </summary>
    public partial class AddIncidentForm : Form
    {
        private readonly IncidentController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentForm"/> class.
        /// </summary>
        public AddIncidentForm()
        {
            InitializeComponent();
            controller = new IncidentController();
        }

        /// <summary>
        /// Handles the TextChanged event of the TitleTextBox control.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            titleErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the TextChanged event of the DescriptionTextBox control.
        /// </summary>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            descriptionErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the TextChanged event of the CustomerIDTextBox control.
        /// </summary>
        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            customerErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the AddIncidentButton control.
        /// </summary>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;

            if(string.IsNullOrEmpty(title))
            {
                titleErrorLabel.Text = "Title cannot be null or empty.";
                titleErrorLabel.ForeColor = Color.Red;
                titleErrorLabel.Visible = true;
            }

            if (string.IsNullOrEmpty(description))
            {
                descriptionErrorLabel.Text = "Description cannot be null or empty.";
                descriptionErrorLabel.ForeColor = Color.Red;
                descriptionErrorLabel.Visible = true;
            }

            try
            {
                int customerID = Convert.ToInt32(customerIDTextBox.Text);
                var incident = new Incident
                {
                    Title = title,
                    Description = description,
                    CustomerID = customerID
                };
                controller.Add(incident);
                DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                customerErrorLabel.Text = "CustomerID must be numbers";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (ArgumentException aExp)
            {
                customerErrorLabel.Text = aExp.Message;
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }
            catch (OverflowException)
            {
                customerErrorLabel.Text = "CustomerID is out of range";
                customerErrorLabel.ForeColor = Color.Red;
                customerErrorLabel.Visible = true;
            }   

        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
