using System.Windows.Forms;

namespace TechSupport.View
{
    partial class MainDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainDashBoardTabControl = new System.Windows.Forms.TabControl();
            this.addIncidentTabPage = new System.Windows.Forms.TabPage();
            this.addIncidentUserControls = new TechSupport.UserControls.AddIncident();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.dbLabel = new System.Windows.Forms.Label();
            this.displayOpenIncidentUserControls = new TechSupport.UserControls.DisplayOpenIncident();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.searchIncident1 = new TechSupport.UserControls.SearchIncident();
            this.mainDashBoardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.searchTabPage);
            this.mainDashBoardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(1, 6);
            this.mainDashBoardTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(675, 548);
            this.mainDashBoardTabControl.TabIndex = 0;
            this.mainDashBoardTabControl.SelectedIndexChanged += new System.EventHandler(this.MainDashBoardTabControl_SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControls);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.addIncidentTabPage.Size = new System.Drawing.Size(667, 515);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControls
            // 
            this.addIncidentUserControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControls.Location = new System.Drawing.Point(2, 0);
            this.addIncidentUserControls.Margin = new System.Windows.Forms.Padding(2);
            this.addIncidentUserControls.Name = "addIncidentUserControls";
            this.addIncidentUserControls.Size = new System.Drawing.Size(613, 434);
            this.addIncidentUserControls.TabIndex = 0;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.dbLabel);
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControls);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidentsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(667, 515);
            this.displayOpenIncidentsTabPage.TabIndex = 4;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLabel.Location = new System.Drawing.Point(239, 137);
            this.dbLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(0, 25);
            this.dbLabel.TabIndex = 1;
            // 
            // displayOpenIncidentUserControls
            // 
            this.displayOpenIncidentUserControls.Location = new System.Drawing.Point(0, 0);
            this.displayOpenIncidentUserControls.Margin = new System.Windows.Forms.Padding(1);
            this.displayOpenIncidentUserControls.Name = "displayOpenIncidentUserControls";
            this.displayOpenIncidentUserControls.Size = new System.Drawing.Size(661, 520);
            this.displayOpenIncidentUserControls.TabIndex = 0;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchIncident1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(667, 515);
            this.searchTabPage.TabIndex = 5;
            this.searchTabPage.Text = "Search Incident";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(439, 6);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 13);
            this.userLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(476, 6);
            this.logoutLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // searchIncident1
            // 
            this.searchIncident1.Location = new System.Drawing.Point(29, 6);
            this.searchIncident1.Name = "searchIncident1";
            this.searchIncident1.Size = new System.Drawing.Size(614, 429);
            this.searchIncident1.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 464);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.mainDashBoardTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainDashBoardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.PerformLayout();
            this.searchTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.AddIncident addIncidentUserControls;
        private Label userLabel;
        private LinkLabel logoutLinkLabel;
        private TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncident displayOpenIncidentUserControls;
        private Label dbLabel;
        private TabPage searchTabPage;
        private UserControls.SearchIncident searchIncident1;
    }
}