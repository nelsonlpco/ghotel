namespace HotelGestor
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
            System.Windows.Forms.Label cOBSERVACAOLabel;
            System.Windows.Forms.Label cCIDADELabel;
            System.Windows.Forms.Label cUFLabel;
            System.Windows.Forms.Label cBAIRROLabel;
            System.Windows.Forms.Label cRUALabel;
            System.Windows.Forms.Label cEMAILLabel;
            System.Windows.Forms.Label cCEPLabel;
            System.Windows.Forms.Label cFONELabel;
            System.Windows.Forms.Label cFONE2Label;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.cLIENTETableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.CLIENTETableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cNOMETextBox = new System.Windows.Forms.TextBox();
            this.fOTOPictureBox = new System.Windows.Forms.PictureBox();
            this.cCPFMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cRGTextBox = new System.Windows.Forms.TextBox();
            this.dDATANASCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cOBSERVACAOTextBox = new System.Windows.Forms.TextBox();
            this.cCIDADETextBox = new System.Windows.Forms.TextBox();
            this.cUFTextBox = new System.Windows.Forms.TextBox();
            this.cBAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cRUATextBox = new System.Windows.Forms.TextBox();
            this.cEMAILTextBox = new System.Windows.Forms.TextBox();
            this.cCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONE2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            cNOMELabel = new System.Windows.Forms.Label();
            cCPFLabel = new System.Windows.Forms.Label();
            cRGLabel = new System.Windows.Forms.Label();
            dDATANASCLabel = new System.Windows.Forms.Label();
            cOBSERVACAOLabel = new System.Windows.Forms.Label();
            cCIDADELabel = new System.Windows.Forms.Label();
            cUFLabel = new System.Windows.Forms.Label();
            cBAIRROLabel = new System.Windows.Forms.Label();
            cRUALabel = new System.Windows.Forms.Label();
            cEMAILLabel = new System.Windows.Forms.Label();
            cCEPLabel = new System.Windows.Forms.Label();
            cFONELabel = new System.Windows.Forms.Label();
            cFONE2Label = new System.Windows.Forms.Label();
            this.tbMain.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.dataGridView1);
            this.tbCadastro.Controls.SetChildIndex(this.pnFiltros, 0);
            this.tbCadastro.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // pnFiltros
            // 
            this.pnFiltros.Controls.Add(this.txtFiltro);
            this.pnFiltros.Controls.Add(this.label1);
            this.pnFiltros.Size = new System.Drawing.Size(770, 66);
            // 
            // tbConsulta
            // 
            this.tbConsulta.AutoScroll = true;
            this.tbConsulta.Controls.Add(this.btnBuscaCep);
            this.tbConsulta.Controls.Add(cFONE2Label);
            this.tbConsulta.Controls.Add(this.cFONE2MaskedTextBox);
            this.tbConsulta.Controls.Add(cFONELabel);
            this.tbConsulta.Controls.Add(this.cFONEMaskedTextBox);
            this.tbConsulta.Controls.Add(cCEPLabel);
            this.tbConsulta.Controls.Add(this.cCEPMaskedTextBox);
            this.tbConsulta.Controls.Add(cEMAILLabel);
            this.tbConsulta.Controls.Add(this.cEMAILTextBox);
            this.tbConsulta.Controls.Add(cRUALabel);
            this.tbConsulta.Controls.Add(this.cRUATextBox);
            this.tbConsulta.Controls.Add(cBAIRROLabel);
            this.tbConsulta.Controls.Add(this.cBAIRROTextBox);
            this.tbConsulta.Controls.Add(cUFLabel);
            this.tbConsulta.Controls.Add(this.cUFTextBox);
            this.tbConsulta.Controls.Add(cCIDADELabel);
            this.tbConsulta.Controls.Add(this.cCIDADETextBox);
            this.tbConsulta.Controls.Add(cOBSERVACAOLabel);
            this.tbConsulta.Controls.Add(this.cOBSERVACAOTextBox);
            this.tbConsulta.Controls.Add(dDATANASCLabel);
            this.tbConsulta.Controls.Add(this.dDATANASCDateTimePicker);
            this.tbConsulta.Controls.Add(cRGLabel);
            this.tbConsulta.Controls.Add(this.cRGTextBox);
            this.tbConsulta.Controls.Add(cCPFLabel);
            this.tbConsulta.Controls.Add(this.cCPFMaskedTextBox);
            this.tbConsulta.Controls.Add(this.fOTOPictureBox);
            this.tbConsulta.Controls.Add(cNOMELabel);
            this.tbConsulta.Controls.Add(this.cNOMETextBox);
            this.tbConsulta.Controls.Add(this.panel2);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Location = new System.Drawing.Point(348, 0);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.Location = new System.Drawing.Point(261, 0);
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Location = new System.Drawing.Point(174, 0);
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Location = new System.Drawing.Point(87, 0);
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.FlatAppearance.BorderSize = 0;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // cNOMELabel
            // 
            cNOMELabel.AutoSize = true;
            cNOMELabel.Location = new System.Drawing.Point(71, 41);
            cNOMELabel.Name = "cNOMELabel";
            cNOMELabel.Size = new System.Drawing.Size(47, 18);
            cNOMELabel.TabIndex = 37;
            cNOMELabel.Text = "Nome:";
            // 
            // cCPFLabel
            // 
            cCPFLabel.AutoSize = true;
            cCPFLabel.Location = new System.Drawing.Point(81, 69);
            cCPFLabel.Name = "cCPFLabel";
            cCPFLabel.Size = new System.Drawing.Size(37, 18);
            cCPFLabel.TabIndex = 39;
            cCPFLabel.Text = "CPF:";
            // 
            // cRGLabel
            // 
            cRGLabel.AutoSize = true;
            cRGLabel.Location = new System.Drawing.Point(254, 69);
            cRGLabel.Name = "cRGLabel";
            cRGLabel.Size = new System.Drawing.Size(30, 18);
            cRGLabel.TabIndex = 40;
            cRGLabel.Text = "RG:";
            // 
            // dDATANASCLabel
            // 
            dDATANASCLabel.AutoSize = true;
            dDATANASCLabel.Location = new System.Drawing.Point(3, 101);
            dDATANASCLabel.Name = "dDATANASCLabel";
            dDATANASCLabel.Size = new System.Drawing.Size(115, 18);
            dDATANASCLabel.TabIndex = 41;
            dDATANASCLabel.Text = "Data Nascimento:";
            // 
            // cOBSERVACAOLabel
            // 
            cOBSERVACAOLabel.AutoSize = true;
            cOBSERVACAOLabel.Location = new System.Drawing.Point(34, 128);
            cOBSERVACAOLabel.Name = "cOBSERVACAOLabel";
            cOBSERVACAOLabel.Size = new System.Drawing.Size(84, 18);
            cOBSERVACAOLabel.TabIndex = 42;
            cOBSERVACAOLabel.Text = "Observação:";
            // 
            // cCIDADELabel
            // 
            cCIDADELabel.AutoSize = true;
            cCIDADELabel.Location = new System.Drawing.Point(63, 262);
            cCIDADELabel.Name = "cCIDADELabel";
            cCIDADELabel.Size = new System.Drawing.Size(55, 18);
            cCIDADELabel.TabIndex = 44;
            cCIDADELabel.Text = "Cidade:";
            // 
            // cUFLabel
            // 
            cUFLabel.AutoSize = true;
            cUFLabel.Location = new System.Drawing.Point(427, 262);
            cUFLabel.Name = "cUFLabel";
            cUFLabel.Size = new System.Drawing.Size(30, 18);
            cUFLabel.TabIndex = 45;
            cUFLabel.Text = "UF:";
            // 
            // cBAIRROLabel
            // 
            cBAIRROLabel.AutoSize = true;
            cBAIRROLabel.Location = new System.Drawing.Point(67, 292);
            cBAIRROLabel.Name = "cBAIRROLabel";
            cBAIRROLabel.Size = new System.Drawing.Size(51, 18);
            cBAIRROLabel.TabIndex = 46;
            cBAIRROLabel.Text = "Bairro:";
            // 
            // cRUALabel
            // 
            cRUALabel.AutoSize = true;
            cRUALabel.Location = new System.Drawing.Point(82, 321);
            cRUALabel.Name = "cRUALabel";
            cRUALabel.Size = new System.Drawing.Size(36, 18);
            cRUALabel.TabIndex = 47;
            cRUALabel.Text = "Rua:";
            // 
            // cEMAILLabel
            // 
            cEMAILLabel.AutoSize = true;
            cEMAILLabel.Location = new System.Drawing.Point(67, 379);
            cEMAILLabel.Name = "cEMAILLabel";
            cEMAILLabel.Size = new System.Drawing.Size(51, 18);
            cEMAILLabel.TabIndex = 50;
            cEMAILLabel.Text = "E-mail:";
            // 
            // cCEPLabel
            // 
            cCEPLabel.AutoSize = true;
            cCEPLabel.Location = new System.Drawing.Point(82, 234);
            cCEPLabel.Name = "cCEPLabel";
            cCEPLabel.Size = new System.Drawing.Size(36, 18);
            cCEPLabel.TabIndex = 51;
            cCEPLabel.Text = "CEP:";
            // 
            // cFONELabel
            // 
            cFONELabel.AutoSize = true;
            cFONELabel.Location = new System.Drawing.Point(53, 350);
            cFONELabel.Name = "cFONELabel";
            cFONELabel.Size = new System.Drawing.Size(65, 18);
            cFONELabel.TabIndex = 52;
            cFONELabel.Text = "Telefone:";
            // 
            // cFONE2Label
            // 
            cFONE2Label.AutoSize = true;
            cFONE2Label.Location = new System.Drawing.Point(282, 350);
            cFONE2Label.Name = "cFONE2Label";
            cFONE2Label.Size = new System.Drawing.Size(77, 18);
            cFONE2Label.TabIndex = 53;
            cFONE2Label.Text = "Telefone 2:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNOMEDataGridViewTextBoxColumn,
            this.cFONEDataGridViewTextBoxColumn,
            this.cFONE2DataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 364);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cNOMEDataGridViewTextBoxColumn
            // 
            this.cNOMEDataGridViewTextBoxColumn.DataPropertyName = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.cNOMEDataGridViewTextBoxColumn.Name = "cNOMEDataGridViewTextBoxColumn";
            this.cNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNOMEDataGridViewTextBoxColumn.Width = 250;
            // 
            // cFONEDataGridViewTextBoxColumn
            // 
            this.cFONEDataGridViewTextBoxColumn.DataPropertyName = "CFONE";
            this.cFONEDataGridViewTextBoxColumn.HeaderText = "Telefone";
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
            this.cEMAILDataGridViewTextBoxColumn.Width = 200;
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
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnArquivo);
            this.panel2.Controls.Add(this.btnCamera);
            this.panel2.Location = new System.Drawing.Point(523, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 50);
            this.panel2.TabIndex = 37;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Image = global::HotelGestor.Properties.Resources.imagfold32x32;
            this.btnArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArquivo.Location = new System.Drawing.Point(126, 3);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(114, 40);
            this.btnArquivo.TabIndex = 1;
            this.btnArquivo.Text = "Arquivo";
            this.btnArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnCamera
            // 
            this.btnCamera.Image = global::HotelGestor.Properties.Resources.cam32x32;
            this.btnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCamera.Location = new System.Drawing.Point(3, 3);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(114, 40);
            this.btnCamera.TabIndex = 0;
            this.btnCamera.Text = "Câmera";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = this.cLIENTETableAdapter;
            this.tableAdapterManager.CONSUMOTableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cNOMETextBox
            // 
            this.cNOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CNOME", true));
            this.cNOMETextBox.Location = new System.Drawing.Point(124, 38);
            this.cNOMETextBox.Name = "cNOMETextBox";
            this.cNOMETextBox.Size = new System.Drawing.Size(375, 23);
            this.cNOMETextBox.TabIndex = 38;
            this.cNOMETextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // fOTOPictureBox
            // 
            this.fOTOPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.cLIENTEBindingSource, "FOTO", true));
            this.fOTOPictureBox.Location = new System.Drawing.Point(523, 38);
            this.fOTOPictureBox.Name = "fOTOPictureBox";
            this.fOTOPictureBox.Size = new System.Drawing.Size(245, 193);
            this.fOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fOTOPictureBox.TabIndex = 39;
            this.fOTOPictureBox.TabStop = false;
            // 
            // cCPFMaskedTextBox
            // 
            this.cCPFMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCPF", true));
            this.cCPFMaskedTextBox.Location = new System.Drawing.Point(124, 67);
            this.cCPFMaskedTextBox.Mask = "999.999.999-99";
            this.cCPFMaskedTextBox.Name = "cCPFMaskedTextBox";
            this.cCPFMaskedTextBox.Size = new System.Drawing.Size(124, 23);
            this.cCPFMaskedTextBox.TabIndex = 40;
            this.cCPFMaskedTextBox.Click += new System.EventHandler(this.cCPFMaskedTextBox_Enter);
            this.cCPFMaskedTextBox.Enter += new System.EventHandler(this.cCPFMaskedTextBox_Enter);
            // 
            // cRGTextBox
            // 
            this.cRGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CRG", true));
            this.cRGTextBox.Location = new System.Drawing.Point(298, 67);
            this.cRGTextBox.Name = "cRGTextBox";
            this.cRGTextBox.Size = new System.Drawing.Size(201, 23);
            this.cRGTextBox.TabIndex = 41;
            this.cRGTextBox.Leave += new System.EventHandler(this.cRGTextBox_Leave);
            // 
            // dDATANASCDateTimePicker
            // 
            this.dDATANASCDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cLIENTEBindingSource, "DDATANASC", true));
            this.dDATANASCDateTimePicker.Location = new System.Drawing.Point(124, 96);
            this.dDATANASCDateTimePicker.Name = "dDATANASCDateTimePicker";
            this.dDATANASCDateTimePicker.Size = new System.Drawing.Size(378, 23);
            this.dDATANASCDateTimePicker.TabIndex = 42;
            // 
            // cOBSERVACAOTextBox
            // 
            this.cOBSERVACAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "COBSERVACAO", true));
            this.cOBSERVACAOTextBox.Location = new System.Drawing.Point(124, 125);
            this.cOBSERVACAOTextBox.Multiline = true;
            this.cOBSERVACAOTextBox.Name = "cOBSERVACAOTextBox";
            this.cOBSERVACAOTextBox.Size = new System.Drawing.Size(378, 98);
            this.cOBSERVACAOTextBox.TabIndex = 43;
            // 
            // cCIDADETextBox
            // 
            this.cCIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCIDADE", true));
            this.cCIDADETextBox.Location = new System.Drawing.Point(124, 260);
            this.cCIDADETextBox.Name = "cCIDADETextBox";
            this.cCIDADETextBox.Size = new System.Drawing.Size(303, 23);
            this.cCIDADETextBox.TabIndex = 45;
            this.cCIDADETextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cUFTextBox
            // 
            this.cUFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CUF", true));
            this.cUFTextBox.Location = new System.Drawing.Point(463, 260);
            this.cUFTextBox.Name = "cUFTextBox";
            this.cUFTextBox.Size = new System.Drawing.Size(39, 23);
            this.cUFTextBox.TabIndex = 46;
            this.cUFTextBox.Leave += new System.EventHandler(this.cRGTextBox_Leave);
            // 
            // cBAIRROTextBox
            // 
            this.cBAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CBAIRRO", true));
            this.cBAIRROTextBox.Location = new System.Drawing.Point(124, 289);
            this.cBAIRROTextBox.Name = "cBAIRROTextBox";
            this.cBAIRROTextBox.Size = new System.Drawing.Size(378, 23);
            this.cBAIRROTextBox.TabIndex = 47;
            this.cBAIRROTextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cRUATextBox
            // 
            this.cRUATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CRUA", true));
            this.cRUATextBox.Location = new System.Drawing.Point(124, 318);
            this.cRUATextBox.Name = "cRUATextBox";
            this.cRUATextBox.Size = new System.Drawing.Size(378, 23);
            this.cRUATextBox.TabIndex = 48;
            this.cRUATextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cEMAILTextBox
            // 
            this.cEMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CEMAIL", true));
            this.cEMAILTextBox.Location = new System.Drawing.Point(124, 376);
            this.cEMAILTextBox.Name = "cEMAILTextBox";
            this.cEMAILTextBox.Size = new System.Drawing.Size(378, 23);
            this.cEMAILTextBox.TabIndex = 51;
            // 
            // cCEPMaskedTextBox
            // 
            this.cCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CCEP", true));
            this.cCEPMaskedTextBox.Location = new System.Drawing.Point(124, 231);
            this.cCEPMaskedTextBox.Mask = "99999-999";
            this.cCEPMaskedTextBox.Name = "cCEPMaskedTextBox";
            this.cCEPMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.cCEPMaskedTextBox.TabIndex = 52;
            this.cCEPMaskedTextBox.Click += new System.EventHandler(this.cCPFMaskedTextBox_Enter);
            this.cCEPMaskedTextBox.Enter += new System.EventHandler(this.cCPFMaskedTextBox_Enter);
            // 
            // cFONEMaskedTextBox
            // 
            this.cFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CFONE", true));
            this.cFONEMaskedTextBox.Location = new System.Drawing.Point(124, 347);
            this.cFONEMaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONEMaskedTextBox.Name = "cFONEMaskedTextBox";
            this.cFONEMaskedTextBox.Size = new System.Drawing.Size(134, 23);
            this.cFONEMaskedTextBox.TabIndex = 53;
            this.cFONEMaskedTextBox.Click += new System.EventHandler(this.cFONEMaskedTextBox_Enter);
            this.cFONEMaskedTextBox.Enter += new System.EventHandler(this.cFONEMaskedTextBox_Enter);
            // 
            // cFONE2MaskedTextBox
            // 
            this.cFONE2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTEBindingSource, "CFONE2", true));
            this.cFONE2MaskedTextBox.Location = new System.Drawing.Point(365, 347);
            this.cFONE2MaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONE2MaskedTextBox.Name = "cFONE2MaskedTextBox";
            this.cFONE2MaskedTextBox.Size = new System.Drawing.Size(137, 23);
            this.cFONE2MaskedTextBox.TabIndex = 54;
            this.cFONE2MaskedTextBox.Click += new System.EventHandler(this.cFONEMaskedTextBox_Enter);
            this.cFONE2MaskedTextBox.Enter += new System.EventHandler(this.cFONEMaskedTextBox_Enter);
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.Location = new System.Drawing.Point(238, 231);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(121, 24);
            this.btnBuscaCep.TabIndex = 55;
            this.btnBuscaCep.Text = "Busca Endereço";
            this.btnBuscaCep.UseVisualStyleBackColor = true;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar Hóspede:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(230, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(372, 23);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmHospedes";
            this.Load += new System.EventHandler(this.frmHospedes_Load);
            this.tbMain.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDBDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.Button btnBuscaCep;
        private System.Windows.Forms.MaskedTextBox cFONE2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cFONEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cCEPMaskedTextBox;
        private System.Windows.Forms.TextBox cEMAILTextBox;
        private System.Windows.Forms.TextBox cRUATextBox;
        private System.Windows.Forms.TextBox cBAIRROTextBox;
        private System.Windows.Forms.TextBox cUFTextBox;
        private System.Windows.Forms.TextBox cCIDADETextBox;
        private System.Windows.Forms.TextBox cOBSERVACAOTextBox;
        private System.Windows.Forms.DateTimePicker dDATANASCDateTimePicker;
        private System.Windows.Forms.TextBox cRGTextBox;
        private System.Windows.Forms.MaskedTextBox cCPFMaskedTextBox;
        private System.Windows.Forms.PictureBox fOTOPictureBox;
        private System.Windows.Forms.TextBox cNOMETextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnCamera;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;

    }
}
