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
            if (hotelDBDataSet.HOSPEDAGEM.Rows.Count > 0)
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
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;

            hOSPEDAGEMBindingSource.EndEdit();
            //hOSPEDAGEMTableAdapter.Update(hotelDBDataSet.HOSPEDAGEM);
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
                currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
                currentRow.Delete();
                //hOSPEDAGEMTableAdapter.Update(hotelDBDataSet.ITEMCONSUMO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public void cancelar()
        {
            hOSPEDAGEMBindingSource.CancelEdit();
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
            hOSPEDAGEMBindingSource.AddNew();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        
        public void filtro()
        {
            string filtro = "";

            hOSPEDAGEMBindingSource.Filter = filtro;

        }

        private void frmHospedagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.FORMASDEPAGAMENTO' table. You can move, or remove it, as needed.
            this.fORMASDEPAGAMENTOTableAdapter.Fill(this.hotelDBDataSet.FORMASDEPAGAMENTO);
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

        private void nDIARIASNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateTime tmp = dDATAINDateTimePicker.Value;
            dDATAOUTDateTimePicker.Value = tmp.AddDays((double)this.nDIARIASNumericUpDown.Value);
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

        private void frmHospedagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !sair();
        }

        

    }
}
