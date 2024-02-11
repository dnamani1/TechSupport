namespace TechSupport.UserControls
{
    partial class DisplayOpenIncident
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
            this.incidentListView = new System.Windows.Forms.ListView();
            this.productCodeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOpenedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // incidentListView
            // 
            this.incidentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeColumnHeader,
            this.DateOpenedColumnHeader,
            this.customerColumnHeader,
            this.technicianColumnHeader,
            this.titleColumnHeader});
            this.incidentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentListView.Location = new System.Drawing.Point(0, 0);
            this.incidentListView.Name = "incidentListView";
            this.incidentListView.Size = new System.Drawing.Size(742, 408);
            this.incidentListView.TabIndex = 0;
            this.incidentListView.UseCompatibleStateImageBehavior = false;
            this.incidentListView.View = System.Windows.Forms.View.Details;
            // 
            // productCodeColumnHeader
            // 
            this.productCodeColumnHeader.Text = "Product Code";
            this.productCodeColumnHeader.Width = 140;
            // 
            // DateOpenedColumnHeader
            // 
            this.DateOpenedColumnHeader.Text = "Date Opened";
            this.DateOpenedColumnHeader.Width = 140;
            // 
            // customerColumnHeader
            // 
            this.customerColumnHeader.Text = "Customer";
            this.customerColumnHeader.Width = 140;
            // 
            // technicianColumnHeader
            // 
            this.technicianColumnHeader.Text = "Technician";
            this.technicianColumnHeader.Width = 140;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.Width = 150;
            // 
            // DisplayOpenIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentListView);
            this.Name = "DisplayOpenIncident";
            this.Size = new System.Drawing.Size(742, 408);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView incidentListView;
        private System.Windows.Forms.ColumnHeader productCodeColumnHeader;
        private System.Windows.Forms.ColumnHeader DateOpenedColumnHeader;
        private System.Windows.Forms.ColumnHeader customerColumnHeader;
        private System.Windows.Forms.ColumnHeader technicianColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
    }
}
