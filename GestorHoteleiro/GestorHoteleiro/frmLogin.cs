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
    public partial class frmLogin : Form
    {
        private bool fLogado;

        public frmLogin()
        {
            InitializeComponent();
            fLogado = false;
        }

        public bool UsuarioLogado { get { return fLogado; } }
    }
}
