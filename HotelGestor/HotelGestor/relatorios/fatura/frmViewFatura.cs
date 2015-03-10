using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor.relatorios.fatura
{
    public partial class frmViewFatura : Form
    {
        public frmViewFatura()
        {
            InitializeComponent();
        }

        private void frmViewFatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDbsRelatorios.HOTEL' table. You can move, or remove it, as needed.
            this.hOTELTableAdapter.Fill(this.hotelDbsRelatorios.HOTEL);

            
        }

        public void frmCarregaFatura(int id)
        {
            this.hOSPEDAGEMTableAdapter.Fill(hotelDbsRelatorios.HOSPEDAGEM, id);
            DataRowView row = (DataRowView)hOSPEDAGEMBindingSource.Current;

            this.iTENSFATURATableAdapter.Fill(hotelDbsRelatorios.ITENSFATURA, (int)row["nidfatura"]);

            this.reportViewer1.RefreshReport();
        }
    }
}
