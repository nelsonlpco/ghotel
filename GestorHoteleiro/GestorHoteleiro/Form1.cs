﻿using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void hóspedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHospedes frm = new frmHospedes();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
