using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmHospedagem : HotelGestor.template.frmMainCadastro
    {
        public frmHospedagem()
        {
            InitializeComponent();
        }

        private void selecionarCliente()
        {
            frmHospedes frm = new frmHospedes();
            frm.selectMod();
            frm.ShowDialog();
            nIDCLIENTETextBox.Text = string.Format("{0}",frm.SelectId);
            txtNomeCliente.Text = frm.SelectDescription;
            frm.Dispose();
        }

        private void selecionarQuarto()
        {
            frmQuartos frm = new frmQuartos();
            frm.selectMod();
            frm.ShowDialog();
            nIDQUARTOTextBox.Text = string.Format("{0}", frm.SelectId);
            txtDescQuarto.Text = frm.SelectDescription;
            frm.Dispose();
        }

        private void frmHospedagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOSPEDAGEM' table. You can move, or remove it, as needed.
            this.hOSPEDAGEMTableAdapter.Fill(this.hotelDBDataSet.HOSPEDAGEM);

        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            selecionarCliente();
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {
            selecionarQuarto();
        }
    }
}
