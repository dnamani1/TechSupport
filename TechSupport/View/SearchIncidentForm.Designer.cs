namespace TechSupport.View
{
    partial class searchIncidentForm
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
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerIDLabel.Location = new System.Drawing.Point(96, 174);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(122, 25);
            this.customerIDLabel.TabIndex = 0;
            this.customerIDLabel.Text = "CustomerID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customerIDTextBox.Location = new System.Drawing.Point(296, 169);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(229, 30);
            this.customerIDTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchButton.Location = new System.Drawing.Point(568, 154);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(133, 45);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(292, 211);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 20);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "errorLabel";
            // 
            // searchIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.customerIDLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "searchIncidentForm";
            this.Text = "Search Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label errorLabel;
    }
}