namespace HotelGestor.relatorios.fatura
{
    partial class frmViewFatura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDbsRelatorios = new HotelGestor.HotelDbsRelatorios();
            this.hOSPEDAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hOTELTableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.HOTELTableAdapter();
            this.hOSPEDAGEMTableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.HOSPEDAGEMTableAdapter();
            this.iTENSFATURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTENSFATURATableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.ITENSFATURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSFATURABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTELBindingSource
            // 
            this.hOTELBindingSource.DataMember = "HOTEL";
            this.hOTELBindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // hotelDbsRelatorios
            // 
            this.hotelDbsRelatorios.DataSetName = "HotelDbsRelatorios";
            this.hotelDbsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOSPEDAGEMBindingSource
            // 
            this.hOSPEDAGEMBindingSource.DataMember = "HOSPEDAGEM";
            this.hOSPEDAGEMBindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHotel";
            reportDataSource1.Value = this.hOTELBindingSource;
            reportDataSource2.Name = "dsHOSPEDAGEM";
            reportDataSource2.Value = this.hOSPEDAGEMBindingSource;
            reportDataSource3.Name = "dsConsumo";
            reportDataSource3.Value = this.iTENSFATURABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.fatura.fatura1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // hOTELTableAdapter
            // 
            this.hOTELTableAdapter.ClearBeforeFill = true;
            // 
            // hOSPEDAGEMTableAdapter
            // 
            this.hOSPEDAGEMTableAdapter.ClearBeforeFill = true;
            // 
            // iTENSFATURABindingSource
            // 
            this.iTENSFATURABindingSource.DataMember = "ITENSFATURA";
            this.iTENSFATURABindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // iTENSFATURATableAdapter
            // 
            this.iTENSFATURATableAdapter.ClearBeforeFill = true;
            // 
            // frmViewFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmViewFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.frmViewFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTENSFATURABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDbsRelatorios hotelDbsRelatorios;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private HotelDbsRelatoriosTableAdapters.HOTELTableAdapter hOTELTableAdapter;
        private System.Windows.Forms.BindingSource hOSPEDAGEMBindingSource;
        private HotelDbsRelatoriosTableAdapters.HOSPEDAGEMTableAdapter hOSPEDAGEMTableAdapter;
        private System.Windows.Forms.BindingSource iTENSFATURABindingSource;
        private HotelDbsRelatoriosTableAdapters.ITENSFATURATableAdapter iTENSFATURATableAdapter;
        
    }
}