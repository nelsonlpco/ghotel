﻿namespace HotelGestor
{
    partial class frmHospedagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nDIARIASLabel;
            System.Windows.Forms.Label dDATAOUTLabel;
            System.Windows.Forms.Label nIDCLIENTELabel;
            System.Windows.Forms.Label dDATAINLabel;
            System.Windows.Forms.Label nIDQUARTOLabel;
            System.Windows.Forms.Label nVALORBRUTOLabel;
            System.Windows.Forms.Label nQUANTIDADELabel;
            System.Windows.Forms.Label nIDITEMCONSUMOLabel;
            System.Windows.Forms.Label nVALORBASELabel;
            System.Windows.Forms.Label vVALORDESCONTOLabel;
            System.Windows.Forms.Label vVALORTOTALLabel;
            System.Windows.Forms.Label fFORMAPAGAMENTOLabel;
            System.Windows.Forms.Label cOBSERVACAOLabel;
            System.Windows.Forms.Label ncontroleLabel;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HOSPEDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUARTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATAINDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATAOUTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDIARIASDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOSPEDAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.DESC_QUARTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NDIARIAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VVALORTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDATAIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDATAOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIDQUARTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATAINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATAOUTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cESTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vVALORTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vVALORDESCONTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATAFECHAMENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDIARIASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCQUARTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHospedagem = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarHospedagem = new System.Windows.Forms.Button();
            this.btnHospedar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescQuarto = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.nDIARIASNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dDATAINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dDATAOUTDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nIDQUARTOTextBox = new System.Windows.Forms.TextBox();
            this.nIDCLIENTETextBox = new System.Windows.Forms.TextBox();
            this.btnBuscaQuarto = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.tabConsumo = new System.Windows.Forms.TabPage();
            this.panelCadItens = new System.Windows.Forms.Panel();
            this.nvalortotalTextBox = new System.Windows.Forms.TextBox();
            this.faturaXItensBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nqtditemNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtDescricaoitem = new System.Windows.Forms.TextBox();
            this.btnBuscaItem = new System.Windows.Forms.Button();
            this.btnRegistraConsumo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.CDESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nqtditem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvalorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvalortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddatamovim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nidfaturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.niditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nqtditemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvalorunitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvalortotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ddatamovimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbTotalLancamentos = new System.Windows.Forms.Label();
            this.lbtot = new System.Windows.Forms.Label();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.pnCheckout = new System.Windows.Forms.Panel();
            this.nvalottotalTextBox = new System.Windows.Forms.TextBox();
            this.faturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ncontroleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lbTotalDiarias = new System.Windows.Forms.Label();
            this.lbVlDiaria = new System.Windows.Forms.Label();
            this.lbdiarias = new System.Windows.Forms.Label();
            this.cobservacaoTextBox = new System.Windows.Forms.TextBox();
            this.ndescontoTextBox = new System.Windows.Forms.TextBox();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fFORMAPAGAMENTOComboBox = new System.Windows.Forms.ComboBox();
            this.fORMASDEPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.hOSPEDAGEMTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.HOSPEDAGEMTableAdapter();
            this.fORMASDEPAGAMENTOTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.FORMASDEPAGAMENTOTableAdapter();
            this.faturaXItensTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.FaturaXItensTableAdapter();
            this.faturaTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.faturaTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.qUARTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUARTOTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.QUARTOTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFiletroDataOut = new System.Windows.Forms.MaskedTextBox();
            this.txtFiltroDataIn = new System.Windows.Forms.MaskedTextBox();
            this.txtFiltroHospede = new System.Windows.Forms.TextBox();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.CLIENTETableAdapter();
            this.chHospAbertas = new System.Windows.Forms.CheckBox();
            nDIARIASLabel = new System.Windows.Forms.Label();
            dDATAOUTLabel = new System.Windows.Forms.Label();
            nIDCLIENTELabel = new System.Windows.Forms.Label();
            dDATAINLabel = new System.Windows.Forms.Label();
            nIDQUARTOLabel = new System.Windows.Forms.Label();
            nVALORBRUTOLabel = new System.Windows.Forms.Label();
            nQUANTIDADELabel = new System.Windows.Forms.Label();
            nIDITEMCONSUMOLabel = new System.Windows.Forms.Label();
            nVALORBASELabel = new System.Windows.Forms.Label();
            vVALORDESCONTOLabel = new System.Windows.Forms.Label();
            vVALORTOTALLabel = new System.Windows.Forms.Label();
            fFORMAPAGAMENTOLabel = new System.Windows.Forms.Label();
            cOBSERVACAOLabel = new System.Windows.Forms.Label();
            ncontroleLabel = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.tbHospedagem.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown)).BeginInit();
            this.tabConsumo.SuspendLayout();
            this.panelCadItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturaXItensBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nqtditemNumericUpDown)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabCheckOut.SuspendLayout();
            this.pnCheckout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncontroleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASDEPAGAMENTOBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qUARTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(348, 0);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.Location = new System.Drawing.Point(261, 0);
            this.btnGravar.Visible = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(174, 0);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(87, 0);
            // 
            // btnTransferir
            // 
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.tbHospedagem);
            this.tbConsulta.Size = new System.Drawing.Size(776, 448);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.dataGridView1);
            this.tbCadastro.Controls.SetChildIndex(this.pnFiltros, 0);
            this.tbCadastro.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // pnFiltros
            // 
            this.pnFiltros.AutoScroll = true;
            this.pnFiltros.Controls.Add(this.chHospAbertas);
            this.pnFiltros.Controls.Add(this.label3);
            this.pnFiltros.Controls.Add(this.label7);
            this.pnFiltros.Controls.Add(this.label8);
            this.pnFiltros.Controls.Add(this.button1);
            this.pnFiltros.Controls.Add(this.txtFiletroDataOut);
            this.pnFiltros.Controls.Add(this.txtFiltroDataIn);
            this.pnFiltros.Controls.Add(this.txtFiltroHospede);
            this.pnFiltros.Size = new System.Drawing.Size(770, 114);
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            // 
            // nDIARIASLabel
            // 
            nDIARIASLabel.AutoSize = true;
            nDIARIASLabel.Location = new System.Drawing.Point(168, 137);
            nDIARIASLabel.Name = "nDIARIASLabel";
            nDIARIASLabel.Size = new System.Drawing.Size(54, 18);
            nDIARIASLabel.TabIndex = 28;
            nDIARIASLabel.Text = "Diarias:";
            // 
            // dDATAOUTLabel
            // 
            dDATAOUTLabel.AutoSize = true;
            dDATAOUTLabel.Location = new System.Drawing.Point(86, 171);
            dDATAOUTLabel.Name = "dDATAOUTLabel";
            dDATAOUTLabel.Size = new System.Drawing.Size(136, 18);
            dDATAOUTLabel.TabIndex = 26;
            dDATAOUTLabel.Text = "Data e Hora da saida:";
            // 
            // nIDCLIENTELabel
            // 
            nIDCLIENTELabel.AutoSize = true;
            nIDCLIENTELabel.Location = new System.Drawing.Point(168, 69);
            nIDCLIENTELabel.Name = "nIDCLIENTELabel";
            nIDCLIENTELabel.Size = new System.Drawing.Size(54, 18);
            nIDCLIENTELabel.TabIndex = 19;
            nIDCLIENTELabel.Text = "Cliente:";
            // 
            // dDATAINLabel
            // 
            dDATAINLabel.AutoSize = true;
            dDATAINLabel.Location = new System.Drawing.Point(72, 102);
            dDATAINLabel.Name = "dDATAINLabel";
            dDATAINLabel.Size = new System.Drawing.Size(150, 18);
            dDATAINLabel.TabIndex = 16;
            dDATAINLabel.Text = "Data e Hora da Entrada:";
            // 
            // nIDQUARTOLabel
            // 
            nIDQUARTOLabel.AutoSize = true;
            nIDQUARTOLabel.Location = new System.Drawing.Point(169, 207);
            nIDQUARTOLabel.Name = "nIDQUARTOLabel";
            nIDQUARTOLabel.Size = new System.Drawing.Size(53, 18);
            nIDQUARTOLabel.TabIndex = 15;
            nIDQUARTOLabel.Text = "Quarto:";
            // 
            // nVALORBRUTOLabel
            // 
            nVALORBRUTOLabel.AutoSize = true;
            nVALORBRUTOLabel.Location = new System.Drawing.Point(11, 113);
            nVALORBRUTOLabel.Name = "nVALORBRUTOLabel";
            nVALORBRUTOLabel.Size = new System.Drawing.Size(72, 18);
            nVALORBRUTOLabel.TabIndex = 13;
            nVALORBRUTOLabel.Text = "Valor total:";
            // 
            // nQUANTIDADELabel
            // 
            nQUANTIDADELabel.AutoSize = true;
            nQUANTIDADELabel.Location = new System.Drawing.Point(4, 70);
            nQUANTIDADELabel.Name = "nQUANTIDADELabel";
            nQUANTIDADELabel.Size = new System.Drawing.Size(80, 18);
            nQUANTIDADELabel.TabIndex = 11;
            nQUANTIDADELabel.Text = "Quantidade:";
            // 
            // nIDITEMCONSUMOLabel
            // 
            nIDITEMCONSUMOLabel.AutoSize = true;
            nIDITEMCONSUMOLabel.Location = new System.Drawing.Point(44, 34);
            nIDITEMCONSUMOLabel.Name = "nIDITEMCONSUMOLabel";
            nIDITEMCONSUMOLabel.Size = new System.Drawing.Size(40, 18);
            nIDITEMCONSUMOLabel.TabIndex = 10;
            nIDITEMCONSUMOLabel.Text = "Item:";
            // 
            // nVALORBASELabel
            // 
            nVALORBASELabel.AutoSize = true;
            nVALORBASELabel.Location = new System.Drawing.Point(111, 124);
            nVALORBASELabel.Name = "nVALORBASELabel";
            nVALORBASELabel.Size = new System.Drawing.Size(97, 18);
            nVALORBASELabel.TabIndex = 38;
            nVALORBASELabel.Text = "Valor da diaria:";
            // 
            // vVALORDESCONTOLabel
            // 
            vVALORDESCONTOLabel.AutoSize = true;
            vVALORDESCONTOLabel.Location = new System.Drawing.Point(142, 149);
            vVALORDESCONTOLabel.Name = "vVALORDESCONTOLabel";
            vVALORDESCONTOLabel.Size = new System.Drawing.Size(66, 18);
            vVALORDESCONTOLabel.TabIndex = 31;
            vVALORDESCONTOLabel.Text = "Desconto:";
            // 
            // vVALORTOTALLabel
            // 
            vVALORTOTALLabel.AutoSize = true;
            vVALORTOTALLabel.Location = new System.Drawing.Point(135, 178);
            vVALORTOTALLabel.Name = "vVALORTOTALLabel";
            vVALORTOTALLabel.Size = new System.Drawing.Size(73, 18);
            vVALORTOTALLabel.TabIndex = 29;
            vVALORTOTALLabel.Text = "Valor Total:";
            // 
            // fFORMAPAGAMENTOLabel
            // 
            fFORMAPAGAMENTOLabel.AutoSize = true;
            fFORMAPAGAMENTOLabel.Location = new System.Drawing.Point(72, 45);
            fFORMAPAGAMENTOLabel.Name = "fFORMAPAGAMENTOLabel";
            fFORMAPAGAMENTOLabel.Size = new System.Drawing.Size(136, 18);
            fFORMAPAGAMENTOLabel.TabIndex = 27;
            fFORMAPAGAMENTOLabel.Text = "Forma de Pagamento:";
            // 
            // cOBSERVACAOLabel
            // 
            cOBSERVACAOLabel.AutoSize = true;
            cOBSERVACAOLabel.Location = new System.Drawing.Point(127, 205);
            cOBSERVACAOLabel.Name = "cOBSERVACAOLabel";
            cOBSERVACAOLabel.Size = new System.Drawing.Size(81, 18);
            cOBSERVACAOLabel.TabIndex = 26;
            cOBSERVACAOLabel.Text = "Observação:";
            // 
            // ncontroleLabel
            // 
            ncontroleLabel.AutoSize = true;
            ncontroleLabel.Location = new System.Drawing.Point(113, 16);
            ncontroleLabel.Name = "ncontroleLabel";
            ncontroleLabel.Size = new System.Drawing.Size(95, 18);
            ncontroleLabel.TabIndex = 42;
            ncontroleLabel.Text = "Nº de controle:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(315, 124);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(161, 18);
            label6.TabIndex = 46;
            label6.Text = "Valor Total da(s) diaria(s):";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOSPEDE,
            this.QUARTO,
            this.dDATAINDataGridViewTextBoxColumn1,
            this.dDATAOUTDataGridViewTextBoxColumn1,
            this.nDIARIASDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.hOSPEDAGEMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 326);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // HOSPEDE
            // 
            this.HOSPEDE.DataPropertyName = "HOSPEDE";
            this.HOSPEDE.HeaderText = "Hóspede";
            this.HOSPEDE.Name = "HOSPEDE";
            this.HOSPEDE.ReadOnly = true;
            this.HOSPEDE.Width = 250;
            // 
            // QUARTO
            // 
            this.QUARTO.DataPropertyName = "QUARTO";
            this.QUARTO.HeaderText = "Quarto";
            this.QUARTO.Name = "QUARTO";
            this.QUARTO.ReadOnly = true;
            this.QUARTO.Width = 150;
            // 
            // dDATAINDataGridViewTextBoxColumn1
            // 
            this.dDATAINDataGridViewTextBoxColumn1.DataPropertyName = "DDATAIN";
            this.dDATAINDataGridViewTextBoxColumn1.HeaderText = "Entrada";
            this.dDATAINDataGridViewTextBoxColumn1.Name = "dDATAINDataGridViewTextBoxColumn1";
            this.dDATAINDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dDATAOUTDataGridViewTextBoxColumn1
            // 
            this.dDATAOUTDataGridViewTextBoxColumn1.DataPropertyName = "DDATAOUT";
            this.dDATAOUTDataGridViewTextBoxColumn1.HeaderText = "Saida";
            this.dDATAOUTDataGridViewTextBoxColumn1.Name = "dDATAOUTDataGridViewTextBoxColumn1";
            this.dDATAOUTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nDIARIASDataGridViewTextBoxColumn1
            // 
            this.nDIARIASDataGridViewTextBoxColumn1.DataPropertyName = "NDIARIAS";
            this.nDIARIASDataGridViewTextBoxColumn1.HeaderText = "Diárias";
            this.nDIARIASDataGridViewTextBoxColumn1.Name = "nDIARIASDataGridViewTextBoxColumn1";
            this.nDIARIASDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hOSPEDAGEMBindingSource
            // 
            this.hOSPEDAGEMBindingSource.DataMember = "HOSPEDAGEM";
            this.hOSPEDAGEMBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DESC_QUARTO
            // 
            this.DESC_QUARTO.DataPropertyName = "DESC_QUARTO";
            this.DESC_QUARTO.HeaderText = "Quarto";
            this.DESC_QUARTO.Name = "DESC_QUARTO";
            this.DESC_QUARTO.ReadOnly = true;
            // 
            // CNOME
            // 
            this.CNOME.DataPropertyName = "CNOME";
            this.CNOME.HeaderText = "Hóspede";
            this.CNOME.Name = "CNOME";
            this.CNOME.ReadOnly = true;
            // 
            // NDIARIAS
            // 
            this.NDIARIAS.DataPropertyName = "NDIARIAS";
            this.NDIARIAS.HeaderText = "Diárias";
            this.NDIARIAS.Name = "NDIARIAS";
            this.NDIARIAS.ReadOnly = true;
            // 
            // VVALORTOTAL
            // 
            this.VVALORTOTAL.DataPropertyName = "VVALORTOTAL";
            this.VVALORTOTAL.HeaderText = "Valor";
            this.VVALORTOTAL.Name = "VVALORTOTAL";
            this.VVALORTOTAL.ReadOnly = true;
            // 
            // DDATAIN
            // 
            this.DDATAIN.DataPropertyName = "DDATAIN";
            this.DDATAIN.HeaderText = "Entrada";
            this.DDATAIN.Name = "DDATAIN";
            this.DDATAIN.ReadOnly = true;
            // 
            // DDATAOUT
            // 
            this.DDATAOUT.DataPropertyName = "DDATAOUT";
            this.DDATAOUT.HeaderText = "Saida";
            this.DDATAOUT.Name = "DDATAOUT";
            this.DDATAOUT.ReadOnly = true;
            // 
            // nIDHOSPEDAGEMDataGridViewTextBoxColumn
            // 
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn.DataPropertyName = "NIDHOSPEDAGEM";
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn.HeaderText = "NIDHOSPEDAGEM";
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn.Name = "nIDHOSPEDAGEMDataGridViewTextBoxColumn";
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIDCLIENTEDataGridViewTextBoxColumn
            // 
            this.nIDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NIDCLIENTE";
            this.nIDCLIENTEDataGridViewTextBoxColumn.HeaderText = "NIDCLIENTE";
            this.nIDCLIENTEDataGridViewTextBoxColumn.Name = "nIDCLIENTEDataGridViewTextBoxColumn";
            this.nIDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIDQUARTODataGridViewTextBoxColumn
            // 
            this.nIDQUARTODataGridViewTextBoxColumn.DataPropertyName = "NIDQUARTO";
            this.nIDQUARTODataGridViewTextBoxColumn.HeaderText = "NIDQUARTO";
            this.nIDQUARTODataGridViewTextBoxColumn.Name = "nIDQUARTODataGridViewTextBoxColumn";
            this.nIDQUARTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDATAINDataGridViewTextBoxColumn
            // 
            this.dDATAINDataGridViewTextBoxColumn.DataPropertyName = "DDATAIN";
            this.dDATAINDataGridViewTextBoxColumn.HeaderText = "DDATAIN";
            this.dDATAINDataGridViewTextBoxColumn.Name = "dDATAINDataGridViewTextBoxColumn";
            this.dDATAINDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDATAOUTDataGridViewTextBoxColumn
            // 
            this.dDATAOUTDataGridViewTextBoxColumn.DataPropertyName = "DDATAOUT";
            this.dDATAOUTDataGridViewTextBoxColumn.HeaderText = "DDATAOUT";
            this.dDATAOUTDataGridViewTextBoxColumn.Name = "dDATAOUTDataGridViewTextBoxColumn";
            this.dDATAOUTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cESTATUSDataGridViewTextBoxColumn
            // 
            this.cESTATUSDataGridViewTextBoxColumn.DataPropertyName = "CESTATUS";
            this.cESTATUSDataGridViewTextBoxColumn.HeaderText = "CESTATUS";
            this.cESTATUSDataGridViewTextBoxColumn.Name = "cESTATUSDataGridViewTextBoxColumn";
            this.cESTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOBSERVACAODataGridViewTextBoxColumn
            // 
            this.cOBSERVACAODataGridViewTextBoxColumn.DataPropertyName = "COBSERVACAO";
            this.cOBSERVACAODataGridViewTextBoxColumn.HeaderText = "COBSERVACAO";
            this.cOBSERVACAODataGridViewTextBoxColumn.Name = "cOBSERVACAODataGridViewTextBoxColumn";
            this.cOBSERVACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fFORMAPAGAMENTODataGridViewTextBoxColumn
            // 
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn.DataPropertyName = "FFORMAPAGAMENTO";
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn.HeaderText = "FFORMAPAGAMENTO";
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn.Name = "fFORMAPAGAMENTODataGridViewTextBoxColumn";
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vVALORTOTALDataGridViewTextBoxColumn
            // 
            this.vVALORTOTALDataGridViewTextBoxColumn.DataPropertyName = "VVALORTOTAL";
            this.vVALORTOTALDataGridViewTextBoxColumn.HeaderText = "VVALORTOTAL";
            this.vVALORTOTALDataGridViewTextBoxColumn.Name = "vVALORTOTALDataGridViewTextBoxColumn";
            this.vVALORTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vVALORDESCONTODataGridViewTextBoxColumn
            // 
            this.vVALORDESCONTODataGridViewTextBoxColumn.DataPropertyName = "VVALORDESCONTO";
            this.vVALORDESCONTODataGridViewTextBoxColumn.HeaderText = "VVALORDESCONTO";
            this.vVALORDESCONTODataGridViewTextBoxColumn.Name = "vVALORDESCONTODataGridViewTextBoxColumn";
            this.vVALORDESCONTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDATAFECHAMENTODataGridViewTextBoxColumn
            // 
            this.dDATAFECHAMENTODataGridViewTextBoxColumn.DataPropertyName = "DDATAFECHAMENTO";
            this.dDATAFECHAMENTODataGridViewTextBoxColumn.HeaderText = "DDATAFECHAMENTO";
            this.dDATAFECHAMENTODataGridViewTextBoxColumn.Name = "dDATAFECHAMENTODataGridViewTextBoxColumn";
            this.dDATAFECHAMENTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDIARIASDataGridViewTextBoxColumn
            // 
            this.nDIARIASDataGridViewTextBoxColumn.DataPropertyName = "NDIARIAS";
            this.nDIARIASDataGridViewTextBoxColumn.HeaderText = "NDIARIAS";
            this.nDIARIASDataGridViewTextBoxColumn.Name = "nDIARIASDataGridViewTextBoxColumn";
            this.nDIARIASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNOMEDataGridViewTextBoxColumn
            // 
            this.cNOMEDataGridViewTextBoxColumn.DataPropertyName = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.HeaderText = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.Name = "cNOMEDataGridViewTextBoxColumn";
            this.cNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESCQUARTODataGridViewTextBoxColumn
            // 
            this.dESCQUARTODataGridViewTextBoxColumn.DataPropertyName = "DESC_QUARTO";
            this.dESCQUARTODataGridViewTextBoxColumn.HeaderText = "DESC_QUARTO";
            this.dESCQUARTODataGridViewTextBoxColumn.Name = "dESCQUARTODataGridViewTextBoxColumn";
            this.dESCQUARTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbHospedagem
            // 
            this.tbHospedagem.Controls.Add(this.tabPage3);
            this.tbHospedagem.Controls.Add(this.tabConsumo);
            this.tbHospedagem.Controls.Add(this.tabCheckOut);
            this.tbHospedagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbHospedagem.Location = new System.Drawing.Point(3, 4);
            this.tbHospedagem.Name = "tbHospedagem";
            this.tbHospedagem.SelectedIndex = 0;
            this.tbHospedagem.Size = new System.Drawing.Size(770, 440);
            this.tbHospedagem.TabIndex = 0;
            this.tbHospedagem.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 409);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Check-in";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEditarHospedagem);
            this.panel3.Controls.Add(this.btnHospedar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 112);
            this.panel3.TabIndex = 16;
            // 
            // btnEditarHospedagem
            // 
            this.btnEditarHospedagem.Enabled = false;
            this.btnEditarHospedagem.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHospedagem.ForeColor = System.Drawing.Color.Black;
            this.btnEditarHospedagem.Image = global::HotelGestor.Properties.Resources.checkin;
            this.btnEditarHospedagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarHospedagem.Location = new System.Drawing.Point(262, 15);
            this.btnEditarHospedagem.Name = "btnEditarHospedagem";
            this.btnEditarHospedagem.Size = new System.Drawing.Size(230, 80);
            this.btnEditarHospedagem.TabIndex = 13;
            this.btnEditarHospedagem.Text = "Editar";
            this.btnEditarHospedagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHospedagem.UseVisualStyleBackColor = true;
            this.btnEditarHospedagem.Click += new System.EventHandler(this.btnEditarHospedagem_Click);
            // 
            // btnHospedar
            // 
            this.btnHospedar.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedar.ForeColor = System.Drawing.Color.Black;
            this.btnHospedar.Image = global::HotelGestor.Properties.Resources.aberto;
            this.btnHospedar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedar.Location = new System.Drawing.Point(498, 16);
            this.btnHospedar.Name = "btnHospedar";
            this.btnHospedar.Size = new System.Drawing.Size(230, 80);
            this.btnHospedar.TabIndex = 0;
            this.btnHospedar.Text = "Hospedar";
            this.btnHospedar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHospedar.UseVisualStyleBackColor = true;
            this.btnHospedar.Click += new System.EventHandler(this.btnHospedar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDescQuarto);
            this.panel2.Controls.Add(this.txtNomeCliente);
            this.panel2.Controls.Add(nDIARIASLabel);
            this.panel2.Controls.Add(this.nDIARIASNumericUpDown);
            this.panel2.Controls.Add(this.dDATAINDateTimePicker);
            this.panel2.Controls.Add(dDATAOUTLabel);
            this.panel2.Controls.Add(this.dDATAOUTDateTimePicker);
            this.panel2.Controls.Add(this.nIDQUARTOTextBox);
            this.panel2.Controls.Add(this.nIDCLIENTETextBox);
            this.panel2.Controls.Add(this.btnBuscaQuarto);
            this.panel2.Controls.Add(this.btnBuscaCliente);
            this.panel2.Controls.Add(nIDCLIENTELabel);
            this.panel2.Controls.Add(dDATAINLabel);
            this.panel2.Controls.Add(nIDQUARTOLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 403);
            this.panel2.TabIndex = 15;
            // 
            // txtDescQuarto
            // 
            this.txtDescQuarto.Enabled = false;
            this.txtDescQuarto.Location = new System.Drawing.Point(302, 205);
            this.txtDescQuarto.Name = "txtDescQuarto";
            this.txtDescQuarto.Size = new System.Drawing.Size(270, 23);
            this.txtDescQuarto.TabIndex = 31;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(302, 67);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(272, 23);
            this.txtNomeCliente.TabIndex = 30;
            // 
            // nDIARIASNumericUpDown
            // 
            this.nDIARIASNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "NDIARIAS", true));
            this.nDIARIASNumericUpDown.Location = new System.Drawing.Point(228, 135);
            this.nDIARIASNumericUpDown.Name = "nDIARIASNumericUpDown";
            this.nDIARIASNumericUpDown.Size = new System.Drawing.Size(202, 23);
            this.nDIARIASNumericUpDown.TabIndex = 5;
            this.nDIARIASNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nDIARIASNumericUpDown.ValueChanged += new System.EventHandler(this.nDIARIASNumericUpDown_ValueChanged);
            // 
            // dDATAINDateTimePicker
            // 
            this.dDATAINDateTimePicker.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dDATAINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "DDATAIN", true));
            this.dDATAINDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDATAINDateTimePicker.Location = new System.Drawing.Point(228, 100);
            this.dDATAINDateTimePicker.Name = "dDATAINDateTimePicker";
            this.dDATAINDateTimePicker.Size = new System.Drawing.Size(202, 23);
            this.dDATAINDateTimePicker.TabIndex = 6;
            // 
            // dDATAOUTDateTimePicker
            // 
            this.dDATAOUTDateTimePicker.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dDATAOUTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "DDATAOUT", true));
            this.dDATAOUTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDATAOUTDateTimePicker.Location = new System.Drawing.Point(228, 169);
            this.dDATAOUTDateTimePicker.Name = "dDATAOUTDateTimePicker";
            this.dDATAOUTDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dDATAOUTDateTimePicker.TabIndex = 7;
            // 
            // nIDQUARTOTextBox
            // 
            this.nIDQUARTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "NIDQUARTO", true));
            this.nIDQUARTOTextBox.Enabled = false;
            this.nIDQUARTOTextBox.Location = new System.Drawing.Point(228, 205);
            this.nIDQUARTOTextBox.Name = "nIDQUARTOTextBox";
            this.nIDQUARTOTextBox.Size = new System.Drawing.Size(68, 23);
            this.nIDQUARTOTextBox.TabIndex = 26;
            // 
            // nIDCLIENTETextBox
            // 
            this.nIDCLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "NIDCLIENTE", true));
            this.nIDCLIENTETextBox.Enabled = false;
            this.nIDCLIENTETextBox.Location = new System.Drawing.Point(228, 67);
            this.nIDCLIENTETextBox.Name = "nIDCLIENTETextBox";
            this.nIDCLIENTETextBox.Size = new System.Drawing.Size(68, 23);
            this.nIDCLIENTETextBox.TabIndex = 25;
            // 
            // btnBuscaQuarto
            // 
            this.btnBuscaQuarto.Image = global::HotelGestor.Properties.Resources.Search16x16;
            this.btnBuscaQuarto.Location = new System.Drawing.Point(577, 201);
            this.btnBuscaQuarto.Name = "btnBuscaQuarto";
            this.btnBuscaQuarto.Size = new System.Drawing.Size(33, 32);
            this.btnBuscaQuarto.TabIndex = 8;
            this.btnBuscaQuarto.UseVisualStyleBackColor = true;
            this.btnBuscaQuarto.Click += new System.EventHandler(this.btnBuscaQuarto_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = global::HotelGestor.Properties.Resources.Search16x16;
            this.btnBuscaCliente.Location = new System.Drawing.Point(577, 63);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(33, 30);
            this.btnBuscaCliente.TabIndex = 4;
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // tabConsumo
            // 
            this.tabConsumo.AutoScroll = true;
            this.tabConsumo.Controls.Add(this.panelCadItens);
            this.tabConsumo.Controls.Add(this.panel4);
            this.tabConsumo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConsumo.Location = new System.Drawing.Point(4, 27);
            this.tabConsumo.Name = "tabConsumo";
            this.tabConsumo.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsumo.Size = new System.Drawing.Size(762, 409);
            this.tabConsumo.TabIndex = 1;
            this.tabConsumo.Text = "Consumo";
            this.tabConsumo.UseVisualStyleBackColor = true;
            // 
            // panelCadItens
            // 
            this.panelCadItens.AutoScroll = true;
            this.panelCadItens.BackColor = System.Drawing.Color.Silver;
            this.panelCadItens.Controls.Add(this.nvalortotalTextBox);
            this.panelCadItens.Controls.Add(this.nqtditemNumericUpDown);
            this.panelCadItens.Controls.Add(this.txtDescricaoitem);
            this.panelCadItens.Controls.Add(this.btnBuscaItem);
            this.panelCadItens.Controls.Add(this.btnRegistraConsumo);
            this.panelCadItens.Controls.Add(nVALORBRUTOLabel);
            this.panelCadItens.Controls.Add(nQUANTIDADELabel);
            this.panelCadItens.Controls.Add(nIDITEMCONSUMOLabel);
            this.panelCadItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadItens.Enabled = false;
            this.panelCadItens.Location = new System.Drawing.Point(473, 3);
            this.panelCadItens.Name = "panelCadItens";
            this.panelCadItens.Size = new System.Drawing.Size(286, 403);
            this.panelCadItens.TabIndex = 10;
            // 
            // nvalortotalTextBox
            // 
            this.nvalortotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaXItensBindingSource, "nvalortotal", true));
            this.nvalortotalTextBox.Location = new System.Drawing.Point(90, 107);
            this.nvalortotalTextBox.Name = "nvalortotalTextBox";
            this.nvalortotalTextBox.ReadOnly = true;
            this.nvalortotalTextBox.Size = new System.Drawing.Size(191, 23);
            this.nvalortotalTextBox.TabIndex = 2;
            // 
            // faturaXItensBindingSource
            // 
            this.faturaXItensBindingSource.DataMember = "FaturaXItens";
            this.faturaXItensBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // nqtditemNumericUpDown
            // 
            this.nqtditemNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.faturaXItensBindingSource, "nqtditem", true));
            this.nqtditemNumericUpDown.Location = new System.Drawing.Point(90, 68);
            this.nqtditemNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nqtditemNumericUpDown.Name = "nqtditemNumericUpDown";
            this.nqtditemNumericUpDown.Size = new System.Drawing.Size(191, 23);
            this.nqtditemNumericUpDown.TabIndex = 1;
            this.nqtditemNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nqtditemNumericUpDown.ValueChanged += new System.EventHandler(this.nqtditemNumericUpDown_ValueChanged);
            // 
            // txtDescricaoitem
            // 
            this.txtDescricaoitem.Enabled = false;
            this.txtDescricaoitem.Location = new System.Drawing.Point(90, 33);
            this.txtDescricaoitem.Name = "txtDescricaoitem";
            this.txtDescricaoitem.Size = new System.Drawing.Size(157, 23);
            this.txtDescricaoitem.TabIndex = 17;
            // 
            // btnBuscaItem
            // 
            this.btnBuscaItem.Image = global::HotelGestor.Properties.Resources.Search16x16___Copia;
            this.btnBuscaItem.Location = new System.Drawing.Point(253, 31);
            this.btnBuscaItem.Name = "btnBuscaItem";
            this.btnBuscaItem.Size = new System.Drawing.Size(28, 25);
            this.btnBuscaItem.TabIndex = 0;
            this.btnBuscaItem.UseVisualStyleBackColor = true;
            this.btnBuscaItem.Click += new System.EventHandler(this.btnBuscaItem_Click);
            // 
            // btnRegistraConsumo
            // 
            this.btnRegistraConsumo.Image = global::HotelGestor.Properties.Resources.comprar;
            this.btnRegistraConsumo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistraConsumo.Location = new System.Drawing.Point(156, 136);
            this.btnRegistraConsumo.Name = "btnRegistraConsumo";
            this.btnRegistraConsumo.Size = new System.Drawing.Size(125, 62);
            this.btnRegistraConsumo.TabIndex = 3;
            this.btnRegistraConsumo.Text = "Registrar";
            this.btnRegistraConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistraConsumo.UseVisualStyleBackColor = true;
            this.btnRegistraConsumo.Click += new System.EventHandler(this.btnRegistraConsumo_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 403);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDESCRICAO,
            this.nqtditem,
            this.nvalorunit,
            this.nvalortotal,
            this.ddatamovim,
            this.nidfaturaDataGridViewTextBoxColumn,
            this.niditemDataGridViewTextBoxColumn,
            this.nqtditemDataGridViewTextBoxColumn,
            this.nvalorunitDataGridViewTextBoxColumn,
            this.nvalortotalDataGridViewTextBoxColumn,
            this.ddatamovimDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.faturaXItensBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(466, 314);
            this.dataGridView2.TabIndex = 11;
            // 
            // CDESCRICAO
            // 
            this.CDESCRICAO.DataPropertyName = "CDESCRICAO";
            this.CDESCRICAO.HeaderText = "Item";
            this.CDESCRICAO.Name = "CDESCRICAO";
            this.CDESCRICAO.ReadOnly = true;
            // 
            // nqtditem
            // 
            this.nqtditem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nqtditem.DataPropertyName = "nqtditem";
            this.nqtditem.HeaderText = "Qtd";
            this.nqtditem.Name = "nqtditem";
            this.nqtditem.ReadOnly = true;
            this.nqtditem.Width = 54;
            // 
            // nvalorunit
            // 
            this.nvalorunit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nvalorunit.DataPropertyName = "nvalorunit";
            this.nvalorunit.HeaderText = "Valor";
            this.nvalorunit.Name = "nvalorunit";
            this.nvalorunit.ReadOnly = true;
            this.nvalorunit.Width = 61;
            // 
            // nvalortotal
            // 
            this.nvalortotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nvalortotal.DataPropertyName = "nvalortotal";
            this.nvalortotal.HeaderText = "Vlr. Total";
            this.nvalortotal.Name = "nvalortotal";
            this.nvalortotal.ReadOnly = true;
            this.nvalortotal.Width = 83;
            // 
            // ddatamovim
            // 
            this.ddatamovim.DataPropertyName = "ddatamovim";
            this.ddatamovim.HeaderText = "Lançamento";
            this.ddatamovim.Name = "ddatamovim";
            this.ddatamovim.ReadOnly = true;
            this.ddatamovim.Width = 150;
            // 
            // nidfaturaDataGridViewTextBoxColumn
            // 
            this.nidfaturaDataGridViewTextBoxColumn.DataPropertyName = "nidfatura";
            this.nidfaturaDataGridViewTextBoxColumn.HeaderText = "nidfatura";
            this.nidfaturaDataGridViewTextBoxColumn.Name = "nidfaturaDataGridViewTextBoxColumn";
            this.nidfaturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // niditemDataGridViewTextBoxColumn
            // 
            this.niditemDataGridViewTextBoxColumn.DataPropertyName = "niditem";
            this.niditemDataGridViewTextBoxColumn.HeaderText = "niditem";
            this.niditemDataGridViewTextBoxColumn.Name = "niditemDataGridViewTextBoxColumn";
            this.niditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nqtditemDataGridViewTextBoxColumn
            // 
            this.nqtditemDataGridViewTextBoxColumn.DataPropertyName = "nqtditem";
            this.nqtditemDataGridViewTextBoxColumn.HeaderText = "nqtditem";
            this.nqtditemDataGridViewTextBoxColumn.Name = "nqtditemDataGridViewTextBoxColumn";
            this.nqtditemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nvalorunitDataGridViewTextBoxColumn
            // 
            this.nvalorunitDataGridViewTextBoxColumn.DataPropertyName = "nvalorunit";
            this.nvalorunitDataGridViewTextBoxColumn.HeaderText = "nvalorunit";
            this.nvalorunitDataGridViewTextBoxColumn.Name = "nvalorunitDataGridViewTextBoxColumn";
            this.nvalorunitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nvalortotalDataGridViewTextBoxColumn
            // 
            this.nvalortotalDataGridViewTextBoxColumn.DataPropertyName = "nvalortotal";
            this.nvalortotalDataGridViewTextBoxColumn.HeaderText = "nvalortotal";
            this.nvalortotalDataGridViewTextBoxColumn.Name = "nvalortotalDataGridViewTextBoxColumn";
            this.nvalortotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ddatamovimDataGridViewTextBoxColumn
            // 
            this.ddatamovimDataGridViewTextBoxColumn.DataPropertyName = "ddatamovim";
            this.ddatamovimDataGridViewTextBoxColumn.HeaderText = "ddatamovim";
            this.ddatamovimDataGridViewTextBoxColumn.Name = "ddatamovimDataGridViewTextBoxColumn";
            this.ddatamovimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PowderBlue;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarItem);
            this.panel9.Controls.Add(this.btnExcluirItem);
            this.panel9.Controls.Add(this.btnAddItem);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(466, 44);
            this.panel9.TabIndex = 10;
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelarItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelarItem.FlatAppearance.BorderSize = 0;
            this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarItem.Image = global::HotelGestor.Properties.Resources.Cancel16x16___Copia;
            this.btnCancelarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarItem.Location = new System.Drawing.Point(142, 0);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(71, 42);
            this.btnCancelarItem.TabIndex = 6;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluirItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirItem.FlatAppearance.BorderSize = 0;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.Image = global::HotelGestor.Properties.Resources.delete16x16;
            this.btnExcluirItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluirItem.Location = new System.Drawing.Point(71, 0);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(71, 42);
            this.btnExcluirItem.TabIndex = 5;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Image = global::HotelGestor.Properties.Resources.Add16x16___Copia;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddItem.Location = new System.Drawing.Point(0, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(71, 42);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Incluir";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbTotalLancamentos);
            this.panel5.Controls.Add(this.lbtot);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 358);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 41);
            this.panel5.TabIndex = 2;
            // 
            // lbTotalLancamentos
            // 
            this.lbTotalLancamentos.AutoSize = true;
            this.lbTotalLancamentos.BackColor = System.Drawing.Color.White;
            this.lbTotalLancamentos.Location = new System.Drawing.Point(346, 10);
            this.lbTotalLancamentos.Name = "lbTotalLancamentos";
            this.lbTotalLancamentos.Size = new System.Drawing.Size(34, 18);
            this.lbTotalLancamentos.TabIndex = 1;
            this.lbTotalLancamentos.Text = "0,00";
            // 
            // lbtot
            // 
            this.lbtot.AutoSize = true;
            this.lbtot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbtot.Location = new System.Drawing.Point(295, 10);
            this.lbtot.Name = "lbtot";
            this.lbtot.Size = new System.Drawing.Size(45, 18);
            this.lbtot.TabIndex = 0;
            this.lbtot.Text = "Total :";
            // 
            // tabCheckOut
            // 
            this.tabCheckOut.Controls.Add(this.pnCheckout);
            this.tabCheckOut.Controls.Add(this.panel6);
            this.tabCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCheckOut.Location = new System.Drawing.Point(4, 27);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckOut.Size = new System.Drawing.Size(762, 409);
            this.tabCheckOut.TabIndex = 2;
            this.tabCheckOut.Text = "Check-out";
            this.tabCheckOut.UseVisualStyleBackColor = true;
            // 
            // pnCheckout
            // 
            this.pnCheckout.AutoScroll = true;
            this.pnCheckout.Controls.Add(this.nvalottotalTextBox);
            this.pnCheckout.Controls.Add(this.ncontroleNumericUpDown);
            this.pnCheckout.Controls.Add(this.lbTotalDiarias);
            this.pnCheckout.Controls.Add(label6);
            this.pnCheckout.Controls.Add(this.lbVlDiaria);
            this.pnCheckout.Controls.Add(this.lbdiarias);
            this.pnCheckout.Controls.Add(ncontroleLabel);
            this.pnCheckout.Controls.Add(this.cobservacaoTextBox);
            this.pnCheckout.Controls.Add(this.ndescontoTextBox);
            this.pnCheckout.Controls.Add(nVALORBASELabel);
            this.pnCheckout.Controls.Add(this.lbConsumo);
            this.pnCheckout.Controls.Add(this.label4);
            this.pnCheckout.Controls.Add(this.label2);
            this.pnCheckout.Controls.Add(vVALORDESCONTOLabel);
            this.pnCheckout.Controls.Add(vVALORTOTALLabel);
            this.pnCheckout.Controls.Add(fFORMAPAGAMENTOLabel);
            this.pnCheckout.Controls.Add(this.fFORMAPAGAMENTOComboBox);
            this.pnCheckout.Controls.Add(cOBSERVACAOLabel);
            this.pnCheckout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCheckout.Location = new System.Drawing.Point(3, 3);
            this.pnCheckout.Name = "pnCheckout";
            this.pnCheckout.Size = new System.Drawing.Size(756, 307);
            this.pnCheckout.TabIndex = 28;
            // 
            // nvalottotalTextBox
            // 
            this.nvalottotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaBindingSource, "nvalottotal", true));
            this.nvalottotalTextBox.Location = new System.Drawing.Point(213, 176);
            this.nvalottotalTextBox.Name = "nvalottotalTextBox";
            this.nvalottotalTextBox.ReadOnly = true;
            this.nvalottotalTextBox.Size = new System.Drawing.Size(189, 23);
            this.nvalottotalTextBox.TabIndex = 51;
            this.nvalottotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nvalottotalTextBox.TextChanged += new System.EventHandler(this.nvalottotalTextBox_TextChanged_1);
            // 
            // faturaBindingSource
            // 
            this.faturaBindingSource.DataMember = "fatura";
            this.faturaBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // ncontroleNumericUpDown
            // 
            this.ncontroleNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.faturaBindingSource, "ncontrole", true));
            this.ncontroleNumericUpDown.Location = new System.Drawing.Point(213, 11);
            this.ncontroleNumericUpDown.Name = "ncontroleNumericUpDown";
            this.ncontroleNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.ncontroleNumericUpDown.TabIndex = 48;
            // 
            // lbTotalDiarias
            // 
            this.lbTotalDiarias.AutoSize = true;
            this.lbTotalDiarias.Location = new System.Drawing.Point(475, 124);
            this.lbTotalDiarias.Name = "lbTotalDiarias";
            this.lbTotalDiarias.Size = new System.Drawing.Size(34, 18);
            this.lbTotalDiarias.TabIndex = 47;
            this.lbTotalDiarias.Text = "0,00";
            // 
            // lbVlDiaria
            // 
            this.lbVlDiaria.AutoSize = true;
            this.lbVlDiaria.Location = new System.Drawing.Point(232, 124);
            this.lbVlDiaria.Name = "lbVlDiaria";
            this.lbVlDiaria.Size = new System.Drawing.Size(34, 18);
            this.lbVlDiaria.TabIndex = 45;
            this.lbVlDiaria.Text = "0,00";
            // 
            // lbdiarias
            // 
            this.lbdiarias.AutoSize = true;
            this.lbdiarias.Location = new System.Drawing.Point(213, 101);
            this.lbdiarias.Name = "lbdiarias";
            this.lbdiarias.Size = new System.Drawing.Size(15, 18);
            this.lbdiarias.TabIndex = 44;
            this.lbdiarias.Text = "0";
            // 
            // cobservacaoTextBox
            // 
            this.cobservacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaBindingSource, "cobservacao", true));
            this.cobservacaoTextBox.Location = new System.Drawing.Point(213, 205);
            this.cobservacaoTextBox.Multiline = true;
            this.cobservacaoTextBox.Name = "cobservacaoTextBox";
            this.cobservacaoTextBox.Size = new System.Drawing.Size(344, 86);
            this.cobservacaoTextBox.TabIndex = 42;
            // 
            // ndescontoTextBox
            // 
            this.ndescontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.faturaBindingSource, "ndesconto", true));
            this.ndescontoTextBox.Location = new System.Drawing.Point(213, 146);
            this.ndescontoTextBox.Name = "ndescontoTextBox";
            this.ndescontoTextBox.Size = new System.Drawing.Size(188, 23);
            this.ndescontoTextBox.TabIndex = 40;
            this.ndescontoTextBox.Text = "0,00";
            this.ndescontoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndescontoTextBox.Click += new System.EventHandler(this.ndescontoTextBox_Click);
            this.ndescontoTextBox.TextChanged += new System.EventHandler(this.ndescontoTextBox_TextChanged);
            this.ndescontoTextBox.Leave += new System.EventHandler(this.ndescontoTextBox_Leave);
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Location = new System.Drawing.Point(213, 78);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(34, 18);
            this.lbConsumo.TabIndex = 37;
            this.lbConsumo.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total Consumo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Diarias:";
            // 
            // fFORMAPAGAMENTOComboBox
            // 
            this.fFORMAPAGAMENTOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.faturaBindingSource, "nformapag", true));
            this.fFORMAPAGAMENTOComboBox.DataSource = this.fORMASDEPAGAMENTOBindingSource;
            this.fFORMAPAGAMENTOComboBox.DisplayMember = "CDESCRICAO";
            this.fFORMAPAGAMENTOComboBox.FormattingEnabled = true;
            this.fFORMAPAGAMENTOComboBox.Location = new System.Drawing.Point(213, 42);
            this.fFORMAPAGAMENTOComboBox.Name = "fFORMAPAGAMENTOComboBox";
            this.fFORMAPAGAMENTOComboBox.Size = new System.Drawing.Size(345, 26);
            this.fFORMAPAGAMENTOComboBox.TabIndex = 30;
            this.fFORMAPAGAMENTOComboBox.ValueMember = "NIDPAGFORM";
            // 
            // fORMASDEPAGAMENTOBindingSource
            // 
            this.fORMASDEPAGAMENTOBindingSource.DataMember = "FORMASDEPAGAMENTO";
            this.fORMASDEPAGAMENTOBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnEncerrar);
            this.panel6.Controls.Add(this.btnFatura);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 310);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 96);
            this.panel6.TabIndex = 26;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.Image = global::HotelGestor.Properties.Resources.aberto;
            this.btnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncerrar.Location = new System.Drawing.Point(395, 5);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(162, 73);
            this.btnEncerrar.TabIndex = 1;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.Image = global::HotelGestor.Properties.Resources.pagamento;
            this.btnFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFatura.Location = new System.Drawing.Point(212, 5);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(149, 73);
            this.btnFatura.TabIndex = 0;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // hOSPEDAGEMTableAdapter
            // 
            this.hOSPEDAGEMTableAdapter.ClearBeforeFill = true;
            // 
            // fORMASDEPAGAMENTOTableAdapter
            // 
            this.fORMASDEPAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // faturaXItensTableAdapter
            // 
            this.faturaXItensTableAdapter.ClearBeforeFill = true;
            // 
            // faturaTableAdapter
            // 
            this.faturaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATORESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.faturaTableAdapter = this.faturaTableAdapter;
            this.tableAdapterManager.FaturaXItensTableAdapter = this.faturaXItensTableAdapter;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = this.fORMASDEPAGAMENTOTableAdapter;
            this.tableAdapterManager.HOSPEDAGEMTableAdapter = this.hOSPEDAGEMTableAdapter;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // qUARTOBindingSource
            // 
            this.qUARTOBindingSource.DataMember = "QUARTO";
            this.qUARTOBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // qUARTOTableAdapter
            // 
            this.qUARTOTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Saida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Data Entrada:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome Hóspede:";
            // 
            // button1
            // 
            this.button1.Image = global::HotelGestor.Properties.Resources.Search32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(428, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFiletroDataOut
            // 
            this.txtFiletroDataOut.Location = new System.Drawing.Point(322, 47);
            this.txtFiletroDataOut.Mask = "00/00/0000";
            this.txtFiletroDataOut.Name = "txtFiletroDataOut";
            this.txtFiletroDataOut.Size = new System.Drawing.Size(100, 23);
            this.txtFiletroDataOut.TabIndex = 15;
            this.txtFiletroDataOut.ValidatingType = typeof(System.DateTime);
            // 
            // txtFiltroDataIn
            // 
            this.txtFiltroDataIn.Location = new System.Drawing.Point(167, 47);
            this.txtFiltroDataIn.Mask = "00/00/0000";
            this.txtFiltroDataIn.Name = "txtFiltroDataIn";
            this.txtFiltroDataIn.Size = new System.Drawing.Size(100, 23);
            this.txtFiltroDataIn.TabIndex = 14;
            this.txtFiltroDataIn.ValidatingType = typeof(System.DateTime);
            // 
            // txtFiltroHospede
            // 
            this.txtFiltroHospede.Location = new System.Drawing.Point(167, 15);
            this.txtFiltroHospede.Name = "txtFiltroHospede";
            this.txtFiltroHospede.Size = new System.Drawing.Size(407, 23);
            this.txtFiltroHospede.TabIndex = 13;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // chHospAbertas
            // 
            this.chHospAbertas.AutoSize = true;
            this.chHospAbertas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chHospAbertas.Location = new System.Drawing.Point(167, 85);
            this.chHospAbertas.Name = "chHospAbertas";
            this.chHospAbertas.Size = new System.Drawing.Size(152, 22);
            this.chHospAbertas.TabIndex = 22;
            this.chHospAbertas.Text = "Hospedagens Abertas";
            this.chHospAbertas.UseVisualStyleBackColor = true;
            // 
            // frmHospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmHospedagem";
            this.Text = "Hospedagem";
            this.Load += new System.EventHandler(this.frmHospedagem_Load);
            this.panel1.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.tbHospedagem.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown)).EndInit();
            this.tabConsumo.ResumeLayout(false);
            this.panelCadItens.ResumeLayout(false);
            this.panelCadItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturaXItensBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nqtditemNumericUpDown)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabCheckOut.ResumeLayout(false);
            this.pnCheckout.ResumeLayout(false);
            this.pnCheckout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncontroleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASDEPAGAMENTOBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qUARTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource hOSPEDAGEMBindingSource;
        private HotelDBDataSetTableAdapters.HOSPEDAGEMTableAdapter hOSPEDAGEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESC_QUARTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NDIARIAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VVALORTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDATAIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDATAOUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDHOSPEDAGEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIDQUARTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAOUTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cESTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOBSERVACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fFORMAPAGAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vVALORTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vVALORDESCONTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAFECHAMENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDIARIASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCQUARTODataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tbHospedagem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarHospedagem;
        private System.Windows.Forms.Button btnHospedar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDescQuarto;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.NumericUpDown nDIARIASNumericUpDown;
        private System.Windows.Forms.DateTimePicker dDATAINDateTimePicker;
        private System.Windows.Forms.DateTimePicker dDATAOUTDateTimePicker;
        private System.Windows.Forms.TextBox nIDQUARTOTextBox;
        private System.Windows.Forms.TextBox nIDCLIENTETextBox;
        private System.Windows.Forms.Button btnBuscaQuarto;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TabPage tabConsumo;
        private System.Windows.Forms.Panel panelCadItens;
        private System.Windows.Forms.TextBox txtDescricaoitem;
        private System.Windows.Forms.Button btnBuscaItem;
        private System.Windows.Forms.Button btnRegistraConsumo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTotalLancamentos;
        private System.Windows.Forms.Label lbtot;
        private System.Windows.Forms.TabPage tabCheckOut;
        private System.Windows.Forms.Panel pnCheckout;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fFORMAPAGAMENTOComboBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.BindingSource fORMASDEPAGAMENTOBindingSource;
        private HotelDBDataSetTableAdapters.FORMASDEPAGAMENTOTableAdapter fORMASDEPAGAMENTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCQUARTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vVALORTOTALDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAFECHAMENTODataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource faturaXItensBindingSource;
        private HotelDBDataSetTableAdapters.FaturaXItensTableAdapter faturaXItensTableAdapter;
        private System.Windows.Forms.BindingSource faturaBindingSource;
        private HotelDBDataSetTableAdapters.faturaTableAdapter faturaTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nvalortotalTextBox;
        private System.Windows.Forms.NumericUpDown nqtditemNumericUpDown;
        private System.Windows.Forms.Label lbTotalDiarias;
        private System.Windows.Forms.Label lbVlDiaria;
        private System.Windows.Forms.Label lbdiarias;
        private System.Windows.Forms.TextBox cobservacaoTextBox;
        private System.Windows.Forms.TextBox ndescontoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn nqtditem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvalorunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvalortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddatamovim;
        private System.Windows.Forms.DataGridViewTextBoxColumn nidfaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn niditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nqtditemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvalorunitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvalortotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ddatamovimDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown ncontroleNumericUpDown;
        private System.Windows.Forms.TextBox nvalottotalTextBox;
        private System.Windows.Forms.BindingSource qUARTOBindingSource;
        private HotelDBDataSetTableAdapters.QUARTOTableAdapter qUARTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOSPEDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUARTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAINDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATAOUTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDIARIASDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtFiletroDataOut;
        private System.Windows.Forms.MaskedTextBox txtFiltroDataIn;
        private System.Windows.Forms.TextBox txtFiltroHospede;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDBDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.CheckBox chHospAbertas;
    }
}
