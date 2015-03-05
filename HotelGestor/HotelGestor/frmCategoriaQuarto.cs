using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmCategoriaQuarto : HotelGestor.template.frmMainCadastro
    {
        public frmCategoriaQuarto()
        {
            InitializeComponent();
            addeventos();
        }


        private DataRowView currentRow;

        private void addeventos()
        {
            cDESCRICAOTextBox.TextChanged += onEdit;
        }

       

        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.CATEGORIAQUARTO.Rows.Count > 0)
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
            currentRow = (DataRowView)cATEGORIAQUARTOBindingSource.Current;

            cATEGORIAQUARTOBindingSource.EndEdit();
            cATEGORIAQUARTOTableAdapter.Update(hotelDBDataSet.CATEGORIAQUARTO);
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
                currentRow = (DataRowView)cATEGORIAQUARTOBindingSource.Current;
                currentRow.Delete();
                cATEGORIAQUARTOTableAdapter.Update(hotelDBDataSet.CATEGORIAQUARTO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public override void cancelar()
        {
            cATEGORIAQUARTOBindingSource.CancelEdit();
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
            cATEGORIAQUARTOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)cATEGORIAQUARTOBindingSource.Current;
            SelectId = (int)currentRow["idcategoria"];
            SelectDescription = (string)currentRow["CDESCRICAO"];
            this.Close();
        }

        public void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);

            cATEGORIAQUARTOBindingSource.Filter = filtro;

        }

        private void frmCategoriaQuarto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CATEGORIAQUARTO' table. You can move, or remove it, as needed.
            this.cATEGORIAQUARTOTableAdapter.Fill(this.hotelDBDataSet.CATEGORIAQUARTO);
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

    }
}
