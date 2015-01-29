namespace GestorHoteleiro
{
    partial class frmHospedes
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
            System.Windows.Forms.Label cNOMELabel;
            System.Windows.Forms.Label cCPFLabel;
            System.Windows.Forms.Label cRGLabel;
            System.Windows.Forms.Label dDATANASCLabel;
            System.Windows.Forms.Label dDATACADASTROLabel;
            System.Windows.Forms.Label cOBSERVACAOLabel;
            System.Windows.Forms.Label cCEPLabel;
            System.Windows.Forms.Label cCIDADELabel;
            System.Windows.Forms.Label cUFLabel;
            System.Windows.Forms.Label cRUALabel;
            System.Windows.Forms.Label cBAIRROLabel;
            System.Windows.Forms.Label cFONELabel;
            System.Windows.Forms.Label cFONE2Label;
            System.Windows.Forms.Label cEMAILLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHospedes));
            this.pnToolBar = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tb1 = new System.Windows.Forms.TabPage();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new GestorHoteleiro.HotelDBDataSet();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TabPage();
            this.cEMAILTextBox = new System.Windows.Forms.TextBox();
            this.cFONE2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cBAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cRUATextBox = new System.Windows.Forms.TextBox();
            this.cUFTextBox = new System.Windows.Forms.TextBox();
            this.cCIDADETextBox = new System.Windows.Forms.TextBox();
            this.cCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cOBSERVACAOTextBox = new System.Windows.Forms.TextBox();
            this.dDATACADASTRODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dDATANASCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cRGTextBox = new System.Windows.Forms.TextBox();
            this.cCPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cNOMETextBox = new System.Windows.Forms.TextBox();
            this.cLIENTETableAdapter = new GestorHoteleiro.HotelDBDataSetTableAdapters.CLIENTETableAdapter();
            this.tableAdapterManager = new GestorHoteleiro.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            cNOMELabel = new System.Windows.Forms.Label();
            cCPFLabel = new System.Windows.Forms.Label();
            cRGLabel = new System.Windows.Forms.Label();
            dDATANASCLabel = new System.Windows.Forms.Label();
            dDATACADASTROLabel = new System.Windows.Forms.Label();
            cOBSERVACAOLabel = new System.Windows.Forms.Label();
            cCEPLabel = new System.Windows.Forms.Label();
            cCIDADELabel = new System.Windows.Forms.Label();
            cUFLabel = new System.Windows.Forms.Label();
            cRUALabel = new System.Windows.Forms.Label();
            cBAIRROLabel = new System.Windows.Forms.Label();
            cFONELabel = new System.Windows.Forms.Label();
            cFONE2Label = new System.Windows.Forms.Label();
            cEMAILLabel = new System.Windows.Forms.Label();
            this.pnToolBar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tbcPrincipal.SuspendLayout();
            this.tb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.pnFiltros.SuspendLayout();
            this.tb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cNOMELabel
            // 
            cNOMELabel.AutoSize = true;
            cNOMELabel.Location = new System.Drawing.Point(118, 30);
            cNOMELabel.Name = "cNOMELabel";
            cNOMELabel.Size = new System.Drawing.Size(46, 18);
            cNOMELabel.TabIndex = 0;
            cNOMELabel.Text = "Nome:";
            // 
            // cCPFLabel
            // 
            cCPFLabel.AutoSize = true;
            cCPFLabel.Location = new System.Drawing.Point(130, 57);
            cCPFLabel.Name = "cCPFLabel";
            cCPFLabel.Size = new System.Drawing.Size(35, 18);
            cCPFLabel.TabIndex = 2;
            cCPFLabel.Text = "CPF:";
            // 
            // cRGLabel
            // 
            cRGLabel.AutoSize = true;
            cRGLabel.Location = new System.Drawing.Point(407, 59);
            cRGLabel.Name = "cRGLabel";
            cRGLabel.Size = new System.Drawing.Size(38, 18);
            cRGLabel.TabIndex = 4;
            cRGLabel.Text = "CRG:";
            // 
            // dDATANASCLabel
            // 
            dDATANASCLabel.AutoSize = true;
            dDATANASCLabel.Location = new System.Drawing.Point(55, 87);
            dDATANASCLabel.Name = "dDATANASCLabel";
            dDATANASCLabel.Size = new System.Drawing.Size(110, 18);
            dDATANASCLabel.TabIndex = 6;
            dDATANASCLabel.Text = "Dat. Nascimento:";
            // 
            // dDATACADASTROLabel
            // 
            dDATACADASTROLabel.AutoSize = true;
            dDATACADASTROLabel.Location = new System.Drawing.Point(70, 117);
            dDATACADASTROLabel.Name = "dDATACADASTROLabel";
            dDATACADASTROLabel.Size = new System.Drawing.Size(94, 18);
            dDATACADASTROLabel.TabIndex = 8;
            dDATACADASTROLabel.Text = "Dat. Cadastro:";
            // 
            // cOBSERVACAOLabel
            // 
            cOBSERVACAOLabel.AutoSize = true;
            cOBSERVACAOLabel.Location = new System.Drawing.Point(83, 141);
            cOBSERVACAOLabel.Name = "cOBSERVACAOLabel";
            cOBSERVACAOLabel.Size = new System.Drawing.Size(81, 18);
            cOBSERVACAOLabel.TabIndex = 10;
            cOBSERVACAOLabel.Text = "Observação:";
            // 
            // cCEPLabel
            // 
            cCEPLabel.AutoSize = true;
            cCEPLabel.Location = new System.Drawing.Point(129, 240);
            cCEPLabel.Name = "cCEPLabel";
            cCEPLabel.Size = new System.Drawing.Size(35, 18);
            cCEPLabel.TabIndex = 12;
            cCEPLabel.Text = "CEP:";
            // 
            // cCIDADELabel
            // 
            cCIDADELabel.AutoSize = true;
            cCIDADELabel.Location = new System.Drawing.Point(111, 272);
            cCIDADELabel.Name = "cCIDADELabel";
            cCIDADELabel.Size = new System.Drawing.Size(53, 18);
            cCIDADELabel.TabIndex = 14;
            cCIDADELabel.Text = "Cidade:";
            // 
            // cUFLabel
            // 
            cUFLabel.AutoSize = true;
            cUFLabel.Location = new System.Drawing.Point(580, 274);
            cUFLabel.Name = "cUFLabel";
            cUFLabel.Size = new System.Drawing.Size(28, 18);
            cUFLabel.TabIndex = 16;
            cUFLabel.Text = "UF:";
            // 
            // cRUALabel
            // 
            cRUALabel.AutoSize = true;
            cRUALabel.Location = new System.Drawing.Point(130, 330);
            cRUALabel.Name = "cRUALabel";
            cRUALabel.Size = new System.Drawing.Size(35, 18);
            cRUALabel.TabIndex = 18;
            cRUALabel.Text = "Rua:";
            // 
            // cBAIRROLabel
            // 
            cBAIRROLabel.AutoSize = true;
            cBAIRROLabel.Location = new System.Drawing.Point(117, 298);
            cBAIRROLabel.Name = "cBAIRROLabel";
            cBAIRROLabel.Size = new System.Drawing.Size(48, 18);
            cBAIRROLabel.TabIndex = 20;
            cBAIRROLabel.Text = "Bairro:";
            // 
            // cFONELabel
            // 
            cFONELabel.AutoSize = true;
            cFONELabel.Location = new System.Drawing.Point(102, 363);
            cFONELabel.Name = "cFONELabel";
            cFONELabel.Size = new System.Drawing.Size(62, 18);
            cFONELabel.TabIndex = 22;
            cFONELabel.Text = "Telefone:";
            // 
            // cFONE2Label
            // 
            cFONE2Label.AutoSize = true;
            cFONE2Label.Location = new System.Drawing.Point(403, 363);
            cFONE2Label.Name = "cFONE2Label";
            cFONE2Label.Size = new System.Drawing.Size(73, 18);
            cFONE2Label.TabIndex = 24;
            cFONE2Label.Text = "Telefone 2:";
            // 
            // cEMAILLabel
            // 
            cEMAILLabel.AutoSize = true;
            cEMAILLabel.Location = new System.Drawing.Point(114, 390);
            cEMAILLabel.Name = "cEMAILLabel";
            cEMAILLabel.Size = new System.Drawing.Size(50, 18);
            cEMAILLabel.TabIndex = 26;
            cEMAILLabel.Text = "E-mail:";
            // 
            // pnToolBar
            // 
            this.pnToolBar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnToolBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnToolBar.Controls.Add(this.btnCancelar);
            this.pnToolBar.Controls.Add(this.BtnSair);
            this.pnToolBar.Controls.Add(this.btnGravar);
            this.pnToolBar.Controls.Add(this.btnExcluir);
            this.pnToolBar.Controls.Add(this.btnIncluir);
            this.pnToolBar.Controls.Add(this.btnSelecionar);
            this.pnToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnToolBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnToolBar.Name = "pnToolBar";
            this.pnToolBar.Size = new System.Drawing.Size(784, 77);
            this.pnToolBar.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(49, 17);
            this.lbStatus.Text = "lbStatus";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tb1);
            this.tbcPrincipal.Controls.Add(this.tb2);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 77);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(784, 462);
            this.tbcPrincipal.TabIndex = 2;
            this.tbcPrincipal.SelectedIndexChanged += new System.EventHandler(this.tbcPrincipal_SelectedIndexChanged);
            this.tbcPrincipal.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcPrincipal_Selecting);
            // 
            // tb1
            // 
            this.tb1.Controls.Add(this.dgvConsulta);
            this.tb1.Controls.Add(this.pnFiltros);
            this.tb1.Location = new System.Drawing.Point(4, 27);
            this.tb1.Name = "tb1";
            this.tb1.Padding = new System.Windows.Forms.Padding(3);
            this.tb1.Size = new System.Drawing.Size(776, 431);
            this.tb1.TabIndex = 0;
            this.tb1.Text = "Consulta";
            this.tb1.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoGenerateColumns = false;
            this.dgvConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNOMEDataGridViewTextBoxColumn,
            this.cCIDADEDataGridViewTextBoxColumn,
            this.cUFDataGridViewTextBoxColumn,
            this.cFONEDataGridViewTextBoxColumn,
            this.cFONE2DataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn});
            this.dgvConsulta.DataSource = this.cLIENTEBindingSource;
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(3, 71);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(770, 357);
            this.dgvConsulta.TabIndex = 1;
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnFiltros
            // 
            this.pnFiltros.BackColor = System.Drawing.Color.LightGray;
            this.pnFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFiltros.Controls.Add(this.textBox1);
            this.pnFiltros.Controls.Add(this.label1);
            this.pnFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFiltros.Location = new System.Drawing.Point(3, 3);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(770, 68);
            this.pnFiltros.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(357, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(106, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Hóspde:";
            // 
            // tb2
            // 
            this.tb2.AutoScroll = true;
            this.tb2.Controls.Add(cEMAILLabel);
            this.tb2.Controls.Add(this.cEMAILTextBox);
            this.tb2.Controls.Add(cFONE2Label);
            this.tb2.Controls.Add(this.cFONE2MaskedTextBox);
            this.tb2.Controls.Add(cFONELabel);
            this.tb2.Controls.Add(this.cFONEMaskedTextBox);
            this.tb2.Controls.Add(cBAIRROLabel);
            this.tb2.Controls.Add(this.cBAIRROTextBox);
            this.tb2.Controls.Add(cRUALabel);
            this.tb2.Controls.Add(this.cRUATextBox);
            this.tb2.Controls.Add(cUFLabel);
            this.tb2.Controls.Add(this.cUFTextBox);
            this.tb2.Controls.Add(cCIDADELabel);
            this.tb2.Controls.Add(this.cCIDADETextBox);
            this.tb2.Controls.Add(cCEPLabel);
            this.tb2.Controls.Add(this.cCEPMaskedTextBox);
            this.tb2.Controls.Add(cOBSERVACAOLabel);
            this.tb2.Controls.Add(this.cOBSERVACAOTextBox);
            this.tb2.Controls.Add(dDATACADASTROLabel);
            this.tb2.Controls.Add(this.dDATACADASTRODateTimePicker);
            this.tb2.Controls.Add(dDATANASCLabel);
            this.tb2.Controls.Add(this.dDATANASCDateTimePicker);
            this.tb2.Controls.Add(cRGLabel);
            this.tb2.Controls.Add(this.cRGTextBox);
            this.tb2.Controls.Add(cCPFLabel);
            this.tb2.Controls.Add(this.cCPFMaskedTextBox);
            this.tb2.Controls.Add(cNOMELabel);
            this.tb2.Controls.Add(this.cNOMETextBox);
            this.tb2.Location = new System.Drawing.Point(4, 27);
            this.tb2.Name = "tb2";
            this.tb2.Padding = new System.Windows.Forms.Padding(3);
            this.tb2.Size = new System.Drawing.Size(776, 431);
            this.tb2.TabIndex = 1;
            this.tb2.Text = "Cadastro";
            this.tb2.UseVisualStyleBackColor = true;
            // 
            // cEMAILTextBox
            // 
            this.cEMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CEMAIL", true));
            this.cEMAILTextBox.Location = new System.Drawing.Point(170, 385);
            this.cEMAILTextBox.Name = "cEMAILTextBox";
            this.cEMAILTextBox.Size = new System.Drawing.Size(484, 23);
            this.cEMAILTextBox.TabIndex = 27;
            // 
            // cFONE2MaskedTextBox
            // 
            this.cFONE2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CFONE2", true));
            this.cFONE2MaskedTextBox.Location = new System.Drawing.Point(482, 356);
            this.cFONE2MaskedTextBox.Mask = "(999) 0000-0000";
            this.cFONE2MaskedTextBox.Name = "cFONE2MaskedTextBox";
            this.cFONE2MaskedTextBox.Size = new System.Drawing.Size(172, 23);
            this.cFONE2MaskedTextBox.TabIndex = 25;
            // 
            // cFONEMaskedTextBox
            // 
            this.cFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CFONE", true));
            this.cFONEMaskedTextBox.Location = new System.Drawing.Point(170, 356);
            this.cFONEMaskedTextBox.Mask = "(999) 0000-0000";
            this.cFONEMaskedTextBox.Name = "cFONEMaskedTextBox";
            this.cFONEMaskedTextBox.Size = new System.Drawing.Size(167, 23);
            this.cFONEMaskedTextBox.TabIndex = 23;
            // 
            // cBAIRROTextBox
            // 
            this.cBAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CBAIRRO", true));
            this.cBAIRROTextBox.Location = new System.Drawing.Point(170, 298);
            this.cBAIRROTextBox.Name = "cBAIRROTextBox";
            this.cBAIRROTextBox.Size = new System.Drawing.Size(484, 23);
            this.cBAIRROTextBox.TabIndex = 21;
            // 
            // cRUATextBox
            // 
            this.cRUATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CRUA", true));
            this.cRUATextBox.Location = new System.Drawing.Point(170, 327);
            this.cRUATextBox.Name = "cRUATextBox";
            this.cRUATextBox.Size = new System.Drawing.Size(484, 23);
            this.cRUATextBox.TabIndex = 19;
            // 
            // cUFTextBox
            // 
            this.cUFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CUF", true));
            this.cUFTextBox.Location = new System.Drawing.Point(614, 269);
            this.cUFTextBox.Name = "cUFTextBox";
            this.cUFTextBox.Size = new System.Drawing.Size(40, 23);
            this.cUFTextBox.TabIndex = 17;
            // 
            // cCIDADETextBox
            // 
            this.cCIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCIDADE", true));
            this.cCIDADETextBox.Location = new System.Drawing.Point(170, 269);
            this.cCIDADETextBox.Name = "cCIDADETextBox";
            this.cCIDADETextBox.Size = new System.Drawing.Size(396, 23);
            this.cCIDADETextBox.TabIndex = 15;
            // 
            // cCEPMaskedTextBox
            // 
            this.cCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCEP", true));
            this.cCEPMaskedTextBox.Location = new System.Drawing.Point(170, 240);
            this.cCEPMaskedTextBox.Mask = "00000-999";
            this.cCEPMaskedTextBox.Name = "cCEPMaskedTextBox";
            this.cCEPMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.cCEPMaskedTextBox.TabIndex = 13;
            // 
            // cOBSERVACAOTextBox
            // 
            this.cOBSERVACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "COBSERVACAO", true));
            this.cOBSERVACAOTextBox.Location = new System.Drawing.Point(170, 141);
            this.cOBSERVACAOTextBox.Multiline = true;
            this.cOBSERVACAOTextBox.Name = "cOBSERVACAOTextBox";
            this.cOBSERVACAOTextBox.Size = new System.Drawing.Size(484, 93);
            this.cOBSERVACAOTextBox.TabIndex = 11;
            // 
            // dDATACADASTRODateTimePicker
            // 
            this.dDATACADASTRODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cLIENTEBindingSource, "DDATACADASTRO", true));
            this.dDATACADASTRODateTimePicker.Location = new System.Drawing.Point(170, 112);
            this.dDATACADASTRODateTimePicker.Name = "dDATACADASTRODateTimePicker";
            this.dDATACADASTRODateTimePicker.Size = new System.Drawing.Size(285, 23);
            this.dDATACADASTRODateTimePicker.TabIndex = 9;
            // 
            // dDATANASCDateTimePicker
            // 
            this.dDATANASCDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cLIENTEBindingSource, "DDATANASC", true));
            this.dDATANASCDateTimePicker.Location = new System.Drawing.Point(170, 83);
            this.dDATANASCDateTimePicker.Name = "dDATANASCDateTimePicker";
            this.dDATANASCDateTimePicker.Size = new System.Drawing.Size(285, 23);
            this.dDATANASCDateTimePicker.TabIndex = 7;
            // 
            // cRGTextBox
            // 
            this.cRGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CRG", true));
            this.cRGTextBox.Location = new System.Drawing.Point(451, 54);
            this.cRGTextBox.Name = "cRGTextBox";
            this.cRGTextBox.Size = new System.Drawing.Size(203, 23);
            this.cRGTextBox.TabIndex = 5;
            // 
            // cCPFMaskedTextBox
            // 
            this.cCPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCPF", true));
            this.cCPFMaskedTextBox.Location = new System.Drawing.Point(170, 54);
            this.cCPFMaskedTextBox.Mask = "000-000-000-00";
            this.cCPFMaskedTextBox.Name = "cCPFMaskedTextBox";
            this.cCPFMaskedTextBox.Size = new System.Drawing.Size(193, 23);
            this.cCPFMaskedTextBox.TabIndex = 3;
            // 
            // cNOMETextBox
            // 
            this.cNOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CNOME", true));
            this.cNOMETextBox.Location = new System.Drawing.Point(170, 25);
            this.cNOMETextBox.Name = "cNOMETextBox";
            this.cNOMETextBox.Size = new System.Drawing.Size(484, 23);
            this.cNOMETextBox.TabIndex = 1;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
            this.tableAdapterManager.CONSUMOTableAdapter = null;
            this.tableAdapterManager.HOSPEDAGEMTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GestorHoteleiro.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cNOMEDataGridViewTextBoxColumn
            // 
            this.cNOMEDataGridViewTextBoxColumn.DataPropertyName = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.cNOMEDataGridViewTextBoxColumn.Name = "cNOMEDataGridViewTextBoxColumn";
            this.cNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNOMEDataGridViewTextBoxColumn.Width = 300;
            // 
            // cCIDADEDataGridViewTextBoxColumn
            // 
            this.cCIDADEDataGridViewTextBoxColumn.DataPropertyName = "CCIDADE";
            this.cCIDADEDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cCIDADEDataGridViewTextBoxColumn.Name = "cCIDADEDataGridViewTextBoxColumn";
            this.cCIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUFDataGridViewTextBoxColumn
            // 
            this.cUFDataGridViewTextBoxColumn.DataPropertyName = "CUF";
            this.cUFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.cUFDataGridViewTextBoxColumn.Name = "cUFDataGridViewTextBoxColumn";
            this.cUFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFONEDataGridViewTextBoxColumn
            // 
            this.cFONEDataGridViewTextBoxColumn.DataPropertyName = "CFONE";
            this.cFONEDataGridViewTextBoxColumn.HeaderText = "Telefone ";
            this.cFONEDataGridViewTextBoxColumn.Name = "cFONEDataGridViewTextBoxColumn";
            this.cFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFONE2DataGridViewTextBoxColumn
            // 
            this.cFONE2DataGridViewTextBoxColumn.DataPropertyName = "CFONE2";
            this.cFONE2DataGridViewTextBoxColumn.HeaderText = "Telefone 2";
            this.cFONE2DataGridViewTextBoxColumn.Name = "cFONE2DataGridViewTextBoxColumn";
            this.cFONE2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Image = global::GestorHoteleiro.Properties.Resources.exit;
            this.BtnSair.Location = new System.Drawing.Point(701, 0);
            this.BtnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(81, 75);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "Sair";
            this.BtnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSair.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = global::GestorHoteleiro.Properties.Resources.ok32x32;
            this.btnGravar.Location = new System.Drawing.Point(243, 0);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(81, 75);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GestorHoteleiro.Properties.Resources.delete;
            this.btnExcluir.Location = new System.Drawing.Point(162, 0);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 75);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = global::GestorHoteleiro.Properties.Resources.Add32x32;
            this.btnIncluir.Location = new System.Drawing.Point(81, 0);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(81, 75);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelecionar.FlatAppearance.BorderSize = 0;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Image = global::GestorHoteleiro.Properties.Resources.selecionar32x32;
            this.btnSelecionar.Location = new System.Drawing.Point(0, 0);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(81, 75);
            this.btnSelecionar.TabIndex = 0;
            this.btnSelecionar.Text = "Incluir";
            this.btnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GestorHoteleiro.Properties.Resources.Cancel32x32;
            this.btnCancelar.Location = new System.Drawing.Point(324, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 75);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnToolBar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHospedes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Hóspedes";
            this.Load += new System.EventHandler(this.frmHospedes_Load);
            this.pnToolBar.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbcPrincipal.ResumeLayout(false);
            this.tb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tb2.ResumeLayout(false);
            this.tb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnToolBar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tb1;
        private System.Windows.Forms.Panel pnFiltros;
        private System.Windows.Forms.TabPage tb2;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDBDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cEMAILTextBox;
        private System.Windows.Forms.MaskedTextBox cFONE2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cFONEMaskedTextBox;
        private System.Windows.Forms.TextBox cBAIRROTextBox;
        private System.Windows.Forms.TextBox cRUATextBox;
        private System.Windows.Forms.TextBox cUFTextBox;
        private System.Windows.Forms.TextBox cCIDADETextBox;
        private System.Windows.Forms.MaskedTextBox cCEPMaskedTextBox;
        private System.Windows.Forms.TextBox cOBSERVACAOTextBox;
        private System.Windows.Forms.DateTimePicker dDATACADASTRODateTimePicker;
        private System.Windows.Forms.DateTimePicker dDATANASCDateTimePicker;
        private System.Windows.Forms.TextBox cRGTextBox;
        private System.Windows.Forms.MaskedTextBox cCPFMaskedTextBox;
        private System.Windows.Forms.TextBox cNOMETextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
    }
}