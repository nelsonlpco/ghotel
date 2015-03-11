using HotelGestor.relatorios.fatura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmHospedagem : HotelGestor.template.frmMainCadastro
    {
        private HotelDBDataSetTableAdapters.QUARTOTableAdapter quartoTba;
        private HotelDBDataSetTableAdapters.CLIENTETableAdapter clientetb;

        public frmHospedagem()
        {
            InitializeComponent();
            quartoTba = new HotelDBDataSetTableAdapters.QUARTOTableAdapter();
            clientetb = new HotelDBDataSetTableAdapters.CLIENTETableAdapter();
        }


        private double valorbase = 0;

        private bool fadditem = false;

        private void selecionarCliente()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            frmHospedes frm = new frmHospedes();
            frm.selectMod();
            frm.ShowDialog();
            nIDCLIENTETextBox.Text = string.Format("{0}",frm.SelectId);
            currentRow["NIDCLIENTE"] = frm.SelectId;
            txtNomeCliente.Text = frm.SelectDescription;
            frm.Dispose();
        }

        private void selecionarQuarto()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            frmQuartos frm = new frmQuartos();
            frm.selectMod();
            frm.ShowDialog();
            nIDQUARTOTextBox.Text = string.Format("{0}", frm.SelectId);
            currentRow["NIDQUARTO"] = frm.SelectId;
            txtDescQuarto.Text = frm.SelectDescription;
            frm.Dispose();
        }

        private DataRowView currentRow;

        private void addeventos()
        {
            
        }

        private double totalListado()
        {
            double saida = 0;
            foreach (DataRow row in hotelDBDataSet.FaturaXItens.Rows)
            {
                saida += Comum.strToDouble(row["NVALORTOTAL"].ToString());
            }
            return saida;
        }

        public bool isEmptyItens()
        {
            bool saida = true;
            if (hotelDBDataSet.FaturaXItens.Rows.Count > 0)
                saida = false;
            return saida;
        }

        public void buttonItensStats()
        {
            btnAddItem.Enabled = !fadditem;
            btnExcluirItem.Enabled = !fadditem && !isEmptyItens();
            btnCancelarItem.Enabled = fadditem;
        }

        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.HOSPEDAGEM.Rows.Count > 0)
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
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            currentRow["CESTATUS"] = "A";
            hOSPEDAGEMBindingSource.EndEdit();
            hOSPEDAGEMTableAdapter.Update(hotelDBDataSet.HOSPEDAGEM);
            SavePrompt = false;
            IsInclude = false;

            qUARTOTableAdapter.UpdateStatus("O", (int)currentRow["NIDQUARTO"], (int)currentRow["NIDQUARTO"]);

            buttonStates();
            tableControlHandler();
        }

        public void editar()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            currentRow["CESTATUS"] = "E";
            SavePrompt = true;
            tableControlHandler();
        }

        public override void excluir()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            if ((string)currentRow["CESTATUS"] == "F")
            {
                Comum.msgAlert("Não é possivel excluir hospedagens encerradas!");
                return;
            }
            lbStatus.Text = Comum.screenStats('d');
            Comum.msgAlert("Excluir a hospedagem implica em exclusão dos consumos e fatura!");
            if (Comum.msgExcluir(Comum.MSG_EXCLUIR))
            {
                
                currentRow.Delete();
                qUARTOTableAdapter.UpdateStatus("L", (int)currentRow["NIDQUARTO"], (int)currentRow["NIDQUARTO"]);
                tableAdapterManager.UpdateAll(hotelDBDataSet);   
            }
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public override void cancelar()
        {
            hOSPEDAGEMBindingSource.CancelEdit();
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
            hOSPEDAGEMBindingSource.AddNew();
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            currentRow["CESTATUS"] = "E";
            currentRow["DDATAIN"] = DateTime.Now;
            currentRow["DDATAOUT"] = currentRow["DDATAIN"];
            dDATAINDateTimePicker.Value = (DateTime) currentRow["DDATAIN"];
            dDATAOUTDateTimePicker.Value =(DateTime) currentRow["DDATAIN"];
            nDIARIASNumericUpDown.Value = 0;
            buttonStates();
            tableControlHandler();
            tbMain.SelectedIndex = 1;
            txtDescQuarto.Clear();
            txtNomeCliente.Clear();
            nIDCLIENTETextBox.Clear();
            nIDQUARTOTextBox.Clear();
        }

        public void carregaDescricao()
        {
            DataRowView hospedagem = (DataRowView)hOSPEDAGEMBindingSource.Current;
            try
            {  
              
                HotelDBDataSet.QUARTORow quarto   = quartoTba.GetDataById((int)hospedagem["NIDQUARTO"])[0];
                HotelDBDataSet.CLIENTERow cliente = clientetb.GetDataById((int)hospedagem["NIDCLIENTE"])[0];
                txtNomeCliente.Text = cliente.CNOME;
                txtDescQuarto.Text = String.Format("{0} - Andar: {1} - Numero: {2}", quarto.CDESCRICAO, quarto.NANDAR, quarto.NNUMERO);
            }
            catch
            {
                txtNomeCliente.Text = "";
                txtDescQuarto.Text = "";
            }
        }


        public void fecharFatura()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            currentRow["CESTATUS"] = "F";
            DataRowView fatura = (DataRowView)faturaBindingSource.Current;
            fatura["ddatafechamento"] = System.DateTime.Now;
            qUARTOTableAdapter.UpdateStatus("L", (int)currentRow["NIDQUARTO"], (int)currentRow["NIDQUARTO"]);
            tableAdapterManager.UpdateAll(hotelDBDataSet);
            tableControlHandler();
        }

        public void buscarItem()
        {
            frmItens frm = new frmItens();
            frm.selectMod();
            frm.ShowDialog();
            txtDescricaoitem.Text = frm.SelectDescription;
            nvalortotalTextBox.Text = String.Format("{0:N}", frm.SelectValue);
            valorbase = frm.SelectValue;
            currentRow = (DataRowView)faturaXItensBindingSource.Current;
            currentRow["niditem"] = frm.SelectId;
            currentRow["nvalorunit"] = valorbase;
            frm.Dispose();
            nqtditemNumericUpDown.Value = 1; 
        }

        public void atualizaItensFatura()
        {
            DataRowView faturaRow = (DataRowView)faturaBindingSource.Current;
            this.faturaXItensTableAdapter.FillByFatura(this.hotelDBDataSet.FaturaXItens, (int)faturaRow["nidfatura"]);
            lbTotalLancamentos.Text = string.Format("{0:N}", totalListado());
        }

        public void incluirItem()
        {
            faturaXItensBindingSource.AddNew();
            panelCadItens.Enabled = true;
            buscarItem();
            fadditem = true;
            lbStatus.Text = Comum.screenStats('i');
            buttonItensStats();
        }

        public void excluirItem()
        {
            lbStatus.Text = Comum.screenStats('e');
            if (Comum.msgExcluir(Comum.MSG_SEMREGISTRO))
            {
                currentRow = (DataRowView)faturaXItensBindingSource.Current;
                currentRow.Delete();
                faturaXItensTableAdapter.Update(hotelDBDataSet.FaturaXItens);
                atualizaItensFatura();
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonItensStats();
        }

        public void cancelarItem()
        {
            faturaXItensBindingSource.CancelEdit();
            lbStatus.Text = Comum.screenStats('c');
            panelCadItens.Enabled = false;
            fadditem = false;
            buttonItensStats();
        }

        public void salvarItem()
        {
            DataRowView faturaRow = (DataRowView)faturaBindingSource.Current;
            currentRow = (DataRowView)faturaXItensBindingSource.Current;
            currentRow["nidfatura"] = faturaRow["nidfatura"];
            currentRow["ddatamovim"] = DateTime.Now;
            currentRow["nqtditem"] = nqtditemNumericUpDown.Value;
            faturaXItensBindingSource.EndEdit();
            faturaXItensTableAdapter.Update(hotelDBDataSet.FaturaXItens);
            fadditem = false;
            lbStatus.Text = Comum.screenStats('c');
            buttonItensStats();
            panelCadItens.Enabled = false;
            atualizaItensFatura();
        }


        
        public override void filtro()
        {
            string filtro = "";

            hOSPEDAGEMBindingSource.Filter = filtro;

        }

        private void frmHospedagem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);
            // TODO: This line of code loads data into the 'hotelDBDataSet.QUARTO' table. You can move, or remove it, as needed.
            this.qUARTOTableAdapter.Fill(this.hotelDBDataSet.QUARTO);
            // TODO: This line of code loads data into the 'hotelDBDataSet.FORMASDEPAGAMENTO' table. You can move, or remove it, as needed.
            this.fORMASDEPAGAMENTOTableAdapter.Fill(this.hotelDBDataSet.FORMASDEPAGAMENTO);
            // TODO: This line of code loads data into the 'hotelDBDataSet.HOSPEDAGEM' table. You can move, or remove it, as needed.
            this.hOSPEDAGEMTableAdapter.FillForView(this.hotelDBDataSet.HOSPEDAGEM);
            tableControlHandler();
            buttonStates();
            carregaDescricao();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            selecionarCliente();
        }

        private void btnBuscaQuarto_Click(object sender, EventArgs e)
        {

            if (dDATAINDateTimePicker.Value.ToLocalTime().Equals(dDATAOUTDateTimePicker.Value.ToLocalTime())
                ||
                dDATAINDateTimePicker.Value.ToLocalTime() > dDATAOUTDateTimePicker.Value.ToLocalTime() )
            {
                Comum.msgAlert("Informe um periodo de hospedagem valido!");
                return;
            }
            selecionarQuarto();
        }

        private void nDIARIASNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DateTime tmp = dDATAINDateTimePicker.Value;
            dDATAOUTDateTimePicker.Value = tmp.AddDays((double)this.nDIARIASNumericUpDown.Value);
        }

        
        private void tbMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            tableControlHandler();
            if (SavePrompt && tbMain.SelectedIndex == 0)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                e.Cancel = true;
            }
            else if (isEmptyDataset() && !IsInclude && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
            }
            
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableControlHandler();
            switch(tbHospedagem.SelectedIndex)
            {
                case 1 :
                case 2 :
                    atualizarFatura();
                    atualizaItensFatura();
                    buttonItensStats();
                    break;
            }
        }

        private void atualizarFatura()
        {
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            if (currentRow == null)
                return;
            this.faturaTableAdapter.FillByHospedagem(this.hotelDBDataSet.fatura, (int)currentRow["NIDHOSPEDAGEM"]);

            lbConsumo.Text = lbTotalLancamentos.Text;
            lbdiarias.Text = currentRow["NDIARIAS"].ToString();
            
            HotelDBDataSetTableAdapters.QUARTOTableAdapter tbquarto = new HotelDBDataSetTableAdapters.QUARTOTableAdapter();
            tbquarto.FillById(hotelDBDataSet.QUARTO, (int)currentRow["NIDQUARTO"]);

            DataRow row = hotelDBDataSet.QUARTO.Rows[0];
            lbVlDiaria.Text = row["NVALORBASE"].ToString();

            lbTotalDiarias.Text = String.Format("{0:N}",(int.Parse(lbdiarias.Text.ToString()) * double.Parse(lbVlDiaria.Text.ToString())));

            double total = Double.Parse(lbTotalDiarias.Text.ToString()) + double.Parse(lbConsumo.Text.ToString());

            DataRowView fatura = (DataRowView)faturaBindingSource.Current;
            fatura["NVALOTTOTAL"] = total;
            nvalottotalTextBox.Text = string.Format("{0:N}", total);

        }

        private void btnHospedar_Click(object sender, EventArgs e)
        {
            if(validaCampos())
                salvar();
        }

        private void btnBuscaItem_Click(object sender, EventArgs e)
        {
            buscarItem();
        }

        private void nqtditemNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (fadditem)
            {
                currentRow = (DataRowView)faturaXItensBindingSource.Current;
                currentRow["nvalortotal"] = valorbase * (double)nqtditemNumericUpDown.Value;
                nvalortotalTextBox.Text = string.Format("{0:N}", valorbase * (double)nqtditemNumericUpDown.Value);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            incluirItem();
        }

        private void btnExcluirItem_Click(object sender, EventArgs e)
        {
            excluirItem();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            cancelarItem();
        }

        private void btnRegistraConsumo_Click(object sender, EventArgs e)
        {
            salvarItem();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void ndescontoTextBox_TextChanged(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

        private void nvalottotalTextBox_TextChanged(object sender, EventArgs e)
        {
            //Comum.moneyMask(sender);
        }


        private void tableControlHandler()
        {
            DataRowView dt = (DataRowView)hOSPEDAGEMBindingSource.Current;
            if (dt == null)
                return;
            char status = (string.IsNullOrEmpty(dt["CESTATUS"].ToString()) ? 'E' : dt["CESTATUS"].ToString()[0]);
            switch (status)
            {
                case 'F':
                    this.btnHospedar.Image = global::HotelGestor.Properties.Resources.trancado;
                    this.btnHospedar.Text = "Hospedado";
                    this.btnHospedar.Enabled = false;
    
                    this.btnEditarHospedagem.Enabled = false;

                    panel2.Enabled = false;
                    panel2.BackColor = Color.Silver;

                    panel4.Enabled = false;

                    pnCheckout.Enabled = false;
                    pnCheckout.BackColor = Color.Silver;
                    btnFatura.Enabled = true;
                    btnEncerrar.Enabled = false;
                    btnEncerrar.Image = global::HotelGestor.Properties.Resources.trancado;

                break;
                case 'A':
                    if (!tbHospedagem.TabPages.Contains(tabConsumo))
                    {
                        tbHospedagem.TabPages.Add(tabConsumo);
                        tbHospedagem.TabPages.Add(tabCheckOut);
                        this.btnHospedar.Image = global::HotelGestor.Properties.Resources.trancado;
                        this.btnHospedar.Text = "Hospedado";
                        this.btnHospedar.Enabled = false;

                        this.btnEditarHospedagem.Enabled = true;

                        panel2.Enabled = false;
                        panel2.BackColor = Color.Silver;
                        panel4.Enabled = true;
                        pnCheckout.Enabled = true;
                        pnCheckout.BackColor = Color.White;
                        btnFatura.Enabled = false;
                        btnEncerrar.Enabled = true;
                    }
                    else
                    {
                        this.btnHospedar.Image = global::HotelGestor.Properties.Resources.trancado;
                        this.btnHospedar.Text = "Hospedado";
                        this.btnHospedar.Enabled = false;
                        panel2.Enabled = false;
                        panel2.BackColor = Color.Silver;
                        this.btnEditarHospedagem.Enabled = true;

                        panel4.Enabled = true;
                        pnCheckout.Enabled = true;
                        pnCheckout.BackColor = Color.White;
                        btnFatura.Enabled = false;
                        btnEncerrar.Enabled = true;
                    }
                break;
                default:
                    tbHospedagem.TabPages.Remove(tabConsumo);
                    tbHospedagem.TabPages.Remove(tabCheckOut);
                    this.btnHospedar.Image = global::HotelGestor.Properties.Resources.aberto;
                    this.btnHospedar.Enabled = true;
                    this.btnEditarHospedagem.Enabled = false;
                    panel2.Enabled = true;
                    panel2.BackColor = Color.White;
                break;
            }


        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            fecharFatura();
        }

        private void btnEditarHospedagem_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void ndescontoTextBox_Leave(object sender, EventArgs e)
        {
            string total = string.IsNullOrEmpty(nvalottotalTextBox.Text) ? "0" : nvalottotalTextBox.Text;
            string desconto = string.IsNullOrEmpty(ndescontoTextBox.Text) ? "0" : ndescontoTextBox.Text;
            nvalottotalTextBox.Text = string.Format("{0:N}", double.Parse(total) - double.Parse(desconto));
        }

        private void nvalottotalTextBox_TextChanged_1(object sender, EventArgs e)
        {
            Comum.moneyMask(sender);
        }

        private void ndescontoTextBox_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
        }

        private Boolean validaCampos()
        {
            bool saida = true;

            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            if (string.IsNullOrEmpty(currentRow["NIDCLIENTE"].ToString()))
            {
                Comum.msgAlert("Por favor selecione um hóspede!");
                return false;
            }
            if (string.IsNullOrEmpty(currentRow["NIDQUARTO"].ToString()))
            {
                Comum.msgAlert("Por favor selecionem um quarto!");
                return false;
            }
            if (nDIARIASNumericUpDown.Value <= 0)
            {
                Comum.msgAlert("Informe ao menos uma diaria!");
                return false;
            }

            if (dDATAINDateTimePicker.Value.ToLocalTime() > dDATAOUTDateTimePicker.Value.ToLocalTime())
            {
                Comum.msgAlert("A data de saida deve ser superior a de entrada!");
                return false;
            }

            return saida;
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            frmViewFatura frm = new frmViewFatura();
            
            currentRow = (DataRowView)hOSPEDAGEMBindingSource.Current;
            frm.frmCarregaFatura((int)currentRow["NIDHOSPEDAGEM"]);

            frm.ShowDialog();
            frm.Dispose();
        }

        public void filtrar()
        {
            string filtro = "";
            if (!String.IsNullOrEmpty(txtFiltroHospede.Text))
            {
                filtro = "NIDCLIENTE = 0 ";
                HotelDBDataSet.CLIENTERow row = null;
                try
                {
                    for (int i = 0; i < cLIENTETableAdapter.GetDataByNome(txtFiltroHospede.Text).Rows.Count; i++)
                    {
                        if (i == 0)
                            filtro = "";
                        if (i > 0)
                            filtro += " OR ";
                        row = cLIENTETableAdapter.GetDataByNome(txtFiltroHospede.Text)[i];
                        filtro += string.Format("NIDCLIENTE = {0} ", row.NNUMECLIENTE.ToString());
                    }

                }
                catch (Exception ex)
                {

                }
            }
            if (txtFiltroDataIn.Text != "  /  /")
            {
                if (!String.IsNullOrEmpty(filtro))
                    filtro += " AND ";
                filtro += string.Format(" DDATAIN >= '{0}'", txtFiltroDataIn.Text);
            }
            if (txtFiletroDataOut.Text != "  /  /")
            {
                if (!String.IsNullOrEmpty(filtro))
                    filtro += " AND ";
                filtro += string.Format(" DDATAIN <= '{0}'", txtFiletroDataOut.Text);
            }

            if (chHospAbertas.Checked && !string.IsNullOrEmpty(filtro))
            {
                filtro += " AND ";
            }
            if (chHospAbertas.Checked)
            {
                filtro += string.Format("  CESTATUS =  '{0}'", "A");
            }
            hOSPEDAGEMBindingSource.Filter = filtro;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filtrar();
        }
       

    }
}
