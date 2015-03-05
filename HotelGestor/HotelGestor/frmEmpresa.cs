using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmEmpresa : HotelGestor.template.frmCadastroSimples
    {
        public frmEmpresa()
        {
            InitializeComponent();
            addeventos();
        }

        private bool fsaveprompt;
        
        private DataRowView currentRow;

        private void addeventos()
        {
            cNOMETextBox.TextChanged += onEdit;
            cCNPJMaskedTextBox.TextChanged += onEdit;
            cINSCTextBox.TextChanged += onEdit;
            cFONEMaskedTextBox.TextChanged += onEdit;
            cFONE2MaskedTextBox.TextChanged += onEdit;
            cFONE3MaskedTextBox.TextChanged += onEdit;
            cEMAILSTextBox.TextChanged += onEdit;
            cCIDADETextBox.TextChanged += onEdit;
            cUFTextBox.TextChanged += onEdit;
            cENDERECOTextBox.TextChanged += onEdit;
            cBAIRROTextBox.TextChanged += onEdit;
            cCEPMaskedTextBox.TextChanged += onEdit;
        }

        private void onEdit(object sender, EventArgs e)
        {
            if (!fsaveprompt)
            {
                fsaveprompt = true;
                buttonStates();
                lbStatus.Text = Comum.screenStats('e');
            }
        }

        public bool isEmptyDataSet()
        {
            bool saida = true;
            if (hotelDBDataSet.HOTEL.Rows.Count > 0)
                saida = false;
            return saida;
        }

        private void imagemDoArquivo()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                lOGOPictureBox.ImageLocation = file.FileName;
            }
        }

        

        public void buttonStates()
        {
            btnGravar.Enabled = fsaveprompt;
            btnCancelar.Enabled = fsaveprompt;
            btnSair.Enabled = !fsaveprompt;
        }

        public void selectMod()
        {
            lbStatus.Text = Comum.screenStats('t');
        }

        public bool sair()
        {
            bool saida = true;
            if (fsaveprompt)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                saida = false;
            }
            return saida;
        }

        public void salvar()
        {
            currentRow = (DataRowView)hOTELBindingSource.Current;
            
            hOTELBindingSource.EndEdit();
            hOTELTableAdapter.Update(hotelDBDataSet.HOTEL);
            fsaveprompt = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public void excluir()
        {
            lbStatus.Text = Comum.screenStats('d');
            if (Comum.msgExcluir(Comum.MSG_EXCLUIR))
            {
                currentRow = (DataRowView)hOTELBindingSource.Current;
                currentRow.Delete();
                hOTELTableAdapter.Update(hotelDBDataSet.HOTEL);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public void cancelar()
        {
            hOTELBindingSource.CancelEdit();
            fsaveprompt = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public void incluir()
        {
            lbStatus.Text = Comum.screenStats('i');
            fsaveprompt = true;
            hOTELBindingSource.AddNew();
            cNOMETextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.
            this.hOTELTableAdapter.Fill(this.hotelDBDataSet.HOTEL);
            if (isEmptyDataSet())
            {
                hOTELBindingSource.AddNew();
                fsaveprompt = true;
            }
            buttonStates();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            onEdit(sender, e);
            imagemDoArquivo();
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            string[] endereco = Comum.buscacep(cCEPMaskedTextBox.Text);
            currentRow = (DataRowView)hOTELBindingSource.Current;
            currentRow["CCIDADE"] = endereco[2];
            currentRow["CUF"] = endereco[3];
            currentRow["CBAIRRO"] = endereco[1];
            currentRow["CENDERECO"] = endereco[0];
            cCIDADETextBox.Text = endereco[2];
            cUFTextBox.Text = endereco[3];
            cBAIRROTextBox.Text = endereco[1];
            cENDERECOTextBox.Text = endereco[0];
        }
    }
}
