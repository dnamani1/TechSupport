namespace TechSupport.UserControls
{
    partial class SearchIncident
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
            this.searchCustomerIDLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchCustomerIDErrorLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCustomerIDLabel
            // 
            this.searchCustomerIDLabel.AutoSize = true;
            this.searchCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDLabel.Location = new System.Drawing.Point(22, 65);
            this.searchCustomerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCustomerIDLabel.Name = "searchCustomerIDLabel";
            this.searchCustomerIDLabel.Size = new System.Drawing.Size(152, 20);
            this.searchCustomerIDLabel.TabIndex = 0;
            this.searchCustomerIDLabel.Text = "Customer Name : ";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(397, 62);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(44, 163);
            this.searchDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 62;
            this.searchDataGridView.RowTemplate.Height = 28;
            this.searchDataGridView.Size = new System.Drawing.Size(468, 244);
            this.searchDataGridView.TabIndex = 3;
            // 
            // searchCustomerIDErrorLabel
            // 
            this.searchCustomerIDErrorLabel.AutoSize = true;
            this.searchCustomerIDErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDErrorLabel.Location = new System.Drawing.Point(185, 115);
            this.searchCustomerIDErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCustomerIDErrorLabel.Name = "searchCustomerIDErrorLabel";
            this.searchCustomerIDErrorLabel.Size = new System.Drawing.Size(0, 20);
            this.searchCustomerIDErrorLabel.TabIndex = 4;
            // 
            // customerComboBox
            // 
            this.customerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(189, 62);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(180, 28);
            this.customerComboBox.TabIndex = 5;
            // 
            // SearchIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.searchCustomerIDErrorLabel);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCustomerIDLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchIncident";
            this.Size = new System.Drawing.Size(562, 459);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCustomerIDLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Label searchCustomerIDErrorLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
    }
}
