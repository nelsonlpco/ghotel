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
        private string usuario;
        private int idusuario;
        
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

            frmLogin frml = new frmLogin();
            frml.ShowDialog();
            frml.Dispose();
            if (!frml.valida)
            {
                frml.Dispose();
                this.Close();
            }
            usuario = frml.usuario;
            idusuario = frml.id;
            lbUsuarioLogado.Text = usuario;
            frml.Dispose();
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

 

        private void quartosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQuartos frm = new frmQuartos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaQuarto frm = new frmCategoriaQuarto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatoriosHospedes frm = new frmRelatoriosHospedes();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuarios frm = new frmCadUsuarios();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void niveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNivelUsuarios frm = new frmNivelUsuarios();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
