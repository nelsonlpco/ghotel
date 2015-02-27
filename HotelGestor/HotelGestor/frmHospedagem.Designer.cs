namespace HotelGestor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.hOSPEDAGEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.hOSPEDAGEMTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.HOSPEDAGEMTableAdapter();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarHospedagem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.txtDescricaoitem = new System.Windows.Forms.TextBox();
            this.btnBuscaItem = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.nVALORBRUTONumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nQUANTIDADENumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DDATAHORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtot = new System.Windows.Forms.Label();
            this.tabCheckOut = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.nVALORBASENumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nDIARIASNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbConsumo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vVALORDESCONTONumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.vVALORTOTALNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fFORMAPAGAMENTOComboBox = new System.Windows.Forms.ComboBox();
            this.cOBSERVACAOTextBox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
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
            this.tbMain.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown)).BeginInit();
            this.tabConsumo.SuspendLayout();
            this.panelCadItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBRUTONumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQUANTIDADENumericUpDown)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabCheckOut.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBASENumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVALORDESCONTONumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVALORTOTALNumericUpDown)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.dataGridView1);
            this.tbCadastro.Controls.SetChildIndex(this.pnFiltros, 0);
            this.tbCadastro.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.tabControl2);
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
            // nDIARIASLabel
            // 
            nDIARIASLabel.AutoSize = true;
            nDIARIASLabel.Location = new System.Drawing.Point(392, 110);
            nDIARIASLabel.Name = "nDIARIASLabel";
            nDIARIASLabel.Size = new System.Drawing.Size(54, 18);
            nDIARIASLabel.TabIndex = 28;
            nDIARIASLabel.Text = "Diarias:";
            // 
            // dDATAOUTLabel
            // 
            dDATAOUTLabel.AutoSize = true;
            dDATAOUTLabel.Location = new System.Drawing.Point(27, 156);
            dDATAOUTLabel.Name = "dDATAOUTLabel";
            dDATAOUTLabel.Size = new System.Drawing.Size(136, 18);
            dDATAOUTLabel.TabIndex = 26;
            dDATAOUTLabel.Text = "Data e Hora da saida:";
            // 
            // nIDCLIENTELabel
            // 
            nIDCLIENTELabel.AutoSize = true;
            nIDCLIENTELabel.Location = new System.Drawing.Point(110, 18);
            nIDCLIENTELabel.Name = "nIDCLIENTELabel";
            nIDCLIENTELabel.Size = new System.Drawing.Size(54, 18);
            nIDCLIENTELabel.TabIndex = 19;
            nIDCLIENTELabel.Text = "Cliente:";
            // 
            // dDATAINLabel
            // 
            dDATAINLabel.AutoSize = true;
            dDATAINLabel.Location = new System.Drawing.Point(13, 110);
            dDATAINLabel.Name = "dDATAINLabel";
            dDATAINLabel.Size = new System.Drawing.Size(150, 18);
            dDATAINLabel.TabIndex = 16;
            dDATAINLabel.Text = "Data e Hora da Entrada:";
            // 
            // nIDQUARTOLabel
            // 
            nIDQUARTOLabel.AutoSize = true;
            nIDQUARTOLabel.Location = new System.Drawing.Point(110, 67);
            nIDQUARTOLabel.Name = "nIDQUARTOLabel";
            nIDQUARTOLabel.Size = new System.Drawing.Size(53, 18);
            nIDQUARTOLabel.TabIndex = 15;
            nIDQUARTOLabel.Text = "Quarto:";
            // 
            // nVALORBRUTOLabel
            // 
            nVALORBRUTOLabel.AutoSize = true;
            nVALORBRUTOLabel.Location = new System.Drawing.Point(12, 126);
            nVALORBRUTOLabel.Name = "nVALORBRUTOLabel";
            nVALORBRUTOLabel.Size = new System.Drawing.Size(72, 18);
            nVALORBRUTOLabel.TabIndex = 13;
            nVALORBRUTOLabel.Text = "Valor total:";
            // 
            // nQUANTIDADELabel
            // 
            nQUANTIDADELabel.AutoSize = true;
            nQUANTIDADELabel.Location = new System.Drawing.Point(4, 67);
            nQUANTIDADELabel.Name = "nQUANTIDADELabel";
            nQUANTIDADELabel.Size = new System.Drawing.Size(80, 18);
            nQUANTIDADELabel.TabIndex = 11;
            nQUANTIDADELabel.Text = "Quantidade:";
            // 
            // nIDITEMCONSUMOLabel
            // 
            nIDITEMCONSUMOLabel.AutoSize = true;
            nIDITEMCONSUMOLabel.Location = new System.Drawing.Point(44, 17);
            nIDITEMCONSUMOLabel.Name = "nIDITEMCONSUMOLabel";
            nIDITEMCONSUMOLabel.Size = new System.Drawing.Size(40, 18);
            nIDITEMCONSUMOLabel.TabIndex = 10;
            nIDITEMCONSUMOLabel.Text = "Item:";
            // 
            // nVALORBASELabel
            // 
            nVALORBASELabel.AutoSize = true;
            nVALORBASELabel.Location = new System.Drawing.Point(84, 142);
            nVALORBASELabel.Name = "nVALORBASELabel";
            nVALORBASELabel.Size = new System.Drawing.Size(97, 18);
            nVALORBASELabel.TabIndex = 38;
            nVALORBASELabel.Text = "Valor da diaria:";
            // 
            // vVALORDESCONTOLabel
            // 
            vVALORDESCONTOLabel.AutoSize = true;
            vVALORDESCONTOLabel.Location = new System.Drawing.Point(112, 167);
            vVALORDESCONTOLabel.Name = "vVALORDESCONTOLabel";
            vVALORDESCONTOLabel.Size = new System.Drawing.Size(66, 18);
            vVALORDESCONTOLabel.TabIndex = 31;
            vVALORDESCONTOLabel.Text = "Desconto:";
            // 
            // vVALORTOTALLabel
            // 
            vVALORTOTALLabel.AutoSize = true;
            vVALORTOTALLabel.Location = new System.Drawing.Point(105, 193);
            vVALORTOTALLabel.Name = "vVALORTOTALLabel";
            vVALORTOTALLabel.Size = new System.Drawing.Size(73, 18);
            vVALORTOTALLabel.TabIndex = 29;
            vVALORTOTALLabel.Text = "Valor Total:";
            // 
            // fFORMAPAGAMENTOLabel
            // 
            fFORMAPAGAMENTOLabel.AutoSize = true;
            fFORMAPAGAMENTOLabel.Location = new System.Drawing.Point(42, 26);
            fFORMAPAGAMENTOLabel.Name = "fFORMAPAGAMENTOLabel";
            fFORMAPAGAMENTOLabel.Size = new System.Drawing.Size(136, 18);
            fFORMAPAGAMENTOLabel.TabIndex = 27;
            fFORMAPAGAMENTOLabel.Text = "Forma de Pagamento:";
            // 
            // cOBSERVACAOLabel
            // 
            cOBSERVACAOLabel.AutoSize = true;
            cOBSERVACAOLabel.Location = new System.Drawing.Point(100, 220);
            cOBSERVACAOLabel.Name = "cOBSERVACAOLabel";
            cOBSERVACAOLabel.Size = new System.Drawing.Size(81, 18);
            cOBSERVACAOLabel.TabIndex = 26;
            cOBSERVACAOLabel.Text = "Observação:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DESC_QUARTO,
            this.CNOME,
            this.NDIARIAS,
            this.VVALORTOTAL,
            this.DDATAIN,
            this.DDATAOUT,
            this.nIDHOSPEDAGEMDataGridViewTextBoxColumn,
            this.nIDCLIENTEDataGridViewTextBoxColumn,
            this.nIDQUARTODataGridViewTextBoxColumn,
            this.dDATAINDataGridViewTextBoxColumn,
            this.dDATAOUTDataGridViewTextBoxColumn,
            this.cESTATUSDataGridViewTextBoxColumn,
            this.cOBSERVACAODataGridViewTextBoxColumn,
            this.fFORMAPAGAMENTODataGridViewTextBoxColumn,
            this.vVALORTOTALDataGridViewTextBoxColumn,
            this.vVALORDESCONTODataGridViewTextBoxColumn,
            this.dDATAFECHAMENTODataGridViewTextBoxColumn,
            this.nDIARIASDataGridViewTextBoxColumn,
            this.cNOMEDataGridViewTextBoxColumn,
            this.dESCQUARTODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hOSPEDAGEMBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 343);
            this.dataGridView1.TabIndex = 1;
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
            // hOSPEDAGEMTableAdapter
            // 
            this.hOSPEDAGEMTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabConsumo);
            this.tabControl2.Controls.Add(this.tabCheckOut);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(770, 430);
            this.tabControl2.TabIndex = 1;
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
            this.tabPage3.Size = new System.Drawing.Size(762, 399);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Check-in";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEditarHospedagem);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(756, 112);
            this.panel3.TabIndex = 16;
            // 
            // btnEditarHospedagem
            // 
            this.btnEditarHospedagem.Enabled = false;
            this.btnEditarHospedagem.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHospedagem.ForeColor = System.Drawing.Color.Black;
            this.btnEditarHospedagem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarHospedagem.Location = new System.Drawing.Point(262, 15);
            this.btnEditarHospedagem.Name = "btnEditarHospedagem";
            this.btnEditarHospedagem.Size = new System.Drawing.Size(230, 80);
            this.btnEditarHospedagem.TabIndex = 13;
            this.btnEditarHospedagem.Text = "Editar";
            this.btnEditarHospedagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarHospedagem.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(498, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 80);
            this.button3.TabIndex = 12;
            this.button3.Text = "Hospedar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(756, 393);
            this.panel2.TabIndex = 15;
            // 
            // txtDescQuarto
            // 
            this.txtDescQuarto.Enabled = false;
            this.txtDescQuarto.Location = new System.Drawing.Point(243, 64);
            this.txtDescQuarto.Name = "txtDescQuarto";
            this.txtDescQuarto.Size = new System.Drawing.Size(250, 23);
            this.txtDescQuarto.TabIndex = 31;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Location = new System.Drawing.Point(243, 13);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(250, 23);
            this.txtNomeCliente.TabIndex = 30;
            // 
            // nDIARIASNumericUpDown
            // 
            this.nDIARIASNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "NDIARIAS", true));
            this.nDIARIASNumericUpDown.Location = new System.Drawing.Point(452, 105);
            this.nDIARIASNumericUpDown.Name = "nDIARIASNumericUpDown";
            this.nDIARIASNumericUpDown.Size = new System.Drawing.Size(99, 23);
            this.nDIARIASNumericUpDown.TabIndex = 29;
            // 
            // dDATAINDateTimePicker
            // 
            this.dDATAINDateTimePicker.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dDATAINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "DDATAIN", true));
            this.dDATAINDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDATAINDateTimePicker.Location = new System.Drawing.Point(169, 105);
            this.dDATAINDateTimePicker.Name = "dDATAINDateTimePicker";
            this.dDATAINDateTimePicker.Size = new System.Drawing.Size(202, 23);
            this.dDATAINDateTimePicker.TabIndex = 28;
            // 
            // dDATAOUTDateTimePicker
            // 
            this.dDATAOUTDateTimePicker.CustomFormat = "dd/MM/yyyy - HH:mm:ss";
            this.dDATAOUTDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "DDATAOUT", true));
            this.dDATAOUTDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dDATAOUTDateTimePicker.Location = new System.Drawing.Point(171, 152);
            this.dDATAOUTDateTimePicker.Name = "dDATAOUTDateTimePicker";
            this.dDATAOUTDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dDATAOUTDateTimePicker.TabIndex = 27;
            // 
            // nIDQUARTOTextBox
            // 
            this.nIDQUARTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "NIDQUARTO", true));
            this.nIDQUARTOTextBox.Enabled = false;
            this.nIDQUARTOTextBox.Location = new System.Drawing.Point(169, 64);
            this.nIDQUARTOTextBox.Name = "nIDQUARTOTextBox";
            this.nIDQUARTOTextBox.Size = new System.Drawing.Size(68, 23);
            this.nIDQUARTOTextBox.TabIndex = 26;
            // 
            // nIDCLIENTETextBox
            // 
            this.nIDCLIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "NIDCLIENTE", true));
            this.nIDCLIENTETextBox.Enabled = false;
            this.nIDCLIENTETextBox.Location = new System.Drawing.Point(169, 13);
            this.nIDCLIENTETextBox.Name = "nIDCLIENTETextBox";
            this.nIDCLIENTETextBox.Size = new System.Drawing.Size(68, 23);
            this.nIDCLIENTETextBox.TabIndex = 25;
            // 
            // btnBuscaQuarto
            // 
            this.btnBuscaQuarto.Image = global::HotelGestor.Properties.Resources.Search32x32___Copia;
            this.btnBuscaQuarto.Location = new System.Drawing.Point(499, 51);
            this.btnBuscaQuarto.Name = "btnBuscaQuarto";
            this.btnBuscaQuarto.Size = new System.Drawing.Size(52, 40);
            this.btnBuscaQuarto.TabIndex = 22;
            this.btnBuscaQuarto.UseVisualStyleBackColor = true;
            this.btnBuscaQuarto.Click += new System.EventHandler(this.btnBuscaQuarto_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = global::HotelGestor.Properties.Resources.Search32x32___Copia;
            this.btnBuscaCliente.Location = new System.Drawing.Point(499, 5);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(52, 40);
            this.btnBuscaCliente.TabIndex = 21;
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
            this.tabConsumo.Size = new System.Drawing.Size(762, 399);
            this.tabConsumo.TabIndex = 1;
            this.tabConsumo.Text = "Consumo";
            this.tabConsumo.UseVisualStyleBackColor = true;
            // 
            // panelCadItens
            // 
            this.panelCadItens.BackColor = System.Drawing.Color.Silver;
            this.panelCadItens.Controls.Add(this.txtDescricaoitem);
            this.panelCadItens.Controls.Add(this.btnBuscaItem);
            this.panelCadItens.Controls.Add(this.button5);
            this.panelCadItens.Controls.Add(nVALORBRUTOLabel);
            this.panelCadItens.Controls.Add(this.nVALORBRUTONumericUpDown);
            this.panelCadItens.Controls.Add(nQUANTIDADELabel);
            this.panelCadItens.Controls.Add(this.nQUANTIDADENumericUpDown);
            this.panelCadItens.Controls.Add(nIDITEMCONSUMOLabel);
            this.panelCadItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadItens.Enabled = false;
            this.panelCadItens.Location = new System.Drawing.Point(473, 3);
            this.panelCadItens.Name = "panelCadItens";
            this.panelCadItens.Size = new System.Drawing.Size(286, 393);
            this.panelCadItens.TabIndex = 10;
            // 
            // txtDescricaoitem
            // 
            this.txtDescricaoitem.Enabled = false;
            this.txtDescricaoitem.Location = new System.Drawing.Point(90, 14);
            this.txtDescricaoitem.Name = "txtDescricaoitem";
            this.txtDescricaoitem.Size = new System.Drawing.Size(157, 23);
            this.txtDescricaoitem.TabIndex = 17;
            // 
            // btnBuscaItem
            // 
            this.btnBuscaItem.Location = new System.Drawing.Point(253, 12);
            this.btnBuscaItem.Name = "btnBuscaItem";
            this.btnBuscaItem.Size = new System.Drawing.Size(28, 25);
            this.btnBuscaItem.TabIndex = 16;
            this.btnBuscaItem.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(156, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 62);
            this.button5.TabIndex = 15;
            this.button5.Text = "Registrar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // nVALORBRUTONumericUpDown
            // 
            this.nVALORBRUTONumericUpDown.DecimalPlaces = 2;
            this.nVALORBRUTONumericUpDown.Location = new System.Drawing.Point(90, 121);
            this.nVALORBRUTONumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nVALORBRUTONumericUpDown.Name = "nVALORBRUTONumericUpDown";
            this.nVALORBRUTONumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nVALORBRUTONumericUpDown.TabIndex = 14;
            // 
            // nQUANTIDADENumericUpDown
            // 
            this.nQUANTIDADENumericUpDown.Location = new System.Drawing.Point(90, 62);
            this.nQUANTIDADENumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nQUANTIDADENumericUpDown.Name = "nQUANTIDADENumericUpDown";
            this.nQUANTIDADENumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nQUANTIDADENumericUpDown.TabIndex = 12;
            this.nQUANTIDADENumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.panel4.Size = new System.Drawing.Size(470, 393);
            this.panel4.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DDATAHORA});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(466, 290);
            this.dataGridView2.TabIndex = 11;
            // 
            // DDATAHORA
            // 
            this.DDATAHORA.DataPropertyName = "DDATAHORA";
            this.DDATAHORA.HeaderText = "Data";
            this.DDATAHORA.Name = "DDATAHORA";
            this.DDATAHORA.ReadOnly = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Lavender;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.btnCancelarItem);
            this.panel9.Controls.Add(this.btnExcluirItem);
            this.panel9.Controls.Add(this.btnAddItem);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(466, 58);
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
            this.btnCancelarItem.Location = new System.Drawing.Point(142, 0);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(71, 56);
            this.btnCancelarItem.TabIndex = 6;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluirItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluirItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirItem.FlatAppearance.BorderSize = 0;
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirItem.Location = new System.Drawing.Point(71, 0);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(71, 56);
            this.btnExcluirItem.TabIndex = 5;
            this.btnExcluirItem.Text = "Excluir";
            this.btnExcluirItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(0, 0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(71, 56);
            this.btnAddItem.TabIndex = 4;
            this.btnAddItem.Text = "Incluir";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lbtot);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 348);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 41);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "0,0";
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
            this.tabCheckOut.Controls.Add(this.panel7);
            this.tabCheckOut.Controls.Add(this.panel6);
            this.tabCheckOut.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCheckOut.Location = new System.Drawing.Point(4, 27);
            this.tabCheckOut.Name = "tabCheckOut";
            this.tabCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheckOut.Size = new System.Drawing.Size(762, 399);
            this.tabCheckOut.TabIndex = 2;
            this.tabCheckOut.Text = "Check-out";
            this.tabCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(nVALORBASELabel);
            this.panel7.Controls.Add(this.nVALORBASENumericUpDown);
            this.panel7.Controls.Add(this.nDIARIASNumericUpDown1);
            this.panel7.Controls.Add(this.lbConsumo);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(vVALORDESCONTOLabel);
            this.panel7.Controls.Add(this.vVALORDESCONTONumericUpDown);
            this.panel7.Controls.Add(vVALORTOTALLabel);
            this.panel7.Controls.Add(this.vVALORTOTALNumericUpDown);
            this.panel7.Controls.Add(fFORMAPAGAMENTOLabel);
            this.panel7.Controls.Add(this.fFORMAPAGAMENTOComboBox);
            this.panel7.Controls.Add(cOBSERVACAOLabel);
            this.panel7.Controls.Add(this.cOBSERVACAOTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(756, 293);
            this.panel7.TabIndex = 28;
            // 
            // nVALORBASENumericUpDown
            // 
            this.nVALORBASENumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "NVALORBASE", true));
            this.nVALORBASENumericUpDown.DecimalPlaces = 2;
            this.nVALORBASENumericUpDown.Enabled = false;
            this.nVALORBASENumericUpDown.Location = new System.Drawing.Point(187, 133);
            this.nVALORBASENumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nVALORBASENumericUpDown.Name = "nVALORBASENumericUpDown";
            this.nVALORBASENumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nVALORBASENumericUpDown.TabIndex = 39;
            // 
            // nDIARIASNumericUpDown1
            // 
            this.nDIARIASNumericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "NDIARIAS", true));
            this.nDIARIASNumericUpDown1.Enabled = false;
            this.nDIARIASNumericUpDown1.Location = new System.Drawing.Point(187, 104);
            this.nDIARIASNumericUpDown1.Name = "nDIARIASNumericUpDown1";
            this.nDIARIASNumericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.nDIARIASNumericUpDown1.TabIndex = 38;
            // 
            // lbConsumo
            // 
            this.lbConsumo.AutoSize = true;
            this.lbConsumo.Location = new System.Drawing.Point(184, 53);
            this.lbConsumo.Name = "lbConsumo";
            this.lbConsumo.Size = new System.Drawing.Size(34, 18);
            this.lbConsumo.TabIndex = 37;
            this.lbConsumo.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total Consumo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Diarias:";
            // 
            // vVALORDESCONTONumericUpDown
            // 
            this.vVALORDESCONTONumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "VVALORDESCONTO", true));
            this.vVALORDESCONTONumericUpDown.DecimalPlaces = 2;
            this.vVALORDESCONTONumericUpDown.Location = new System.Drawing.Point(187, 162);
            this.vVALORDESCONTONumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.vVALORDESCONTONumericUpDown.Name = "vVALORDESCONTONumericUpDown";
            this.vVALORDESCONTONumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.vVALORDESCONTONumericUpDown.TabIndex = 33;
            // 
            // vVALORTOTALNumericUpDown
            // 
            this.vVALORTOTALNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOSPEDAGEMBindingSource, "VVALORTOTAL", true));
            this.vVALORTOTALNumericUpDown.DecimalPlaces = 2;
            this.vVALORTOTALNumericUpDown.Location = new System.Drawing.Point(187, 191);
            this.vVALORTOTALNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.vVALORTOTALNumericUpDown.Name = "vVALORTOTALNumericUpDown";
            this.vVALORTOTALNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.vVALORTOTALNumericUpDown.TabIndex = 32;
            // 
            // fFORMAPAGAMENTOComboBox
            // 
            this.fFORMAPAGAMENTOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "FFORMAPAGAMENTO", true));
            this.fFORMAPAGAMENTOComboBox.FormattingEnabled = true;
            this.fFORMAPAGAMENTOComboBox.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque",
            "Cartão de crédito",
            "Cartão débito",
            "Transferência bancária",
            "Depósito bancário"});
            this.fFORMAPAGAMENTOComboBox.Location = new System.Drawing.Point(187, 18);
            this.fFORMAPAGAMENTOComboBox.Name = "fFORMAPAGAMENTOComboBox";
            this.fFORMAPAGAMENTOComboBox.Size = new System.Drawing.Size(324, 26);
            this.fFORMAPAGAMENTOComboBox.TabIndex = 30;
            // 
            // cOBSERVACAOTextBox
            // 
            this.cOBSERVACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOSPEDAGEMBindingSource, "COBSERVACAO", true));
            this.cOBSERVACAOTextBox.Location = new System.Drawing.Point(187, 220);
            this.cOBSERVACAOTextBox.Multiline = true;
            this.cOBSERVACAOTextBox.Name = "cOBSERVACAOTextBox";
            this.cOBSERVACAOTextBox.Size = new System.Drawing.Size(323, 65);
            this.cOBSERVACAOTextBox.TabIndex = 28;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnEncerrar);
            this.panel6.Controls.Add(this.btnFatura);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(3, 296);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 100);
            this.panel6.TabIndex = 26;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncerrar.Location = new System.Drawing.Point(355, 18);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(125, 62);
            this.btnEncerrar.TabIndex = 1;
            this.btnEncerrar.Text = "Encerrar";
            this.btnEncerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEncerrar.UseVisualStyleBackColor = true;
            // 
            // btnFatura
            // 
            this.btnFatura.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFatura.Location = new System.Drawing.Point(212, 18);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(120, 62);
            this.btnFatura.TabIndex = 0;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFatura.UseVisualStyleBackColor = true;
            // 
            // frmHospedagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmHospedagem";
            this.Load += new System.EventHandler(this.frmHospedagem_Load);
            this.tbMain.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPEDAGEMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown)).EndInit();
            this.tabConsumo.ResumeLayout(false);
            this.panelCadItens.ResumeLayout(false);
            this.panelCadItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBRUTONumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nQUANTIDADENumericUpDown)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabCheckOut.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBASENumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDIARIASNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVALORDESCONTONumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVALORTOTALNumericUpDown)).EndInit();
            this.panel6.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarHospedagem;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown nVALORBRUTONumericUpDown;
        private System.Windows.Forms.NumericUpDown nQUANTIDADENumericUpDown;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDATAHORA;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbtot;
        private System.Windows.Forms.TabPage tabCheckOut;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown nVALORBASENumericUpDown;
        private System.Windows.Forms.NumericUpDown nDIARIASNumericUpDown1;
        private System.Windows.Forms.Label lbConsumo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown vVALORDESCONTONumericUpDown;
        private System.Windows.Forms.NumericUpDown vVALORTOTALNumericUpDown;
        private System.Windows.Forms.ComboBox fFORMAPAGAMENTOComboBox;
        private System.Windows.Forms.TextBox cOBSERVACAOTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Button btnFatura;
    }
}
