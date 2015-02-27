namespace HotelGestor
{
    partial class frmQuartos
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
            System.Windows.Forms.Label cDESCRICAOLabel;
            System.Windows.Forms.Label nNUMEROLabel;
            System.Windows.Forms.Label nANDARLabel;
            System.Windows.Forms.Label nMAXPESSOASLabel;
            System.Windows.Forms.Label nVALORBASELabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nNUMERODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nANDARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMAXPESSOASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVALORBASEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cESTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUARTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.cDESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.nNUMERONumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nANDARNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nMAXPESSOASNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nVALORBASENumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.qUARTOTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.QUARTOTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.npFiltroAndar = new System.Windows.Forms.NumericUpDown();
            this.npFiltroPessoa = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.npFiltroDiariaFim = new System.Windows.Forms.NumericUpDown();
            this.npFiltroDiariaIni = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFiltroStatus = new System.Windows.Forms.ComboBox();
            cDESCRICAOLabel = new System.Windows.Forms.Label();
            nNUMEROLabel = new System.Windows.Forms.Label();
            nANDARLabel = new System.Windows.Forms.Label();
            nMAXPESSOASLabel = new System.Windows.Forms.Label();
            nVALORBASELabel = new System.Windows.Forms.Label();
            this.tbMain.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUARTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNUMERONumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nANDARNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMAXPESSOASNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBASENumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroAndar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroDiariaFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroDiariaIni)).BeginInit();
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
            this.pnFiltros.Controls.Add(this.cbFiltroStatus);
            this.pnFiltros.Controls.Add(this.label5);
            this.pnFiltros.Controls.Add(this.npFiltroDiariaFim);
            this.pnFiltros.Controls.Add(this.npFiltroDiariaIni);
            this.pnFiltros.Controls.Add(this.label3);
            this.pnFiltros.Controls.Add(this.label4);
            this.pnFiltros.Controls.Add(this.btnFiltrar);
            this.pnFiltros.Controls.Add(this.npFiltroPessoa);
            this.pnFiltros.Controls.Add(this.npFiltroAndar);
            this.pnFiltros.Controls.Add(this.label2);
            this.pnFiltros.Controls.Add(this.label1);
            this.pnFiltros.Size = new System.Drawing.Size(770, 144);
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(nVALORBASELabel);
            this.tbConsulta.Controls.Add(this.nVALORBASENumericUpDown);
            this.tbConsulta.Controls.Add(nMAXPESSOASLabel);
            this.tbConsulta.Controls.Add(this.nMAXPESSOASNumericUpDown);
            this.tbConsulta.Controls.Add(nANDARLabel);
            this.tbConsulta.Controls.Add(this.nANDARNumericUpDown);
            this.tbConsulta.Controls.Add(nNUMEROLabel);
            this.tbConsulta.Controls.Add(this.nNUMERONumericUpDown);
            this.tbConsulta.Controls.Add(cDESCRICAOLabel);
            this.tbConsulta.Controls.Add(this.cDESCRICAOTextBox);
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
            // cDESCRICAOLabel
            // 
            cDESCRICAOLabel.AutoSize = true;
            cDESCRICAOLabel.Location = new System.Drawing.Point(109, 70);
            cDESCRICAOLabel.Name = "cDESCRICAOLabel";
            cDESCRICAOLabel.Size = new System.Drawing.Size(72, 18);
            cDESCRICAOLabel.TabIndex = 0;
            cDESCRICAOLabel.Text = "Descrição:";
            // 
            // nNUMEROLabel
            // 
            nNUMEROLabel.AutoSize = true;
            nNUMEROLabel.Location = new System.Drawing.Point(120, 236);
            nNUMEROLabel.Name = "nNUMEROLabel";
            nNUMEROLabel.Size = new System.Drawing.Size(61, 18);
            nNUMEROLabel.TabIndex = 2;
            nNUMEROLabel.Text = "Número:";
            // 
            // nANDARLabel
            // 
            nANDARLabel.AutoSize = true;
            nANDARLabel.Location = new System.Drawing.Point(131, 273);
            nANDARLabel.Name = "nANDARLabel";
            nANDARLabel.Size = new System.Drawing.Size(50, 18);
            nANDARLabel.TabIndex = 4;
            nANDARLabel.Text = "Andar:";
            // 
            // nMAXPESSOASLabel
            // 
            nMAXPESSOASLabel.AutoSize = true;
            nMAXPESSOASLabel.Location = new System.Drawing.Point(52, 313);
            nMAXPESSOASLabel.Name = "nMAXPESSOASLabel";
            nMAXPESSOASLabel.Size = new System.Drawing.Size(129, 18);
            nMAXPESSOASLabel.TabIndex = 6;
            nMAXPESSOASLabel.Text = "Pessoas por quarto:";
            // 
            // nVALORBASELabel
            // 
            nVALORBASELabel.AutoSize = true;
            nVALORBASELabel.Location = new System.Drawing.Point(97, 352);
            nVALORBASELabel.Name = "nVALORBASELabel";
            nVALORBASELabel.Size = new System.Drawing.Size(84, 18);
            nVALORBASELabel.TabIndex = 8;
            nVALORBASELabel.Text = "Valor diaria:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDESCRICAODataGridViewTextBoxColumn,
            this.nNUMERODataGridViewTextBoxColumn,
            this.nANDARDataGridViewTextBoxColumn,
            this.nMAXPESSOASDataGridViewTextBoxColumn,
            this.nVALORBASEDataGridViewTextBoxColumn,
            this.cESTATUSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qUARTOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(770, 286);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cDESCRICAODataGridViewTextBoxColumn
            // 
            this.cDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "CDESCRICAO";
            this.cDESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.cDESCRICAODataGridViewTextBoxColumn.Name = "cDESCRICAODataGridViewTextBoxColumn";
            this.cDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDESCRICAODataGridViewTextBoxColumn.Width = 200;
            // 
            // nNUMERODataGridViewTextBoxColumn
            // 
            this.nNUMERODataGridViewTextBoxColumn.DataPropertyName = "NNUMERO";
            this.nNUMERODataGridViewTextBoxColumn.HeaderText = "Número";
            this.nNUMERODataGridViewTextBoxColumn.Name = "nNUMERODataGridViewTextBoxColumn";
            this.nNUMERODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nANDARDataGridViewTextBoxColumn
            // 
            this.nANDARDataGridViewTextBoxColumn.DataPropertyName = "NANDAR";
            this.nANDARDataGridViewTextBoxColumn.HeaderText = "Andar";
            this.nANDARDataGridViewTextBoxColumn.Name = "nANDARDataGridViewTextBoxColumn";
            this.nANDARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMAXPESSOASDataGridViewTextBoxColumn
            // 
            this.nMAXPESSOASDataGridViewTextBoxColumn.DataPropertyName = "NMAXPESSOAS";
            this.nMAXPESSOASDataGridViewTextBoxColumn.HeaderText = "Pessoas";
            this.nMAXPESSOASDataGridViewTextBoxColumn.Name = "nMAXPESSOASDataGridViewTextBoxColumn";
            this.nMAXPESSOASDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nVALORBASEDataGridViewTextBoxColumn
            // 
            this.nVALORBASEDataGridViewTextBoxColumn.DataPropertyName = "NVALORBASE";
            this.nVALORBASEDataGridViewTextBoxColumn.HeaderText = "Diaria";
            this.nVALORBASEDataGridViewTextBoxColumn.Name = "nVALORBASEDataGridViewTextBoxColumn";
            this.nVALORBASEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cESTATUSDataGridViewTextBoxColumn
            // 
            this.cESTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            this.cESTATUSDataGridViewTextBoxColumn.HeaderText = "Status";
            this.cESTATUSDataGridViewTextBoxColumn.Name = "cESTATUSDataGridViewTextBoxColumn";
            this.cESTATUSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUARTOBindingSource
            // 
            this.qUARTOBindingSource.DataMember = "QUARTO";
            this.qUARTOBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cDESCRICAOTextBox
            // 
            this.cDESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qUARTOBindingSource, "CDESCRICAO", true));
            this.cDESCRICAOTextBox.Location = new System.Drawing.Point(187, 70);
            this.cDESCRICAOTextBox.Multiline = true;
            this.cDESCRICAOTextBox.Name = "cDESCRICAOTextBox";
            this.cDESCRICAOTextBox.Size = new System.Drawing.Size(490, 150);
            this.cDESCRICAOTextBox.TabIndex = 1;
            // 
            // nNUMERONumericUpDown
            // 
            this.nNUMERONumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.qUARTOBindingSource, "NNUMERO", true));
            this.nNUMERONumericUpDown.Location = new System.Drawing.Point(187, 234);
            this.nNUMERONumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nNUMERONumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNUMERONumericUpDown.Name = "nNUMERONumericUpDown";
            this.nNUMERONumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nNUMERONumericUpDown.TabIndex = 3;
            this.nNUMERONumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nANDARNumericUpDown
            // 
            this.nANDARNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.qUARTOBindingSource, "NANDAR", true));
            this.nANDARNumericUpDown.Location = new System.Drawing.Point(187, 271);
            this.nANDARNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nANDARNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nANDARNumericUpDown.Name = "nANDARNumericUpDown";
            this.nANDARNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nANDARNumericUpDown.TabIndex = 5;
            this.nANDARNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nMAXPESSOASNumericUpDown
            // 
            this.nMAXPESSOASNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.qUARTOBindingSource, "NMAXPESSOAS", true));
            this.nMAXPESSOASNumericUpDown.Location = new System.Drawing.Point(187, 311);
            this.nMAXPESSOASNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nMAXPESSOASNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nMAXPESSOASNumericUpDown.Name = "nMAXPESSOASNumericUpDown";
            this.nMAXPESSOASNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nMAXPESSOASNumericUpDown.TabIndex = 7;
            this.nMAXPESSOASNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nVALORBASENumericUpDown
            // 
            this.nVALORBASENumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.qUARTOBindingSource, "NVALORBASE", true));
            this.nVALORBASENumericUpDown.DecimalPlaces = 2;
            this.nVALORBASENumericUpDown.Location = new System.Drawing.Point(187, 350);
            this.nVALORBASENumericUpDown.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nVALORBASENumericUpDown.Name = "nVALORBASENumericUpDown";
            this.nVALORBASENumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nVALORBASENumericUpDown.TabIndex = 9;
            // 
            // qUARTOTableAdapter
            // 
            this.qUARTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONSUMOTableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = this.qUARTOTableAdapter;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Andar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pessoas por quarto:";
            // 
            // npFiltroAndar
            // 
            this.npFiltroAndar.Location = new System.Drawing.Point(156, 74);
            this.npFiltroAndar.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.npFiltroAndar.Name = "npFiltroAndar";
            this.npFiltroAndar.Size = new System.Drawing.Size(120, 23);
            this.npFiltroAndar.TabIndex = 2;
            // 
            // npFiltroPessoa
            // 
            this.npFiltroPessoa.Location = new System.Drawing.Point(156, 105);
            this.npFiltroPessoa.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.npFiltroPessoa.Name = "npFiltroPessoa";
            this.npFiltroPessoa.Size = new System.Drawing.Size(120, 23);
            this.npFiltroPessoa.TabIndex = 3;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Image = global::HotelGestor.Properties.Resources.Search32x32;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(285, 74);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(149, 54);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // npFiltroDiariaFim
            // 
            this.npFiltroDiariaFim.DecimalPlaces = 2;
            this.npFiltroDiariaFim.Location = new System.Drawing.Point(314, 13);
            this.npFiltroDiariaFim.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.npFiltroDiariaFim.Name = "npFiltroDiariaFim";
            this.npFiltroDiariaFim.Size = new System.Drawing.Size(120, 23);
            this.npFiltroDiariaFim.TabIndex = 11;
            // 
            // npFiltroDiariaIni
            // 
            this.npFiltroDiariaIni.DecimalPlaces = 2;
            this.npFiltroDiariaIni.Location = new System.Drawing.Point(156, 13);
            this.npFiltroDiariaIni.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.npFiltroDiariaIni.Name = "npFiltroDiariaIni";
            this.npFiltroDiariaIni.Size = new System.Drawing.Size(120, 23);
            this.npFiltroDiariaIni.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Até";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor da Diária de:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Status:";
            // 
            // cbFiltroStatus
            // 
            this.cbFiltroStatus.FormattingEnabled = true;
            this.cbFiltroStatus.Items.AddRange(new object[] {
            "Todos",
            "Livres",
            "Ocupados",
            "Reservados"});
            this.cbFiltroStatus.Location = new System.Drawing.Point(156, 42);
            this.cbFiltroStatus.Name = "cbFiltroStatus";
            this.cbFiltroStatus.Size = new System.Drawing.Size(278, 26);
            this.cbFiltroStatus.TabIndex = 13;
            // 
            // frmQuartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmQuartos";
            this.Text = "Registro de quartos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuartos_FormClosing);
            this.Load += new System.EventHandler(this.frmQuartos_Load);
            this.tbMain.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUARTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNUMERONumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nANDARNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMAXPESSOASNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORBASENumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroAndar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroDiariaFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npFiltroDiariaIni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource qUARTOBindingSource;
        private HotelDBDataSetTableAdapters.QUARTOTableAdapter qUARTOTableAdapter;
        private System.Windows.Forms.NumericUpDown nVALORBASENumericUpDown;
        private System.Windows.Forms.NumericUpDown nMAXPESSOASNumericUpDown;
        private System.Windows.Forms.NumericUpDown nANDARNumericUpDown;
        private System.Windows.Forms.NumericUpDown nNUMERONumericUpDown;
        private System.Windows.Forms.TextBox cDESCRICAOTextBox;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNUMERODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nANDARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nMAXPESSOASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVALORBASEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cESTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbFiltroStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown npFiltroDiariaFim;
        private System.Windows.Forms.NumericUpDown npFiltroDiariaIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.NumericUpDown npFiltroPessoa;
        private System.Windows.Forms.NumericUpDown npFiltroAndar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
