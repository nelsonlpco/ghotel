using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor.template
{
    public partial class frmMainCadastro : Form, IDao
    {

        private bool saveprompt;
        private bool isInclude;

        public frmMainCadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int selectId;
        private string selectDescription;

        public int SelectId { get { return selectId; } 
                               set{selectId = value;} }
        public string SelectDescription { get { return selectDescription; } 
                                          set {this.selectDescription = value;} }


        public void onEdit(object sender, EventArgs e)
        {
            if (!isInclude && tbMain.SelectedIndex == 1)
            {
                saveprompt = true;
                buttonStates();
                lbStatus.Text = Comum.screenStats('e');
            }
        }

        public virtual void salvar()
        {
            throw new NotImplementedException();
        }

        public virtual void incluir()
        {
            throw new NotImplementedException();
        }

        public virtual void excluir()
        {
            throw new NotImplementedException();
        }

        public virtual void cancelar()
        {
            throw new NotImplementedException();
        }

        public virtual void selecionar()
        {
            throw new NotImplementedException();
        }

        public virtual void filtro()
        {
            throw new NotImplementedException();
        }

        

        public bool Sair()
        {
            bool saida = true;
            if (isInclude || saveprompt)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                saida = false;
            }
            return saida;
        }



        public bool SavePrompt
        {
            get
            {
                return this.saveprompt;
            }
            set
            {
                this.saveprompt = value;
            }
        }

        public bool IsInclude
        {
            get
            {
                return this.isInclude;
            }
            set
            {
                this.isInclude = value;
            }
        }

        public virtual bool isEmptyDataset()
        {
            throw new NotImplementedException();
        }

      
        public virtual void buttonStates()
        {
            btnTransferir.Enabled = !saveprompt && !isEmptyDataset();
            btnIncluir.Enabled = !saveprompt;
            btnGravar.Enabled = saveprompt;
            btnCancelar.Enabled = saveprompt;
            btnExcluir.Enabled = !saveprompt && !isEmptyDataset();
            btnSair.Enabled = !saveprompt;
            btnRelatorio.Enabled = !isEmptyDataset();
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

        

        private void frmMainCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Sair();
        }

        
       
    }
}
