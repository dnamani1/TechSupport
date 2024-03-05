namespace TechSupport.UserControls
{
    partial class UpdateIncidentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.incidentIdLabel = new System.Windows.Forms.Label();
            this.incidentIdTextBox = new System.Windows.Forms.TextBox();
            this.GetButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.dateOpenedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.incidentIdErrorLabel = new System.Windows.Forms.Label();
            this.updateErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incidentIdLabel
            // 
            this.incidentIdLabel.AutoSize = true;
            this.incidentIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentIdLabel.Location = new System.Drawing.Point(48, 20);
            this.incidentIdLabel.Name = "incidentIdLabel";
            this.incidentIdLabel.Size = new System.Drawing.Size(108, 20);
            this.incidentIdLabel.TabIndex = 0;
            this.incidentIdLabel.Text = "Incident ID :";
            // 
            // incidentIdTextBox
            // 
            this.incidentIdTextBox.Location = new System.Drawing.Point(158, 20);
            this.incidentIdTextBox.Name = "incidentIdTextBox";
            this.incidentIdTextBox.Size = new System.Drawing.Size(242, 20);
            this.incidentIdTextBox.TabIndex = 1;
            // 
            // GetButton
            // 
            this.GetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetButton.Location = new System.Drawing.Point(431, 14);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(69, 23);
            this.GetButton.TabIndex = 2;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetIncidentButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(48, 57);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(96, 20);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customer :";
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(158, 57);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.ReadOnly = true;
            this.customerTextBox.Size = new System.Drawing.Size(387, 20);
            this.customerTextBox.TabIndex = 4;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(48, 96);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(81, 20);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Product :";
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(158, 96);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(387, 20);
            this.productTextBox.TabIndex = 6;
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technicianLabel.Location = new System.Drawing.Point(48, 132);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(105, 20);
            this.technicianLabel.TabIndex = 7;
            this.technicianLabel.Text = "Technician :";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(48, 171);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(53, 20);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Title :";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(158, 171);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(387, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(158, 130);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(387, 21);
            this.technicianComboBox.TabIndex = 11;
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOpenedLabel.Location = new System.Drawing.Point(48, 219);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Size = new System.Drawing.Size(126, 20);
            this.dateOpenedLabel.TabIndex = 12;
            this.dateOpenedLabel.Text = "Date Opened :";
            // 
            // dateOpenedTextBox
            // 
            this.dateOpenedTextBox.Location = new System.Drawing.Point(158, 219);
            this.dateOpenedTextBox.Name = "dateOpenedTextBox";
            this.dateOpenedTextBox.ReadOnly = true;
            this.dateOpenedTextBox.Size = new System.Drawing.Size(188, 20);
            this.dateOpenedTextBox.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(48, 263);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(110, 20);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Description :";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(158, 261);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(387, 59);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(48, 340);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(115, 20);
            this.textLabel.TabIndex = 16;
            this.textLabel.Text = "Text To Add :";
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(158, 338);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(387, 57);
            this.textTextBox.TabIndex = 17;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(77, 410);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(91, 24);
            this.updateButton.TabIndex = 18;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(273, 410);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(65, 24);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(449, 411);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(74, 22);
            this.ClearButton.TabIndex = 20;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // incidentIdErrorLabel
            // 
            this.incidentIdErrorLabel.AutoSize = true;
            this.incidentIdErrorLabel.Location = new System.Drawing.Point(162, 41);
            this.incidentIdErrorLabel.Name = "incidentIdErrorLabel";
            this.incidentIdErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.incidentIdErrorLabel.TabIndex = 21;
            // 
            // updateErrorLabel
            // 
            this.updateErrorLabel.AutoSize = true;
            this.updateErrorLabel.Location = new System.Drawing.Point(287, 448);
            this.updateErrorLabel.Name = "updateErrorLabel";
            this.updateErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.updateErrorLabel.TabIndex = 22;
            // 
            // UpdateIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.updateErrorLabel);
            this.Controls.Add(this.incidentIdErrorLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateOpenedTextBox);
            this.Controls.Add(this.dateOpenedLabel);
            this.Controls.Add(this.technicianComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.GetButton);
            this.Controls.Add(this.incidentIdTextBox);
            this.Controls.Add(this.incidentIdLabel);
            this.Name = "UpdateIncidentUserControl";
            this.Size = new System.Drawing.Size(642, 481);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidentIdLabel;
        private System.Windows.Forms.TextBox incidentIdTextBox;
        private System.Windows.Forms.Button GetButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.TextBox dateOpenedTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label incidentIdErrorLabel;
        private System.Windows.Forms.Label updateErrorLabel;
    }
}
