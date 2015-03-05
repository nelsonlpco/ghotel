using HotelGestor.relatorios.hospedes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmRelatoriosHospedes : HotelGestor.template.frmBaseRelatorios
    {
        public frmRelatoriosHospedes()
        {
            InitializeComponent();
        }

        private void frmRelatoriosHospedes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.
            this.HOTELTableAdapter.Fill(this.hotelDBDataSet.HOTEL);
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes.listadehospedes.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
