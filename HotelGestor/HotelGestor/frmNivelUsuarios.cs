using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmNivelUsuarios : HotelGestor.template.frmMainCadastro
    {
        public frmNivelUsuarios()
        {
            InitializeComponent();
            addeventos();
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
            cdescricaoTextBox.TextChanged += onEdit;
            nnivelTextBox.TextChanged += onEdit;
        }


        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.ATORES.Rows.Count > 0)
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
            currentRow = (DataRowView)aTORESBindingSource.Current;

            aTORESBindingSource.EndEdit();
            aTORESTableAdapter.Update(hotelDBDataSet.ATORES);
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
                currentRow = (DataRowView)aTORESBindingSource.Current;
                try
                {
                    currentRow.Delete();
                    aTORESTableAdapter.Update(hotelDBDataSet.ATORES);
                }
                catch (Exception ex)
                {
                    Comum.msgAlert("Este item não pode ser excluido, pois faz parte de alguma movimentação!");
                    aTORESTableAdapter.Fill(hotelDBDataSet.ATORES);
                }

            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public override void cancelar()
        {
            aTORESBindingSource.CancelEdit();
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
            aTORESBindingSource.AddNew();
            cdescricaoTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)aTORESBindingSource.Current;
            SelectId = (int)currentRow["idator"];
            SelectDescription = (string)currentRow["CDESCRICAO"];

            SelectValue = Comum.strToDouble(currentRow["nnivel"].ToString());
            this.Close();
        }

        public override void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);

            aTORESBindingSource.Filter = filtro;

        }


        private void frmNivelUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.ATORES' table. You can move, or remove it, as needed.
            this.aTORESTableAdapter.Fill(this.hotelDBDataSet.ATORES);

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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void cdescricaoTextBox_Leave(object sender, EventArgs e)
        {
            Comum.firstUpper(sender);
        }

      
    }
}
