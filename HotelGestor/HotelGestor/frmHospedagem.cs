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

        private double valorbase = 0;

        private bool fadditem = false;

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

        private DataRowView currentRow;

        private void addeventos()
        {
            
        }

        public bool isEmptyItens()
        {
            bool saida = true;
            if (hotelDBDataSet.FaturaXItens.Rows.Count > 0)
                saida = false;
            return saida;
        }

        public void buttonItensStats()
        {
            btnAddItem.Enabled = !fadditem;
            btnExcluirItem.Enabled = !fadditem && !isEmptyItens();
            btnCancelarItem.Enabled = fadditem;
        }

        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.HOSPEDAGEM.Rows.Count > 0)
                saida = false;
            return saida;
        }

      
        public void selectMod()
        {
            btnTransferir.Visible = true;
            lbStatus.Text = Comum.screenStats('t');
        }

      
        public override void salvar()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            hOSPEDAGEMBindingSource.EndEdit();
            hOSPEDAGEMTableAdapter.Update(hotelDBDataSet.HOSPEDAGEM);
            SavePrompt = false;
            IsInclude = false;
            buttonStates();
        }

        public override void excluir()
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

        public override void cancelar()
        {
            hOSPEDAGEMBindingSource.CancelEdit();
            IsInclude = false;
            SavePrompt = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public override void incluir()
        {
            lbStatus.Text = Comum.screenStats('i');
            IsInclude = true;
            SavePrompt = true;
            hOSPEDAGEMBindingSource.AddNew();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public void buscarItem()
        {
            frmItens frm = new frmItens();
            frm.selectMod();
            frm.ShowDialog();
            txtDescricaoitem.Text = frm.SelectDescription;
            nvalortotalTextBox.Text = String.Format("{0:N}", frm.SelectValue);
            valorbase = frm.SelectValue;
            currentRow = (DataRowView)faturaXItensBindingSource.Current;
            currentRow["niditem"] = frm.SelectId;
            currentRow["nvalorunit"] = valorbase;
            frm.Dispose();
            nqtditemNumericUpDown.Value = 1; 
        }

        public void atualizaItensFatura()
        {
            DataRowView faturaRow = (DataRowView)faturaBindingSource.Current;
            this.faturaXItensTableAdapter.FillByFatura(this.hotelDBDataSet.FaturaXItens, (int)faturaRow["nidfatura"]);
            currentRow = (DataRowView)faturaXItensBindingSource.Current;
            double t = (double)currentRow["TOTAL"];
            lbTotalLancamentos.Text = string.Format("0:N",t);
        }

        public void incluirItem()
        {
            faturaXItensBindingSource.AddNew();
            panelCadItens.Enabled = true;
            buscarItem();
            fadditem = true;
            lbStatus.Text = Comum.screenStats('i');
            buttonItensStats();
        }

        public void excluirItem()
        {
            lbStatus.Text = Comum.screenStats('e');
            if (Comum.msgExcluir(Comum.MSG_SEMREGISTRO))
            {
                currentRow = (DataRowView)faturaXItensBindingSource.Current;
                faturaXItensTableAdapter.Delete((int) currentRow["nidfatura"],(int) currentRow["niditem"]);
                atualizaItensFatura();
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonItensStats();
        }

        public void cancelarItem()
        {
            faturaXItensBindingSource.CancelEdit();
            lbStatus.Text = Comum.screenStats('c');
            panelCadItens.Enabled = false;
            fadditem = false;
            buttonItensStats();
        }

        public void salvarItem()
        {
            DataRowView faturaRow = (DataRowView)faturaBindingSource.Current;
            currentRow = (DataRowView)faturaXItensBindingSource.Current;
            currentRow["nidfatura"] = faturaRow["nidfatura"];
            currentRow["ddatamovim"] = DateTime.Now;
            faturaXItensBindingSource.EndEdit();
            faturaXItensTableAdapter.Update(hotelDBDataSet.FaturaXItens);
            fadditem = false;
            lbStatus.Text = Comum.screenStats('c');
            buttonItensStats();
            panelCadItens.Enabled = false;
            atualizaItensFatura();
        }


        
        public override void filtro()
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

        
        private void tbMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (SavePrompt && tbMain.SelectedIndex == 0)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                e.Cancel = true;
            }
            else if (isEmptyDataset() && !IsInclude && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tbHospedagem.SelectedIndex)
            {
                case 1 :
                case 2 :
                    currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
                    this.faturaTableAdapter.FillByHospedagem(this.hotelDBDataSet.fatura, (int)currentRow["NIDHOSPEDAGEM"]);
                    atualizaItensFatura();
                    buttonItensStats();
                    break;
            }
        }

        private void btnHospedar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void btnBuscaItem_Click(object sender, EventArgs e)
        {
            buscarItem();
        }

        private void nqtditemNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (fadditem)
            {
                currentRow = (DataRowView)faturaXItensBindingSource.Current;
                currentRow["nvalortotal"] = valorbase * (double)nqtditemNumericUpDown.Value;
                nvalortotalTextBox.Text = string.Format("{0:N}", valorbase * (double)nqtditemNumericUpDown.Value);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            incluirItem();
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            excluirItem();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            cancelarItem();
        }

        private void btnRegistraConsumo_Click(object sender, EventArgs e)
        {
            salvarItem();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

       

    }
}
