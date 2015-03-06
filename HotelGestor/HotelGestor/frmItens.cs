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


        private DataRowView currentRow;

        private double selectValue;

        public double SelectValue
        {
            get { return selectValue; }
            set { selectValue = value; }
        }

        private void addeventos()
        {
            cDESCRICAOTextBox.TextChanged += onEdit;
            nVALORITEMTextBox.TextChanged += onEdit;
        }


        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.ITEMCONSUMO.Rows.Count > 0)
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
            currentRow = (DataRowView)iTEMCONSUMOBindingSource.Current;
            
            iTEMCONSUMOBindingSource.EndEdit();
            iTEMCONSUMOTableAdapter.Update(hotelDBDataSet.ITEMCONSUMO);
            SavePrompt = false;
            IsInclude = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public override void excluir()
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

        public override void cancelar()
        {
            iTEMCONSUMOBindingSource.CancelEdit();
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
            iTEMCONSUMOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)iTEMCONSUMOBindingSource.Current;
            SelectId = (int)currentRow["NIDITEMCONSUMO"];
            SelectDescription = (string)currentRow["CDESCRICAO"];
            
            SelectValue = Comum.strToDouble(currentRow["NVALORITEM"].ToString());
            this.Close();
        }

        public override void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);
            
            iTEMCONSUMOBindingSource.Filter = filtro;

        }


        private void dgvItens_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void tbMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.SavePrompt && tbMain.SelectedIndex == 0)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                e.Cancel = true;
                return;
            }
            else if (isEmptyDataset() && !IsInclude && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
                return;
            }
        }

        private void nVALORITEMTextBox_TextChanged(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

    }
}
