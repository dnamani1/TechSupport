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
            this.addIncidentUserControls = new TechSupport.UserControls.AddIncidentUserControl();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.dbLabel = new System.Windows.Forms.Label();
            this.displayOpenIncidentUserControls = new TechSupport.UserControls.DisplayOpenIncidentUserControl();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mainDashBoardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainDashBoardTabControl
            // 
            this.mainDashBoardTabControl.Controls.Add(this.addIncidentTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.displayOpenIncidentsTabPage);
            this.mainDashBoardTabControl.Controls.Add(this.updateTabPage);
            this.mainDashBoardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDashBoardTabControl.Location = new System.Drawing.Point(2, 9);
            this.mainDashBoardTabControl.Name = "mainDashBoardTabControl";
            this.mainDashBoardTabControl.SelectedIndex = 0;
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(1012, 843);
            this.mainDashBoardTabControl.TabIndex = 0;
            this.mainDashBoardTabControl.SelectedIndexChanged += new System.EventHandler(this.MainDashBoardTabControl_SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControls);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(1004, 810);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControls
            // 
            this.addIncidentUserControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentUserControls.Location = new System.Drawing.Point(3, 0);
            this.addIncidentUserControls.Name = "addIncidentUserControls";
            this.addIncidentUserControls.Size = new System.Drawing.Size(920, 668);
            this.addIncidentUserControls.TabIndex = 0;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.dbLabel);
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControls);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(1004, 810);
            this.displayOpenIncidentsTabPage.TabIndex = 4;
            this.displayOpenIncidentsTabPage.Text = "Display Open Incidents";
            this.displayOpenIncidentsTabPage.UseVisualStyleBackColor = true;
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbLabel.Location = new System.Drawing.Point(358, 211);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(0, 25);
            this.dbLabel.TabIndex = 1;
            // 
            // displayOpenIncidentUserControls
            // 
            this.displayOpenIncidentUserControls.Location = new System.Drawing.Point(0, 0);
            this.displayOpenIncidentUserControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayOpenIncidentUserControls.Name = "displayOpenIncidentUserControls";
            this.displayOpenIncidentUserControls.Size = new System.Drawing.Size(992, 800);
            this.displayOpenIncidentUserControls.TabIndex = 0;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Location = new System.Drawing.Point(4, 29);
            this.updateTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTabPage.Size = new System.Drawing.Size(1004, 810);
            this.updateTabPage.TabIndex = 5;
            this.updateTabPage.Text = "Update Incident";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(658, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 20);
            this.userLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutLinkLabel.Location = new System.Drawing.Point(714, 9);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.logoutLinkLabel.TabIndex = 2;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 714);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.mainDashBoardTabControl);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDashboard";
            this.mainDashBoardTabControl.ResumeLayout(false);
            this.addIncidentTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.ResumeLayout(false);
            this.displayOpenIncidentsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControls;
        private Label userLabel;
        private LinkLabel logoutLinkLabel;
        private TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentUserControl displayOpenIncidentUserControls;
        private Label dbLabel;
        private TabPage updateTabPage;

    }
}