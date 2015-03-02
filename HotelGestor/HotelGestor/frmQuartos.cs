using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmQuartos : HotelGestor.template.frmMainCadastro
    {
        public frmQuartos()
        {
            InitializeComponent();
            addeventos();
            lbStatus.Text = Comum.screenStats('c');
        }
      

        private bool fsaveprompt;
        private bool fincluir;

        private DataRowView currentRow;

        private int selectId;
        private string selectDescription;

        public int SelectId { get { return selectId; } }
        public string SelectDescription { get { return selectDescription; } }

        private void addeventos()
        {
            cDESCRICAOTextBox.TextChanged += onEdit;
            nANDARNumericUpDown.ValueChanged += onEdit;
            nNUMERONumericUpDown.ValueChanged += onEdit;
            nMAXPESSOASNumericUpDown.ValueChanged += onEdit;
            //nVALORBASENumericUpDown.ValueChanged += onEdit;
            nCATEGORIAComboBox.SelectedValueChanged += onEdit;
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
            if (hotelDBDataSet.QUARTO.Rows.Count > 0)
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
            btnCancelar.Visible = false;
            btnIncluir.Visible = false;
            btnGravar.Visible = false;
            btnExcluir.Visible = false;
            cbFiltroStatus.Enabled = false;
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
            currentRow = (DataRowView)qUARTOBindingSource.Current;
            currentRow["NVALORBASE"] = Double.Parse(nVALORBASETextBox.Text);
            if (string.IsNullOrEmpty(currentRow["CESTATUS"].ToString()))
            {
                currentRow["CESTATUS"] = "L";
                
            }
            currentRow["NCATEGORIA"] = 1;

            qUARTOBindingSource.EndEdit();
            qUARTOTableAdapter.Update(hotelDBDataSet.QUARTO);
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
                currentRow = (DataRowView)qUARTOBindingSource.Current;
                currentRow.Delete();
                qUARTOTableAdapter.Update(hotelDBDataSet.QUARTO);
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public void cancelar()
        {
            qUARTOBindingSource.CancelEdit();
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
            qUARTOBindingSource.AddNew();
            cDESCRICAOTextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public void selecionar()
        {
            currentRow = (DataRowView)qUARTOBindingSource.Current;
            selectId = (int)currentRow["NIDQUARTO"];
            selectDescription = string.Format("{0} - Andar :{1} - Numero: {2} ", currentRow["CDESCRICAO"], currentRow["NANDAR"], currentRow["NNUMERO"]);
            this.Close();
        } 

        public void filtro()
        {
            string filtro = "";
            if (!txtFiltroDiariaIni.Text.Equals("0,00"))
                filtro += String.Format(" NVALORBASE >=  {0} ", double.Parse(txtFiltroDiariaIni.Text));
            if (!string.IsNullOrEmpty(filtro) && !txtFiltroDiariaFim.Text.Equals("0,00"))
                filtro += " AND ";
            if (!txtFiltroDiariaFim.Text.Equals("0,00"))
                filtro += String.Format(" NVALORBASE <=  {0} ", Double.Parse(txtFiltroDiariaFim.Text));
            if (!string.IsNullOrEmpty(filtro) && cbFiltroStatus.SelectedIndex > 0)
                filtro += " AND ";
            switch (cbFiltroStatus.SelectedIndex)
            {
                case 0: filtro += ""; break;
                case 1: filtro += " CESTATUS = 'L'"; break;
                case 2: filtro += " CESTATUS = 'O'"; break;
                case 3: filtro += " CESTATUS = 'R'"; break;
            }
            if (!string.IsNullOrEmpty(filtro) && npFiltroAndar.Value > 0)
                filtro += " AND ";
            if (npFiltroAndar.Value > 0)
                filtro += " NANDAR >=  " + npFiltroAndar.Value;
            if (!string.IsNullOrEmpty(filtro) && npFiltroPessoa.Value > 0)
                filtro += " AND ";
            if (npFiltroPessoa.Value > 0)
                filtro += " NMAXPESSOAS >=  " + npFiltroPessoa.Value;
            if (!string.IsNullOrEmpty(filtro) && cbCategoria.SelectedIndex >= 0)
                filtro += " AND ";
            if (cbCategoria.SelectedIndex > 0)
            filtro += string.Format(" NCATEGORIA = {0} ",cbCategoria.SelectedIndex);

            qUARTOBindingSource.Filter = filtro;
               
        }

        private void frmQuartos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CATEGORIAQUARTO' table. You can move, or remove it, as needed.
            this.cATEGORIAQUARTOTableAdapter.FillToSelect(this.hotelDBDataSet.CATEGORIAQUARTO);
            // TODO: This line of code loads data into the 'hotelDBDataSet.QUARTO' table. You can move, or remove it, as needed.
            this.qUARTOTableAdapter.FillToView(this.hotelDBDataSet.QUARTO);
            buttonStates();
            if(btnTransferir.Visible)
                cbFiltroStatus.SelectedIndex = 1;
            else
                cbFiltroStatus.SelectedIndex = 0;

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
                return;
            }
            else if (isEmptyDataSet() && !fincluir && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
                return;
            }
            if(tbMain.SelectedIndex == 0)
                this.cATEGORIAQUARTOTableAdapter.FillToSelect(this.hotelDBDataSet.CATEGORIAQUARTO);
            else
                this.cATEGORIAQUARTOTableAdapter.Fill(this.hotelDBDataSet.CATEGORIAQUARTO);
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void frmQuartos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !sair();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            filtro();
        }

        private void fillDescricaoToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.qUARTOTableAdapter.Fill(this.hotelDBDataSet.QUARTO);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Comum.dinamicMasck(sender);
        }

        private void nVALORBASETextBox_TextChanged(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

        private void nVALORBASETextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private void txtFiltroDiariaIni_TextChanged(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

        private void txtFiltroDiariaFim_TextChanged(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

        private void txtFiltroDiariaIni_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private void txtFiltroDiariaFim_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

       

      

    }
}
