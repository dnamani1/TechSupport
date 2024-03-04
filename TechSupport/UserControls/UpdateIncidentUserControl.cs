using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController controller;
        private UpdateIncident theIncident;

        public UpdateIncidentUserControl()
        {
            InitializeComponent();
            controller = new IncidentController();
            theIncident = new UpdateIncident();
        }

        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            incidentIdErrorLabel.Visible = false;
            updateErrorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(incidentIdTextBox.Text))
            {
                incidentIdErrorLabel.Text = "Please enter an Incident ID.";
                incidentIdErrorLabel.ForeColor = Color.Red;
                incidentIdErrorLabel.Visible = true;
                return;
            }

            if (!int.TryParse(incidentIdTextBox.Text, out int incidentID))
            {
                incidentIdErrorLabel.Text = "Incident ID must be a number.";
                incidentIdErrorLabel.ForeColor = Color.Red;
                incidentIdErrorLabel.Visible = true;
                return;
            }

            try
            {
                theIncident = controller.GetIncidentID(incidentID);
                if (theIncident == null)
                {
                    incidentIdErrorLabel.Text = "No Incident found with the provided ID.";
                    incidentIdErrorLabel.ForeColor = Color.Red;
                    incidentIdErrorLabel.Visible = true;
                    return;
                }

                customerTextBox.Text = theIncident.CustomerName;
                productTextBox.Text = theIncident.ProductCode;
                titleTextBox.Text = theIncident.Title;
                descriptionTextBox.Text = theIncident.Description;
                dateOpenedTextBox.Text = theIncident.OpenedDate.ToShortDateString();

                technicianComboBox.SelectedItem = theIncident.TechnicianName ?? "Not Assigned";

                updateButton.Enabled = true;
                closeButton.Enabled = true;
                textTextBox.Enabled = true;
                textTextBox.Clear();
            }
            catch (Exception ex)
            {
                
                incidentIdErrorLabel.Text = "An error occurred while retrieving the incident: " + ex.Message;
                incidentIdErrorLabel.ForeColor = Color.Red;
                incidentIdErrorLabel.Visible = true;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }
    }
}
