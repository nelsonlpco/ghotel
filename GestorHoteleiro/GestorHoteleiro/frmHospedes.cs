using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestorHoteleiro
{
    public partial class frmHospedes : Form
    {
        private string descricao;
        private int id;
        private bool savePrompt;

        private DataRowView current;

        public string Descricao { get { return descricao; } }
        public int Id { get { return id; } }

        public frmHospedes()
        {
            InitializeComponent();
            savePrompt = false;
            statusTela('c');
        }

        private bool fsemregistros()
        {
            bool saida = true;
            if (dgvConsulta.RowCount > 0)
                saida = false;
            return saida;
        }

        private void statusTela(char e)
        {
            switch (e)
            {
                case 'i' :
                    lbStatus.Text = "Inclusão de registro";
                    break;
                case 'c':
                    lbStatus.Text = "Consulta de registro";
                    break;
                case 'e':
                    lbStatus.Text = "Exclusão de registro";
                    break;
                case 'a':
                    lbStatus.Text = "Edição de registro";
                    break;
                case 's':
                    lbStatus.Text = "Seleção de registro";
                    break;
            }
        }

        public void modoselecao()
        {
            btnSelecionar.Visible = true;
            this.Text = "Seleção de Hóspede";
            
        }

        private void statusButtons()
        {
            btnSelecionar.Enabled = !savePrompt && !fsemregistros();
            btnExcluir.Enabled    = !savePrompt && !fsemregistros();
            btnIncluir.Enabled    = !savePrompt;
            BtnSair.Enabled       = !savePrompt;
            btnGravar.Enabled     = savePrompt;
            btnCancelar.Enabled   = savePrompt;
        }

        private void telaStatus(char acao)
        {
            switch (acao)
            {
                case 'b':
                    lbStatus.Text = "Pesquisa registros";
                    break;
                case 'i':
                    lbStatus.Text = "Inclusão de registro";
                    break;
                case 'u':
                    lbStatus.Text = "Edição de registro";
                    break;
                case 'd':
                    lbStatus.Text = "Exclusão de registro";
                    break;
            }
        }

        private void salvar()
        {
            savePrompt = false;
            this.cLIENTEBindingSource.EndEdit();
            this.cLIENTETableAdapter.Update(hotelDBDataSet.CLIENTE);
            statusButtons();
            statusTela('c');
            tbcPrincipal.SelectedIndex = 0;
        }

        private void incluir()
        {
            savePrompt = true;
            statusButtons();
            telaStatus('i');
            tbcPrincipal.SelectedIndex = 1;
            this.cLIENTEBindingSource.AddNew();
        }

        private void cancelar()
        {
            cLIENTEBindingSource.CancelEdit();
            savePrompt = false;
            statusButtons();
            telaStatus('c');
            tbcPrincipal.SelectedIndex = 0;
        }

        private void excluir()
        {
            telaStatus('e');
            if (MessageBox.Show(Comum.MSG_EXCLUSAO, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                telaStatus('e');
                current = (DataRowView)cLIENTEBindingSource.Current;
                current.Delete();
                cLIENTETableAdapter.Update(hotelDBDataSet.CLIENTE);
                savePrompt = false;
                telaStatus('c');
                statusButtons();
            }
            telaStatus('c');
        }

        private void selecionar()
        {
            current = (DataRowView)cLIENTEBindingSource.Current;
            this.id = (int)current["NIDCLIENTE"];
            this.descricao = (string)current["CNOMECLIENTE"];
            this.Close();
        }


        private void frmHospedes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);
            statusButtons();
        }

        private void cLIENTEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void tbcPrincipal_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(fsemregistros() && !savePrompt){
                MessageBox.Show(Comum.MSG_SEMREGISTRO, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
                
        }

      
    }
}
