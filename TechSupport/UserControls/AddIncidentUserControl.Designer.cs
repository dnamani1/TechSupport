﻿namespace TechSupport.UserControls
{
    partial class AddIncidentUserControl
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
            this.addIncidentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titleErrorLabel = new System.Windows.Forms.Label();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.productLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addIncidentLabel
            // 
            this.addIncidentLabel.AutoSize = true;
            this.addIncidentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentLabel.Location = new System.Drawing.Point(363, 29);
            this.addIncidentLabel.Name = "addIncidentLabel";
            this.addIncidentLabel.Size = new System.Drawing.Size(205, 25);
            this.addIncidentLabel.TabIndex = 0;
            this.addIncidentLabel.Text = "Add Incident Details";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(230, 254);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(58, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title : ";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(400, 248);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(208, 26);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(230, 325);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(115, 20);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description : ";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(400, 322);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(208, 82);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentButton.Location = new System.Drawing.Point(234, 468);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(216, 63);
            this.addIncidentButton.TabIndex = 7;
            this.addIncidentButton.Text = "Create Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            this.addIncidentButton.Click += new System.EventHandler(this.AddIncidentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(498, 482);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 49);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // titleErrorLabel
            // 
            this.titleErrorLabel.AutoSize = true;
            this.titleErrorLabel.Location = new System.Drawing.Point(396, 288);
            this.titleErrorLabel.Name = "titleErrorLabel";
            this.titleErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.titleErrorLabel.TabIndex = 10;
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Location = new System.Drawing.Point(396, 422);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.descriptionErrorLabel.TabIndex = 11;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(233, 128);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(96, 20);
            this.customerLabel.TabIndex = 12;
            this.customerLabel.Text = "Customer :";
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productLabel.Location = new System.Drawing.Point(233, 191);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(81, 20);
            this.productLabel.TabIndex = 13;
            this.productLabel.Text = "Product :";
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(400, 128);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(208, 28);
            this.customerComboBox.TabIndex = 14;
            // 
            // productComboBox
            // 
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(400, 188);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(208, 28);
            this.productComboBox.TabIndex = 15;
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.Location = new System.Drawing.Point(288, 534);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.customerErrorLabel.TabIndex = 16;
            // 
            // AddIncidentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerErrorLabel);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.titleErrorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addIncidentLabel);
            this.Name = "AddIncidentUserControl";
            this.Size = new System.Drawing.Size(796, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addIncidentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label titleErrorLabel;
        private System.Windows.Forms.Label descriptionErrorLabel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label customerErrorLabel;
    }
}
