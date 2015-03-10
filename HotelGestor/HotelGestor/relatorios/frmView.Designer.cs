namespace HotelGestor.relatorios.hospedes
{
    partial class frmView
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
            this.rpv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDbsRelatorios = new HotelGestor.HotelDbsRelatorios();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELTableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.HOTELTableAdapter();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new HotelGestor.HotelDbsRelatoriosTableAdapters.CLIENTETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpv
            // 
            this.rpv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsHotel";
            reportDataSource1.Value = this.hOTELBindingSource;
            reportDataSource2.Name = "dsHospede";
            reportDataSource2.Value = this.cLIENTEBindingSource;
            this.rpv.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv.LocalReport.DataSources.Add(reportDataSource2);
            this.rpv.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes.fichaHospede.rdlc";
            this.rpv.Location = new System.Drawing.Point(0, 0);
            this.rpv.Name = "rpv";
            this.rpv.Size = new System.Drawing.Size(784, 562);
            this.rpv.TabIndex = 0;
            // 
            // hotelDbsRelatorios
            // 
            this.hotelDbsRelatorios.DataSetName = "HotelDbsRelatorios";
            this.hotelDbsRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.hotelDbsRelatorios;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.rpv);
            this.Name = "frmView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmView";
            this.Load += new System.EventHandler(this.frmView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDbsRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv;
        private HotelDbsRelatorios hotelDbsRelatorios;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private HotelDbsRelatoriosTableAdapters.HOTELTableAdapter hOTELTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDbsRelatoriosTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
    }
}