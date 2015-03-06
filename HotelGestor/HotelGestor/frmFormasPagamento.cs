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

        private DataRowView currentRow;

        private double selectValue;

        public double SelectValue { get { return selectValue; } }

        private void addeventos()
        {
            cDESCRICAOTextBox.TextChanged += onEdit;
        }

        
        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.FORMASDEPAGAMENTO.Rows.Count > 0)
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
            currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;

            fORMASDEPAGAMENTOBindingSource.EndEdit();
            fORMASDEPAGAMENTOTableAdapter.Update(hotelDBDataSet.FORMASDEPAGAMENTO);
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
                currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;
                currentRow.Delete();
                fORMASDEPAGAMENTOTableAdapter.Update(hotelDBDataSet.FORMASDEPAGAMENTO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public override void cancelar()
        {
            fORMASDEPAGAMENTOBindingSource.CancelEdit();
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
            fORMASDEPAGAMENTOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)fORMASDEPAGAMENTOBindingSource.Current;
            SelectId = (int)currentRow["NIDPAGFORM"];
            SelectDescription = (string)currentRow["CDESCRICAO"];
            this.Close();
        }

        public override void filtro()
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
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

        private void cDESCRICAOTextBox_Leave(object sender, EventArgs e)
        {
            Comum.firstUpper(sender);
        }

    }
}
