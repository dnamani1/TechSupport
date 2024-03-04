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
            this.addIncidentUserControl1 = new TechSupport.UserControls.AddIncidentUserControl();
            this.displayOpenIncidentsTabPage = new System.Windows.Forms.TabPage();
            this.dbLabel = new System.Windows.Forms.Label();
            this.displayOpenIncidentUserControls = new TechSupport.UserControls.DisplayOpenIncidentUserControl();
            this.updateTabPage = new System.Windows.Forms.TabPage();
            this.updateIncidentUserControl1 = new TechSupport.UserControls.UpdateIncidentUserControl();
            this.userLabel = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.mainDashBoardTabControl.SuspendLayout();
            this.addIncidentTabPage.SuspendLayout();
            this.displayOpenIncidentsTabPage.SuspendLayout();
            this.updateTabPage.SuspendLayout();
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
            this.mainDashBoardTabControl.Size = new System.Drawing.Size(1077, 888);
            this.mainDashBoardTabControl.TabIndex = 0;
            this.mainDashBoardTabControl.SelectedIndexChanged += new System.EventHandler(this.MainDashBoardTabControl_SelectedIndexChanged);
            // 
            // addIncidentTabPage
            // 
            this.addIncidentTabPage.Controls.Add(this.addIncidentUserControl1);
            this.addIncidentTabPage.Location = new System.Drawing.Point(4, 29);
            this.addIncidentTabPage.Name = "addIncidentTabPage";
            this.addIncidentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addIncidentTabPage.Size = new System.Drawing.Size(1069, 855);
            this.addIncidentTabPage.TabIndex = 0;
            this.addIncidentTabPage.Text = "Add Incident";
            this.addIncidentTabPage.UseVisualStyleBackColor = true;
            // 
            // addIncidentUserControl1
            // 
            this.addIncidentUserControl1.Location = new System.Drawing.Point(58, 97);
            this.addIncidentUserControl1.Name = "addIncidentUserControl1";
            this.addIncidentUserControl1.Size = new System.Drawing.Size(833, 612);
            this.addIncidentUserControl1.TabIndex = 0;
            // 
            // displayOpenIncidentsTabPage
            // 
            this.displayOpenIncidentsTabPage.Controls.Add(this.dbLabel);
            this.displayOpenIncidentsTabPage.Controls.Add(this.displayOpenIncidentUserControls);
            this.displayOpenIncidentsTabPage.Location = new System.Drawing.Point(4, 29);
            this.displayOpenIncidentsTabPage.Name = "displayOpenIncidentsTabPage";
            this.displayOpenIncidentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.displayOpenIncidentsTabPage.Size = new System.Drawing.Size(1069, 855);
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
            this.displayOpenIncidentUserControls.Location = new System.Drawing.Point(35, 46);
            this.displayOpenIncidentUserControls.Margin = new System.Windows.Forms.Padding(2);
            this.displayOpenIncidentUserControls.Name = "displayOpenIncidentUserControls";
            this.displayOpenIncidentUserControls.Size = new System.Drawing.Size(991, 777);
            this.displayOpenIncidentUserControls.TabIndex = 0;
            // 
            // updateTabPage
            // 
            this.updateTabPage.Controls.Add(this.updateIncidentUserControl1);
            this.updateTabPage.Location = new System.Drawing.Point(4, 29);
            this.updateTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTabPage.Name = "updateTabPage";
            this.updateTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateTabPage.Size = new System.Drawing.Size(1069, 855);
            this.updateTabPage.TabIndex = 5;
            this.updateTabPage.Text = "Update Incident";
            this.updateTabPage.UseVisualStyleBackColor = true;
            // 
            // updateIncidentUserControl1
            // 
            this.updateIncidentUserControl1.Location = new System.Drawing.Point(69, 47);
            this.updateIncidentUserControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateIncidentUserControl1.Name = "updateIncidentUserControl1";
            this.updateIncidentUserControl1.Size = new System.Drawing.Size(908, 751);
            this.updateIncidentUserControl1.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(1076, 899);
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
            this.updateTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainDashBoardTabControl;
        private System.Windows.Forms.TabPage addIncidentTabPage;
        private Label userLabel;
        private LinkLabel logoutLinkLabel;
        private TabPage displayOpenIncidentsTabPage;
        private UserControls.DisplayOpenIncidentUserControl displayOpenIncidentUserControls;
        private Label dbLabel;
        private TabPage updateTabPage;
        private UserControls.AddIncidentUserControl addIncidentUserControl1;
        private UserControls.UpdateIncidentUserControl updateIncidentUserControl1;
    }
}