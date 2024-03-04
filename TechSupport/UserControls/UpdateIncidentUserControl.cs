using System;
using System.Collections.Generic;
using System.Drawing;
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
            PopulateTechnicianComboBox();
            SetInitialControlState();
        }

        /// <summary>
        /// Populates the technician ComboBox.
        /// </summary>
        private void PopulateTechnicianComboBox()
        {
            List<UpdateIncident> technicians = controller.GetTechnicians();
            technicians.Insert(0, new UpdateIncident() { TechnicianID = -1, TechnicianName = "-- Unassigned --" }); 
            technicianComboBox.DataSource = technicians;
            technicianComboBox.DisplayMember = "TechnicianName";
            technicianComboBox.ValueMember = "TechnicianID";    
        }

        /// <summary>
        /// Sets the initial state of the control.
        /// </summary>
        private void SetInitialControlState()
        {
            updateButton.Enabled = false;
            closeButton.Enabled = false;
            textTextBox.Enabled = false;
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

                technicianComboBox.SelectedItem = theIncident.TechnicianName ?? "-- Unassigned --";

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
            incidentIdTextBox.Clear();
            customerTextBox.Clear();
            productTextBox.Clear();
            titleTextBox.Clear();
            dateOpenedTextBox.Clear();
            descriptionTextBox.Clear();
            textTextBox.Clear();
            if (technicianComboBox.Items.Count > 0)
                technicianComboBox.SelectedValue = -1;
            updateButton.Enabled = false;
            closeButton.Enabled = false;
            textTextBox.Enabled = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
