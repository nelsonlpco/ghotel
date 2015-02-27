using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmItens : HotelGestor.template.frmMainCadastro
    {
        public frmItens()
        {
            InitializeComponent();
            addeventos();
        }

        private void frmItens_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.ITEMCONSUMO' table. You can move, or remove it, as needed.
            this.iTEMCONSUMOTableAdapter.Fill(this.hotelDBDataSet.ITEMCONSUMO);
            buttonStates();
            
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
            nVALORITEMNumericUpDown.ValueChanged += onEdit;
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
            if (hotelDBDataSet.ITEMCONSUMO.Rows.Count > 0)
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
            currentRow = (DataRowView)iTEMCONSUMOBindingSource.Current;
            
            iTEMCONSUMOBindingSource.EndEdit();
            iTEMCONSUMOTableAdapter.Update(hotelDBDataSet.ITEMCONSUMO);
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
                currentRow = (DataRowView)iTEMCONSUMOBindingSource.Current;
                currentRow.Delete();
                iTEMCONSUMOTableAdapter.Update(hotelDBDataSet.ITEMCONSUMO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public void cancelar()
        {
            iTEMCONSUMOBindingSource.CancelEdit();
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
            iTEMCONSUMOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public void selecionar()
        {
            currentRow = (DataRowView)iTEMCONSUMOBindingSource.Current;
            selectId = (int)currentRow["NIDITEMCONSUMO"];
            selectDescription = (string)currentRow["CDESCRICAO"];
            selectValue = (double)currentRow["NVALORITEM"];
            this.Close();
        }

        public void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);
            
            iTEMCONSUMOBindingSource.Filter = filtro;

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

        private void frmItens_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !sair();
        }

        private void dgvItens_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        

    }
}
