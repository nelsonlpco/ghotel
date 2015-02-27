using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospedes frm = new frmHospedes();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuartos frm = new frmQuartos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void itensParaConsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItens frm = new frmItens();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.ShowDialog();
            frm.Dispose();
            this.hOTELTableAdapter.Fill(this.hotelDBDataSet.HOTEL);
            DataRowView row = (DataRowView)hOTELBindingSource.Current;
            if (row != null)
            {
                Comum.EMPRESA = (string)row["CNOME"];
            }
            this.Text = Comum.EMPRESA;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.
            this.hOTELTableAdapter.Fill(this.hotelDBDataSet.HOTEL);
            DataRowView row = (DataRowView)hOTELBindingSource.Current;
            if (row != null)
            {
                Comum.EMPRESA = (string)row["CNOME"];
            }

            this.Text = Comum.EMPRESA;

        }

        private void formasDePagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormasPagamento frm = new frmFormasPagamento();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void hospedagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospedagem frm = new frmHospedagem();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
