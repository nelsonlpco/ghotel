using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmFormasPagamento : HotelGestor.template.frmMainCadastro
    {
        public frmFormasPagamento()
        {
            InitializeComponent();
            addeventos();
        }

        private bool fsaveprompt;
        private bool fincluir;

        private DataRowView currentRow;

        private int selectId;
        private string selectDescription;
        private double selectValue;

        public int SelectId { get { return selectId; } }
        public string SelectDescription { get { return selectDescription; } }
        public double SelectValue { get { return selectValue; } }

        private void addeventos()
        {
            cDESCRICAOTextBox.TextChanged += onEdit;
        }

        private void onEdit(object sender, EventArgs e)
        {
            if (!fsaveprompt && tbMain.SelectedIndex == 1)
            {
                fsaveprompt = true;
                buttonStates();
                lbStatus.Text = Comum.screenStats('e');
            }
        }

        public bool isEmptyDataSet()
        {
            bool saida = true;
            if (hotelDBDataSet.FORMASDEPAGAMENTO.Rows.Count > 0)
                saida = false;
            return saida;
        }

        public void buttonStates()
        {
            btnTransferir.Enabled = !fsaveprompt && !isEmptyDataSet();
            btnIncluir.Enabled = !fsaveprompt;
            btnGravar.Enabled = fsaveprompt;
            btnCancelar.Enabled = fsaveprompt;
            btnExcluir.Enabled = !fsaveprompt && !isEmptyDataSet();
            btnSair.Enabled = !fsaveprompt;
        }

        public void selectMod()
        {
            btnTransferir.Visible = true;
            lbStatus.Text = Comum.screenStats('t');
        }

        public bool sair()
        {
            bool saida = true;
            if (fincluir || fsaveprompt)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                saida = false;
            }
            return saida;
        }

        public void salvar()
        {
            currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;

            fORMASDEPAGAMENTOBindingSource.EndEdit();
            fORMASDEPAGAMENTOTableAdapter.Update(hotelDBDataSet.FORMASDEPAGAMENTO);
            fsaveprompt = false;
            fincluir = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public void excluir()
        {
            lbStatus.Text = Comum.screenStats('d');
            if (Comum.msgExcluir(Comum.MSG_EXCLUIR))
            {
                currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;
                currentRow.Delete();
                fORMASDEPAGAMENTOTableAdapter.Update(hotelDBDataSet.FORMASDEPAGAMENTO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public void cancelar()
        {
            fORMASDEPAGAMENTOBindingSource.CancelEdit();
            fincluir = false;
            fsaveprompt = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public void incluir()
        {
            lbStatus.Text = Comum.screenStats('i');
            fincluir = true;
            fsaveprompt = true;
            fORMASDEPAGAMENTOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public void selecionar()
        {
            currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;
            selectId = (int)currentRow["NIDPAGFORM"];
            selectDescription = (string)currentRow["CDESCRICAO"];
            this.Close();
        }

        public void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);

            fORMASDEPAGAMENTOBindingSource.Filter = filtro;

        }


        private void frmFormasPagamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.FORMASDEPAGAMENTO' table. You can move, or remove it, as needed.
            this.fORMASDEPAGAMENTOTableAdapter.Fill(this.hotelDBDataSet.FORMASDEPAGAMENTO);
            buttonStates();
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            selecionar();
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void tbMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (fsaveprompt && tbMain.SelectedIndex == 0)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                e.Cancel = true;
            }
            else if (isEmptyDataSet() && !fincluir && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
            }
        }

        private void frmFormasPagamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !sair();
        }
    }
}
