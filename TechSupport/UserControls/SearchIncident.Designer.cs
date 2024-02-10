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
            this.searchCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchCustomerIDErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCustomerIDLabel
            // 
            this.searchCustomerIDLabel.AutoSize = true;
            this.searchCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCustomerIDLabel.Location = new System.Drawing.Point(136, 125);
            this.searchCustomerIDLabel.Name = "searchCustomerIDLabel";
            this.searchCustomerIDLabel.Size = new System.Drawing.Size(120, 20);
            this.searchCustomerIDLabel.TabIndex = 0;
            this.searchCustomerIDLabel.Text = "CustomerID : ";
            // 
            // searchCustomerIDTextBox
            // 
            this.searchCustomerIDTextBox.Location = new System.Drawing.Point(327, 122);
            this.searchCustomerIDTextBox.Name = "searchCustomerIDTextBox";
            this.searchCustomerIDTextBox.Size = new System.Drawing.Size(211, 26);
            this.searchCustomerIDTextBox.TabIndex = 1;
            this.searchCustomerIDTextBox.TextChanged += new System.EventHandler(this.SearchCustomerIDTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(612, 119);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 32);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(77, 244);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowHeadersWidth = 62;
            this.searchDataGridView.RowTemplate.Height = 28;
            this.searchDataGridView.Size = new System.Drawing.Size(687, 215);
            this.searchDataGridView.TabIndex = 3;
            // 
            // searchCustomerIDErrorLabel
            // 
            this.searchCustomerIDErrorLabel.AutoSize = true;
            this.searchCustomerIDErrorLabel.Location = new System.Drawing.Point(417, 155);
            this.searchCustomerIDErrorLabel.Name = "searchCustomerIDErrorLabel";
            this.searchCustomerIDErrorLabel.Size = new System.Drawing.Size(42, 20);
            this.searchCustomerIDErrorLabel.TabIndex = 4;
            this.searchCustomerIDErrorLabel.Text = "error";
            // 
            // SearchIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchCustomerIDErrorLabel);
            this.Controls.Add(this.searchDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchCustomerIDTextBox);
            this.Controls.Add(this.searchCustomerIDLabel);
            this.Name = "SearchIncident";
            this.Size = new System.Drawing.Size(845, 500);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchCustomerIDLabel;
        private System.Windows.Forms.TextBox searchCustomerIDTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.Label searchCustomerIDErrorLabel;
    }
}
