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

        private DataRowView currentRow;

        private void addeventos()
        {
            
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

        
        public override void filtro()
        {
            string filtro = "";

            hOSPEDAGEMBindingSource.Filter = filtro;

        }

        private void frmHospedagem_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'hotelDBDataSet.FaturaXItens' table. You can move, or remove it, as needed.
            this.faturaXItensTableAdapter.Fill(this.hotelDBDataSet.FaturaXItens);
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
            if (tbHospedagem.SelectedIndex == 2)
            {
                currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
                this.faturaTableAdapter.FillByHospedagem(this.hotelDBDataSet.fatura, (int)currentRow["NIDHOSPEDAGEM"]);
            }
        }

        private void btnHospedar_Click(object sender, EventArgs e)
        {
            salvar();
        }

       

    }
}
