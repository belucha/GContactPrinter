namespace GContactPrinter
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.addressesTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressDataSet = new GContactPrinter.AddressDataSet();
            this.addressDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.addressesTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressesTableBindingSource
            // 
            this.addressesTableBindingSource.DataMember = "AddressesTable";
            this.addressesTableBindingSource.DataSource = this.addressDataSet;
            this.addressesTableBindingSource.Sort = "Name";
            // 
            // addressDataSet
            // 
            this.addressDataSet.DataSetName = "AddressDataSet";
            this.addressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressDataSetBindingSource
            // 
            this.addressDataSetBindingSource.DataSource = this.addressDataSet;
            this.addressDataSetBindingSource.Position = 0;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AddressDataSet_AddressesTable";
            reportDataSource1.Value = this.addressesTableBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "GContactPrinter.AddressReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(868, 746);
            this.reportViewer.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 746);
            this.Controls.Add(this.reportViewer);
            this.Name = "MainForm";
            this.Text = "GContactPrinter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressesTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource addressesTableBindingSource;
        private AddressDataSet addressDataSet;
        private System.Windows.Forms.BindingSource addressDataSetBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}

