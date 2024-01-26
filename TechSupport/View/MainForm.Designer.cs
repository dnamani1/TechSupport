namespace TechSupport.View
{
    partial class MainForm
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
            this.usernameLable = new System.Windows.Forms.Label();
            this.logoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.searchIncidentButton = new System.Windows.Forms.Button();
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Location = new System.Drawing.Point(697, 21);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(80, 20);
            this.usernameLable.TabIndex = 0;
            this.usernameLable.Text = "username";
            // 
            // logoutLinkLabel
            // 
            this.logoutLinkLabel.AutoSize = true;
            this.logoutLinkLabel.Location = new System.Drawing.Point(697, 52);
            this.logoutLinkLabel.Name = "logoutLinkLabel";
            this.logoutLinkLabel.Size = new System.Drawing.Size(53, 20);
            this.logoutLinkLabel.TabIndex = 1;
            this.logoutLinkLabel.TabStop = true;
            this.logoutLinkLabel.Text = "logout";
            this.logoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Location = new System.Drawing.Point(207, 99);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(128, 53);
            this.addIncidentButton.TabIndex = 2;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // searchIncidentButton
            // 
            this.searchIncidentButton.Location = new System.Drawing.Point(452, 99);
            this.searchIncidentButton.Name = "searchIncidentButton";
            this.searchIncidentButton.Size = new System.Drawing.Size(134, 53);
            this.searchIncidentButton.TabIndex = 3;
            this.searchIncidentButton.Text = "Search Incident";
            this.searchIncidentButton.UseVisualStyleBackColor = true;
            this.searchIncidentButton.Click += new System.EventHandler(this.SearchIncidentButton_Click);
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Location = new System.Drawing.Point(36, 210);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.RowHeadersWidth = 62;
            this.incidentDataGridView.RowTemplate.Height = 28;
            this.incidentDataGridView.Size = new System.Drawing.Size(725, 225);
            this.incidentDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidentDataGridView);
            this.Controls.Add(this.searchIncidentButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.logoutLinkLabel);
            this.Controls.Add(this.usernameLable);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechSupport";
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.LinkLabel logoutLinkLabel;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button searchIncidentButton;
        private System.Windows.Forms.DataGridView incidentDataGridView;
    }
}