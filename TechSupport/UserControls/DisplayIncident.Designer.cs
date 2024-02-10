namespace TechSupport.UserControls
{
    partial class DisplayIncident
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
            this.incidentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // incidentDataGridView
            // 
            this.incidentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentDataGridView.Location = new System.Drawing.Point(0, 0);
            this.incidentDataGridView.Name = "incidentDataGridView";
            this.incidentDataGridView.RowHeadersWidth = 62;
            this.incidentDataGridView.RowTemplate.Height = 28;
            this.incidentDataGridView.Size = new System.Drawing.Size(796, 397);
            this.incidentDataGridView.TabIndex = 1;
            // 
            // DisplayIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentDataGridView);
            this.Name = "DisplayIncident";
            this.Size = new System.Drawing.Size(796, 397);
            ((System.ComponentModel.ISupportInitialize)(this.incidentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView incidentDataGridView;
    }
}
