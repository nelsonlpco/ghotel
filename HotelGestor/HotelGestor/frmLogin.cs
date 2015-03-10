using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmLogin : Form
    {
        public bool valida;
        public string usuario;
        public int id;

        public frmLogin()
        {
            InitializeComponent();
            valida = false;
        }

        private bool validausuario(string login, string senha)
        {
            uSUARIOSTableAdapter.FillBy(hotelDBDataSet.USUARIOS, login, senha);
            if (hotelDBDataSet.USUARIOS.Rows.Count > 0)
            {
                DataRow row = hotelDBDataSet.USUARIOS.Rows[0];
                usuario = (string)row["CNOME"];
                id      = (int) row["IDUSUARIO"];
                return true;
            }
            return false;
        }
       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valida = validausuario(txtLogin.Text, txtSenha.Text);
            if (!valida)
            {
                Comum.msgAlert("Login ou Senha invalidos!");
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }
            else
            {
                Close();
            }
                
        }
    }
}
