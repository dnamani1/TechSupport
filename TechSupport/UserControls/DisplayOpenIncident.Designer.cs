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
            this.dateOpenedColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.technicianColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // incidentListView
            // 
            this.incidentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productCodeColumnHeader,
            this.dateOpenedColumnHeader,
            this.customerColumnHeader,
            this.technicianColumnHeader,
            this.titleColumnHeader});
            this.incidentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.incidentListView.HideSelection = false;
            this.incidentListView.Location = new System.Drawing.Point(0, 0);
            this.incidentListView.Name = "incidentListView";
            this.incidentListView.Size = new System.Drawing.Size(819, 435);
            this.incidentListView.TabIndex = 0;
            this.incidentListView.UseCompatibleStateImageBehavior = false;
            this.incidentListView.View = System.Windows.Forms.View.Details;
            // 
            // productCodeColumnHeader
            // 
            this.productCodeColumnHeader.Text = "Product Code";
            this.productCodeColumnHeader.Width = 110;
            // 
            // dateOpenedColumnHeader
            // 
            this.dateOpenedColumnHeader.Text = "Date Opened";
            this.dateOpenedColumnHeader.Width = 110;
            // 
            // customerColumnHeader
            // 
            this.customerColumnHeader.Text = "Customer";
            this.customerColumnHeader.Width = 110;
            // 
            // technicianColumnHeader
            // 
            this.technicianColumnHeader.Text = "Technician";
            this.technicianColumnHeader.Width = 110;
            // 
            // titleColumnHeader
            // 
            this.titleColumnHeader.Text = "Title";
            this.titleColumnHeader.Width = 110;
            // 
            // DisplayOpenIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.incidentListView);
            this.Name = "DisplayOpenIncident";
            this.Size = new System.Drawing.Size(819, 435);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView incidentListView;
        private System.Windows.Forms.ColumnHeader productCodeColumnHeader;
        private System.Windows.Forms.ColumnHeader dateOpenedColumnHeader;
        private System.Windows.Forms.ColumnHeader customerColumnHeader;
        private System.Windows.Forms.ColumnHeader technicianColumnHeader;
        private System.Windows.Forms.ColumnHeader titleColumnHeader;
    }
}
