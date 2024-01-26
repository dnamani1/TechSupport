﻿using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Form to display main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private IncidentController _incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _incidentController = new IncidentController();
            usernameLable.Text = _incidentController.GetUsername();

        }

        /// <summary>
        /// Sets the controller.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public void SetController(IncidentController controller)
        {
            _incidentController = controller;
        }

        /// <summary>
        /// Handles the Click event of the AddIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddIncidentButton_Click(object sender, EventArgs e)
        {
            var addIncident = new AddIncidentForm();
            var result = addIncident.ShowDialog();

            if(result == DialogResult.OK)
            {
                RefreshIncidentsDataGrid();
            }

        }

        /// <summary>
        /// Refreshes the incidents data grid.
        /// </summary>
        private void RefreshIncidentsDataGrid()
        {
            incidentDataGridView.DataSource = null;
            incidentDataGridView.DataSource = _incidentController.GetIncidents();
            incidentDataGridView.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the SearchIncidentButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchIncidentButton_Click(object sender, EventArgs e)
        {
            var searchIncidentButton = new SearchIncidentForm();
            searchIncidentButton.ShowDialog();
        }

        /// <summary>
        /// Handles the LinkClicked event of the LogoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
