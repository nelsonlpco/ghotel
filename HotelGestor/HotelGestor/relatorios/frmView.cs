﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelGestor.relatorios.hospedes
{
    public partial class frmView : Form
    {
        
        public frmView()
        {
            InitializeComponent();
        }

        public void setReport(string report, List<ReportDataSource> dslist)
        {
            this.rpv.LocalReport.ReportEmbeddedResource = "HotelGestor.relatorios.hospedes."+report;
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.

            foreach (ReportDataSource ds in dslist )
            {
                this.rpv.LocalReport.DataSources.Add(ds);
            }
            

            this.rpv.RefreshReport();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOTEL' table. You can move, or remove it, as needed.

        }

    }
}
