using System;
using System.Drawing;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.UserControls
{
    /// <summary>
    /// Update the Incident
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class UpdateIncidentUserControl : UserControl
    {
        private readonly IncidentController controller;
        private UpdateIncident theIncident;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentUserControl"/> class.
        /// </summary>
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
            var technicians = controller.GetTechnicians();
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

        /// <summary>
        /// Handles the Click event of the GetIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void GetIncidentButton_Click(object sender, EventArgs e)
        {
            incidentIdErrorLabel.Visible = false;
            updateErrorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(incidentIdTextBox.Text))
            {
                ClearFields();
                incidentIdErrorLabel.Text = "Please enter an Incident ID.";
                incidentIdErrorLabel.ForeColor = Color.Red;
                incidentIdErrorLabel.Visible = true;
                return;
            }

            if (!int.TryParse(incidentIdTextBox.Text, out int incidentID))
            {
                ClearFields();
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
                    ClearFields();
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

                SelectTechnicianByName(theIncident.TechnicianName ?? "-- Unassigned --");

                if (theIncident.ClosedDate != DateTime.MinValue && theIncident.ClosedDate != null)
                {
                    DisableEditing();
                }
                else
                {
                    EnableEditing();
                }
            
            }
            catch (Exception ex)
            {
                
                incidentIdErrorLabel.Text = "An error occurred while retrieving the incident: " + ex.Message;
                incidentIdErrorLabel.ForeColor = Color.Red;
                incidentIdErrorLabel.Visible = true;
            }
        }

        /// <summary>
        /// Disables the editing.
        /// </summary>
        private void DisableEditing()
        {
            updateButton.Enabled = false;
            closeButton.Enabled = false;
            textTextBox.Enabled = false;
            technicianComboBox.Enabled = false;
        }

        /// <summary>
        /// Enables the editing.
        /// </summary>
        private void EnableEditing()
        {
            updateButton.Enabled = true;
            closeButton.Enabled = true;
            textTextBox.Enabled = true;
            technicianComboBox.Enabled = true;
        }


        /// <summary>
        /// Selects the name of the technician by.
        /// </summary>
        /// <param name="technicianName">Name of the technician.</param>
        private void SelectTechnicianByName(string technicianName)
        {
            foreach (var item in technicianComboBox.Items)
            {
                if (item is UpdateIncident technician && string.Equals(technician.TechnicianName, technicianName, StringComparison.OrdinalIgnoreCase))
                {
                    technicianComboBox.SelectedItem = item;
                    return;
                }
            }
            technicianComboBox.SelectedIndex = technicianComboBox.Items.IndexOf("-- Unassigned --");
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Clears the d fields.
        /// </summary>
        private void ClearFields()
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
            updateErrorLabel.Text =  "";
            updateErrorLabel.Visible = false;
        }

        /// <summary>
        /// Handles the Click event of the UpdateButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void UpdateButton_Click(object sender, EventArgs e)
        { 
            string newTextToAdd = textTextBox.Text;
            bool technicianChanged = technicianComboBox.SelectedItem.ToString() != theIncident.TechnicianName;
            bool hasNewTextToAdd = !string.IsNullOrEmpty(newTextToAdd);
            string newDescription = descriptionTextBox.Text;

            if (newDescription.Length >= 200 && hasNewTextToAdd)
            {
                updateErrorLabel.Text = "Description already at maximum length. Additional text will not be added.";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;

                if (technicianChanged)
                {
                    UpdateTechnicianOnly();
                }
                return;
            }

            if (hasNewTextToAdd)
            {
                string currentDate = DateTime.Now.ToShortDateString();
                newDescription += $"\r\n<{currentDate}> {newTextToAdd}";
            }

            if (newDescription.Length > 200)
            {
                DialogResult truncateConfirm = MessageBox.Show("Description will be truncated to 200 characters. Continue?", "Truncate Description", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (truncateConfirm == DialogResult.No)
                {
                    return; 
                }
                newDescription = newDescription.Substring(0, 200); 
            }

            if (technicianChanged || hasNewTextToAdd)
            {
                theIncident.Description = newDescription;
                if (technicianChanged)
                {
                    theIncident.TechnicianID = ((UpdateIncident)technicianComboBox.SelectedItem).TechnicianID;
                    theIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                }
                controller.UpdateIncident(theIncident);

                descriptionTextBox.Text = theIncident.Description;
                textTextBox.Clear();
                updateErrorLabel.Text = "Incident updated successfully.";
                updateErrorLabel.ForeColor = Color.Green;
                updateErrorLabel.Visible = true;
            }
            else
            { 
                updateErrorLabel.Text = "No changes to update.";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;
            }
        }

        /// <summary>
        /// Updates the technician only.
        /// </summary>
        private void UpdateTechnicianOnly()
        {
            theIncident.TechnicianID = ((UpdateIncident)technicianComboBox.SelectedItem).TechnicianID;
            theIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
            controller.UpdateIncident(theIncident);

            updateErrorLabel.Text = "Technician updated successfully.";
            updateErrorLabel.ForeColor = Color.Green;
            updateErrorLabel.Visible = true;
        }

        /// <summary>
        /// Handles the Click event of the CloseButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (technicianComboBox.SelectedItem.ToString() == "-- Unassigned --")
            {
                updateErrorLabel.Text = "An incident cannot be closed without a technician assigned.";
                updateErrorLabel.ForeColor = Color.Red;
                updateErrorLabel.Visible = true;
                return;
            }

            DialogResult result;
            DialogResult overloadedDescription = DialogResult.OK;
            string newTextToAdd = textTextBox.Text.Trim();
            bool hasNewTextToAdd = !string.IsNullOrEmpty(newTextToAdd);
            string newDescription = descriptionTextBox.Text;

            if (hasNewTextToAdd)
            {
                string currentDate = DateTime.Now.ToShortDateString();
                newDescription += $"\r\n<{currentDate}> {newTextToAdd}";

                if (newDescription.Length > 200)
                {
                    updateErrorLabel.Text = "Description will be truncated as it exceeds 200 characters.";
                    updateErrorLabel.ForeColor = Color.Orange;
                    updateErrorLabel.Visible = true;
                    newDescription = newDescription.Substring(0, 200); 
                }
            }

            result = MessageBox.Show("Would you like to close the incident?", "Closing Incident", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == overloadedDescription)
            {
                theIncident.Description = newDescription;
                if (technicianComboBox.SelectedItem != null)
                {
                    theIncident.TechnicianName = technicianComboBox.SelectedItem.ToString();
                }

                controller.UpdateIncident(theIncident);
                controller.CloseIncident(theIncident); 

                updateErrorLabel.Text = "Incident closed successfully.";
                updateErrorLabel.ForeColor = Color.Green;
                updateErrorLabel.Visible = true;

                DisableEditing();
            }
            else
            {
                updateErrorLabel.Text = "";
                updateErrorLabel.Visible = false;
            }
        }
    }
}
