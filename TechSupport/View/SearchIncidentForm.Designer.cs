namespace TechSupport.View
{
    partial class SearchIncidentForm
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
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.incidentDataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerIDLabel.Location = new System.Drawing.Point(84, 95);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(85, 17);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "CustomerID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerIDTextBox.Location = new System.Drawing.Point(277, 95);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(229, 23);
            this.customerIDTextBox.TabIndex = 1;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.Location = new System.Drawing.Point(560, 81);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 45);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(303, 148);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 3;
            // 
            // incidentDataGridView2
            // 
            this.incidentDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView2.Location = new System.Drawing.Point(40, 206);
            this.incidentDataGridView2.Name = "incidentDataGridView2";
            this.incidentDataGridView2.RowTemplate.Height = 28;
            this.incidentDataGridView2.Size = new System.Drawing.Size(719, 217);
            this.incidentDataGridView2.TabIndex = 4;
            // 
            // SearchIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incidentDataGridView2);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.customerIDLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Incident";
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView incidentDataGridView2;
    }
}