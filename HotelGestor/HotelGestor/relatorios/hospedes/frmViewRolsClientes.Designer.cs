namespace HotelGestor.relatorios.hospedes
{
    partial class frmViewRolsClientes
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDbsRelatorios = new HotelGestor.HotelDbsRelatorios();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.CLIENTETableAdapter();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELTableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.HOTELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHotel";
            reportDataSource1.Value = this.hOTELBindingSource;
            reportDataSource2.Name = "dsHospede";
            reportDataSource2.Value = this.cLIENTEBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes.fichaHospede.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(659, 469);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDbsRelatorios
            // 
            this.hotelDbsRelatorios.DataSetName = "HotelDbsRelatorios";
            this.hotelDbsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // hOTELBindingSource
            // 
            this.hOTELBindingSource.DataMember = "HOTEL";
            this.hOTELBindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // hOTELTableAdapter
            // 
            this.hOTELTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewRolsClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 469);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmViewRolsClientes";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.frmViewRolsClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDbsRelatorios hotelDbsRelatorios;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDbsRelatoriosTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private HotelDbsRelatoriosTableAdapters.HOTELTableAdapter hOTELTableAdapter;
    }
}