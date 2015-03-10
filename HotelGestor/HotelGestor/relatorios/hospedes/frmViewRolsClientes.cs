using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor.relatorios.hospedes
{
    public partial class frmViewRolsClientes : Form
    {
        public frmViewRolsClientes()
        {
            InitializeComponent();
        }

        private void frmViewRolsClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDbsRelatorios.HOTEL' table. You can move, or remove it, as needed.
          //  this.hOTELTableAdapter.Fill(this.hotelDbsRelatorios.HOTEL);
            // TODO: This line of code loads data into the 'hotelDbsRelatorios.CLIENTE' table. You can move, or remove it, as needed.
          //  this.cLIENTETableAdapter.Fill(this.hotelDbsRelatorios.CLIENTE);

          //  this.reportViewer1.RefreshReport();
        }

        
        public void setReport(string report)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes." + report;

            this.reportViewer1.RefreshReport();
       
        }
    }
}
