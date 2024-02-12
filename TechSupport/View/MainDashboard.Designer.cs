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
            this.displayIncidentTabPage = new System.Windows.Forms.TabPage();
            this.displayMessageLabel = new System.Windows.Forms.Label();
            this.searchIncidentTabPage = new System.Windows.Forms.TabPage();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.dbLabel = new System.Windows.Forms.Label();
            this.addIncidentUserControls = new TechSupport.UserControls.AddIncident();
            this.displayIncidentUserControls = new TechSupport.UserControls.DisplayIncident();
            this.searchIncidentUserControls = new TechSupport.UserControls.SearchIncident();
            this.displayOpenIncidentUserControls = new TechSupport.UserControls.DisplayOpenIncident();
            this.mainDashBoardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.displayIncidentTabPage.SuspendLayout();
            this.searchIncidentTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.displayIncidentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.searchIncidentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.mainDashBoardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(1, 10);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(827, 464);
            this.mainDashBoardTabControl.TabIndex = 0;
            this.mainDashBoardTabControl.SelectedIndexChanged += new System.EventHandler(this.DisplayIncident);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControls);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(819, 431);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // displayIncidentTabPage
            // 
            this.displayIncidentTabPage.Controls.Add(this.displayMessageLabel);
            this.displayIncidentTabPage.Controls.Add(this.displayIncidentUserControls);
            this.displayIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.displayIncidentTabPage.Name = "displayIncidentTabPage";
            this.displayIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayIncidentTabPage.Size = new System.Drawing.Size(819, 431);
            this.displayIncidentTabPage.TabIndex = 1;
            this.displayIncidentTabPage.Text = "Display All Incident";
            this.displayIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // displayMessageLabel
            // 
            this.displayMessageLabel.AutoSize = true;
            this.displayMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayMessageLabel.Location = new System.Drawing.Point(538, 98);
            this.displayMessageLabel.Name = "displayMessageLabel";
            this.displayMessageLabel.Size = new System.Drawing.Size(0, 25);
            this.displayMessageLabel.TabIndex = 1;
            // 
            // searchIncidentTabPage
            // 
            this.searchIncidentTabPage.Controls.Add(this.searchIncidentUserControls);
            this.searchIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.searchIncidentTabPage.Name = "searchIncidentTabPage";
            this.searchIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchIncidentTabPage.Size = new System.Drawing.Size(819, 431);
            this.searchIncidentTabPage.TabIndex = 3;
            this.searchIncidentTabPage.Text = "Search Incident";
            this.searchIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.dbLabel);
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControls);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(819, 431);
            this.displayOpenIncidentsTabPage.TabIndex = 4;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(658, 10);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 20);
            this.userLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(714, 10);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLabel.Location = new System.Drawing.Point(359, 211);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(0, 25);
            this.dbLabel.TabIndex = 1;
            // 
            // addIncidentUserControls
            // 
            this.addIncidentUserControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControls.Location = new System.Drawing.Point(-4, 3);
            this.addIncidentUserControls.Name = "addIncidentUserControls";
            this.addIncidentUserControls.Size = new System.Drawing.Size(813, 440);
            this.addIncidentUserControls.TabIndex = 0;
            // 
            // displayIncidentUserControls
            // 
            this.displayIncidentUserControls.Location = new System.Drawing.Point(-4, 0);
            this.displayIncidentUserControls.Name = "displayIncidentUserControls";
            this.displayIncidentUserControls.Size = new System.Drawing.Size(800, 397);
            this.displayIncidentUserControls.TabIndex = 0;
            // 
            // searchIncidentUserControls
            // 
            this.searchIncidentUserControls.Location = new System.Drawing.Point(-16, -29);
            this.searchIncidentUserControls.Name = "searchIncidentUserControls";
            this.searchIncidentUserControls.Size = new System.Drawing.Size(952, 497);
            this.searchIncidentUserControls.TabIndex = 0;
            // 
            // displayOpenIncidentUserControls
            // 
            this.displayOpenIncidentUserControls.Location = new System.Drawing.Point(0, 0);
            this.displayOpenIncidentUserControls.Name = "displayOpenIncidentUserControls";
            this.displayOpenIncidentUserControls.Size = new System.Drawing.Size(819, 435);
            this.displayOpenIncidentUserControls.TabIndex = 0;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 474);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.mainDashBoardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainDashBoardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.displayIncidentTabPage.ResumeLayout(false);
            this.displayIncidentTabPage.PerformLayout();
            this.searchIncidentTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private System.Windows.Forms.TabPage displayIncidentTabPage;
        private System.Windows.Forms.TabPage searchIncidentTabPage;
        private UserControls.AddIncident addIncidentUserControls;
        private UserControls.DisplayIncident displayIncidentUserControls;
        private UserControls.SearchIncident searchIncidentUserControls;
        private Label userLabel;
        private LinkLabel logoutLinkLabel;
        private Label displayMessageLabel;
        private TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncident displayOpenIncidentUserControls;
        private Label dbLabel;
    }
}