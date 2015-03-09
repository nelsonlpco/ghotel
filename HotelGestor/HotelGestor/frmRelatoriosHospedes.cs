﻿using HotelGestor.relatorios.hospedes;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmRelatoriosHospedes : HotelGestor.template.frmBaseRelatorios
    {
        public frmRelatoriosHospedes()
        {
            InitializeComponent();
        }

        private void frmRelatoriosHospedes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.
            this.HOTELTableAdapter.Fill(this.hotelDBDataSet.HOTEL);
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);

            cbRelatorios.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmView frm = new frmView();
            List<ReportDataSource> lista = new List<ReportDataSource>();
            switch (cbRelatorios.SelectedIndex)
            {
                case 0:
                    lista.Clear();
                    lista.Add(new ReportDataSource("dsHotel", HOTELBindingSource));
                    lista.Add(new ReportDataSource("dsHospede", this.cLIENTEBindingSource));
                    frm.setReport("listadehospedes.rdlc", lista);
                    break;
                case 1: 
                    lista.Clear();
                    lista.Add(new ReportDataSource("dsHotel", HOTELBindingSource));
                    lista.Add(new ReportDataSource("dsHospede", this.cLIENTEBindingSource));
                    frm.setReport("fichaHospede.rdlc", lista);
                    break;
            }

            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
