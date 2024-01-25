namespace TechSupport.View
{
    partial class AddIncidentForm
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
            this.addIncidentlabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.customerIDlabel = new System.Windows.Forms.Label();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.addIncidentButton = new System.Windows.Forms.Button();
            this.cancleButton = new System.Windows.Forms.Button();
            this.titleErrorLabel = new System.Windows.Forms.Label();
            this.descriptionErrorLabel = new System.Windows.Forms.Label();
            this.customerErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addIncidentlabel
            // 
            this.addIncidentlabel.AutoSize = true;
            this.addIncidentlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentlabel.Location = new System.Drawing.Point(278, 23);
            this.addIncidentlabel.Name = "addIncidentlabel";
            this.addIncidentlabel.Size = new System.Drawing.Size(152, 20);
            this.addIncidentlabel.TabIndex = 0;
            this.addIncidentlabel.Text = "Add Incident Details";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(173, 101);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(316, 98);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(270, 23);
            this.titleTextBox.TabIndex = 2;
            this.titleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(173, 189);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(316, 169);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(270, 72);
            this.descriptionTextBox.TabIndex = 4;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // customerIDlabel
            // 
            this.customerIDlabel.AutoSize = true;
            this.customerIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDlabel.Location = new System.Drawing.Point(173, 287);
            this.customerIDlabel.Name = "customerIDlabel";
            this.customerIDlabel.Size = new System.Drawing.Size(85, 17);
            this.customerIDlabel.TabIndex = 5;
            this.customerIDlabel.Text = "CustomerID:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTextBox.Location = new System.Drawing.Point(316, 287);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(270, 23);
            this.customerIDTextBox.TabIndex = 6;
            this.customerIDTextBox.TextChanged += new System.EventHandler(this.CustomerIDTextBox_TextChanged);
            // 
            // addIncidentButton
            // 
            this.addIncidentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addIncidentButton.Location = new System.Drawing.Point(178, 357);
            this.addIncidentButton.Name = "addIncidentButton";
            this.addIncidentButton.Size = new System.Drawing.Size(175, 49);
            this.addIncidentButton.TabIndex = 7;
            this.addIncidentButton.Text = "Add Incident";
            this.addIncidentButton.UseVisualStyleBackColor = true;
            // 
            // cancleButton
            // 
            this.cancleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancleButton.Location = new System.Drawing.Point(456, 357);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(130, 49);
            this.cancleButton.TabIndex = 8;
            this.cancleButton.Text = "Cancel";
            this.cancleButton.UseVisualStyleBackColor = true;
            // 
            // titleErrorLabel
            // 
            this.titleErrorLabel.AutoSize = true;
            this.titleErrorLabel.Location = new System.Drawing.Point(316, 135);
            this.titleErrorLabel.Name = "titleErrorLabel";
            this.titleErrorLabel.Size = new System.Drawing.Size(108, 20);
            this.titleErrorLabel.TabIndex = 9;
            this.titleErrorLabel.Text = "titleErrorLabel";
            // 
            // descriptionErrorLabel
            // 
            this.descriptionErrorLabel.AutoSize = true;
            this.descriptionErrorLabel.Location = new System.Drawing.Point(316, 248);
            this.descriptionErrorLabel.Name = "descriptionErrorLabel";
            this.descriptionErrorLabel.Size = new System.Drawing.Size(160, 20);
            this.descriptionErrorLabel.TabIndex = 10;
            this.descriptionErrorLabel.Text = "descriptionErrorLabel";
            // 
            // customerErrorLabel
            // 
            this.customerErrorLabel.AutoSize = true;
            this.customerErrorLabel.Location = new System.Drawing.Point(316, 324);
            this.customerErrorLabel.Name = "customerErrorLabel";
            this.customerErrorLabel.Size = new System.Drawing.Size(149, 20);
            this.customerErrorLabel.TabIndex = 11;
            this.customerErrorLabel.Text = "customerErrorLabel";
            // 
            // AddIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerErrorLabel);
            this.Controls.Add(this.descriptionErrorLabel);
            this.Controls.Add(this.titleErrorLabel);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.addIncidentButton);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.customerIDlabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addIncidentlabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Incident";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addIncidentlabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label customerIDlabel;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.Button addIncidentButton;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Label titleErrorLabel;
        private System.Windows.Forms.Label descriptionErrorLabel;
        private System.Windows.Forms.Label customerErrorLabel;
    }
}