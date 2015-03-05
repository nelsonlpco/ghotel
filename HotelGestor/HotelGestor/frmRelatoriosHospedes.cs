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

            cbRelatorios.SelectedIndex = 0;

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (cbRelatorios.SelectedIndex)
            {
                case 0: this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes.listadehospedes.rdlc";
                    break;
                case 1: this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes.fichaHospede.rdlc";
                    break;
            }
            
            this.reportViewer1.RefreshReport();
        }
    }
}
