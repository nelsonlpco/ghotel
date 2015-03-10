using HotelGestor.relatorios.hospedes;
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
        private frmView frm;
        public frmRelatoriosHospedes()
        {
            InitializeComponent();
        }

        private void frmRelatoriosHospedes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);
            // TODO: This line of code loads data into the 'hotelDbsRelatorios.CLIENTE' table. You can move, or remove it, as needed.
            //this.cLIENTETableAdapter.Fill(this.hotelDbsRelatorios.CLIENTE);

            cbRelatorios.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm = new frmView();
            
            List<ReportDataSource> lista = new List<ReportDataSource>();
            switch (cbRelatorios.SelectedIndex)
            {
                case 0:
                    DataRowView row = (DataRowView) cLIENTEBindingSource.Current;
                    lista.Clear();
                    frm.setReport("fichaHospede.rdlc", lista, (int)row["NNUMECLIENTE"]);
                    break;
                case 1:
                    lista.Clear();
                    frm.setReport("listadehospedes.rdlc", lista, 0);
                    break;
            }
            
            frm.ShowDialog();
            frm.Dispose();
        }


        public System.Collections.IEnumerable HOTELBindingSource { get; set; }

        public string filtro() {
            string filtro = "";
            if (!string.IsNullOrEmpty(txtNome.Text))
            {
                filtro = string.Format(" CNOME LIKE '%{0}%'", txtNome.Text);
            }
            
            if(!string.IsNullOrEmpty(filtro) && txtDnIni.Text!= "  /  /")
            {
                filtro += " and ";
            }
            if (txtDnIni.Text != "  /  /")
            {
                filtro += " DDATANASC >= "+txtDnIni.Text;
            }
            if (!string.IsNullOrEmpty(filtro) && txtDnFim.Text != "  /  /") 
            {
                filtro += " and ";
            }
            if(txtDnFim.Text != "  /  /")
            {
                filtro += " DDATANASC <= "+txtDnFim.Text;
            }
            if (!string.IsNullOrEmpty(filtro) && txtDtCadIni.Text != "  /  /") 
            {
                filtro += " and ";
            }
            if(txtDtCadIni.Text != "  /  /")
            {
                filtro += " DDATACADASTRO >= "+txtDtCadIni.Text;
            }
            if (!string.IsNullOrEmpty(filtro) && txtDtCadFim.Text != "  /  /") 
            {
                filtro += " and ";
            }
            if(txtDtCadFim.Text != "  /  /")
            {
                filtro += " DDATACADASTRO <= "+txtDtCadFim.Text;
            }
            return filtro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cLIENTEBindingSource.Filter = filtro();
        }
    }
}
