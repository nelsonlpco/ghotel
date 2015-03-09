namespace HotelGestor
{
    partial class frmRelatoriosHospedes
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
            this.HOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.CLIENTETableAdapter();
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.HOTELTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.HOTELTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nNUMECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATANASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDATACADASTRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOBSERVACAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRUADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBAIRRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fOTODataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // pnFiltros
            // 
            this.pnFiltros.Controls.Add(this.button2);
            this.pnFiltros.Controls.Add(this.label6);
            this.pnFiltros.Controls.Add(this.label5);
            this.pnFiltros.Controls.Add(this.label4);
            this.pnFiltros.Controls.Add(this.label3);
            this.pnFiltros.Controls.Add(this.label2);
            this.pnFiltros.Controls.Add(this.label1);
            this.pnFiltros.Controls.Add(this.maskedTextBox3);
            this.pnFiltros.Controls.Add(this.maskedTextBox4);
            this.pnFiltros.Controls.Add(this.button1);
            this.pnFiltros.Controls.Add(this.maskedTextBox2);
            this.pnFiltros.Controls.Add(this.maskedTextBox1);
            this.pnFiltros.Controls.Add(this.textBox1);
            this.pnFiltros.Controls.Add(this.cbRelatorios);
            this.pnFiltros.Size = new System.Drawing.Size(784, 131);
            // 
            // HOTELBindingSource
            // 
            this.HOTELBindingSource.DataMember = "HOTEL";
            this.HOTELBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // cbRelatorios
            // 
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Items.AddRange(new object[] {
            "Lista de Hóspedes.",
            "Ficha do Hóspede.",
            "Lista de Aniversáriantes.",
            "Histórico do Hóspede."});
            this.cbRelatorios.Location = new System.Drawing.Point(156, 6);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(407, 26);
            this.cbRelatorios.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 23);
            this.textBox1.TabIndex = 1;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(156, 67);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(296, 67);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox2.TabIndex = 3;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Image = global::HotelGestor.Properties.Resources.Search32x32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(402, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(296, 96);
            this.maskedTextBox3.Mask = "00/00/0000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox3.TabIndex = 6;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(156, 96);
            this.maskedTextBox4.Mask = "00/00/0000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBox4.TabIndex = 5;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Relatórios:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Hóspede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Até";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Data Cadastro:";
            // 
            // button2
            // 
            this.button2.Image = global::HotelGestor.Properties.Resources.printer48x48;
            this.button2.Location = new System.Drawing.Point(569, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 113);
            this.button2.TabIndex = 13;
            this.button2.Text = "Gerar relatório";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HOTELTableAdapter
            // 
            this.HOTELTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nNUMECLIENTEDataGridViewTextBoxColumn,
            this.cNOMEDataGridViewTextBoxColumn,
            this.cCPFDataGridViewTextBoxColumn,
            this.cRGDataGridViewTextBoxColumn,
            this.dDATANASCDataGridViewTextBoxColumn,
            this.dDATACADASTRODataGridViewTextBoxColumn,
            this.cOBSERVACAODataGridViewTextBoxColumn,
            this.cCEPDataGridViewTextBoxColumn,
            this.cCIDADEDataGridViewTextBoxColumn,
            this.cUFDataGridViewTextBoxColumn,
            this.cRUADataGridViewTextBoxColumn,
            this.cBAIRRODataGridViewTextBoxColumn,
            this.cFONEDataGridViewTextBoxColumn,
            this.cFONE2DataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn,
            this.fOTODataGridViewImageColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(784, 349);
            this.dataGridView1.TabIndex = 9;
            // 
            // nNUMECLIENTEDataGridViewTextBoxColumn
            // 
            this.nNUMECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NNUMECLIENTE";
            this.nNUMECLIENTEDataGridViewTextBoxColumn.HeaderText = "NNUMECLIENTE";
            this.nNUMECLIENTEDataGridViewTextBoxColumn.Name = "nNUMECLIENTEDataGridViewTextBoxColumn";
            this.nNUMECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNOMEDataGridViewTextBoxColumn
            // 
            this.cNOMEDataGridViewTextBoxColumn.DataPropertyName = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.HeaderText = "CNOME";
            this.cNOMEDataGridViewTextBoxColumn.Name = "cNOMEDataGridViewTextBoxColumn";
            this.cNOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCPFDataGridViewTextBoxColumn
            // 
            this.cCPFDataGridViewTextBoxColumn.DataPropertyName = "CCPF";
            this.cCPFDataGridViewTextBoxColumn.HeaderText = "CCPF";
            this.cCPFDataGridViewTextBoxColumn.Name = "cCPFDataGridViewTextBoxColumn";
            this.cCPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRGDataGridViewTextBoxColumn
            // 
            this.cRGDataGridViewTextBoxColumn.DataPropertyName = "CRG";
            this.cRGDataGridViewTextBoxColumn.HeaderText = "CRG";
            this.cRGDataGridViewTextBoxColumn.Name = "cRGDataGridViewTextBoxColumn";
            this.cRGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDATANASCDataGridViewTextBoxColumn
            // 
            this.dDATANASCDataGridViewTextBoxColumn.DataPropertyName = "DDATANASC";
            this.dDATANASCDataGridViewTextBoxColumn.HeaderText = "DDATANASC";
            this.dDATANASCDataGridViewTextBoxColumn.Name = "dDATANASCDataGridViewTextBoxColumn";
            this.dDATANASCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDATACADASTRODataGridViewTextBoxColumn
            // 
            this.dDATACADASTRODataGridViewTextBoxColumn.DataPropertyName = "DDATACADASTRO";
            this.dDATACADASTRODataGridViewTextBoxColumn.HeaderText = "DDATACADASTRO";
            this.dDATACADASTRODataGridViewTextBoxColumn.Name = "dDATACADASTRODataGridViewTextBoxColumn";
            this.dDATACADASTRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOBSERVACAODataGridViewTextBoxColumn
            // 
            this.cOBSERVACAODataGridViewTextBoxColumn.DataPropertyName = "COBSERVACAO";
            this.cOBSERVACAODataGridViewTextBoxColumn.HeaderText = "COBSERVACAO";
            this.cOBSERVACAODataGridViewTextBoxColumn.Name = "cOBSERVACAODataGridViewTextBoxColumn";
            this.cOBSERVACAODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCEPDataGridViewTextBoxColumn
            // 
            this.cCEPDataGridViewTextBoxColumn.DataPropertyName = "CCEP";
            this.cCEPDataGridViewTextBoxColumn.HeaderText = "CCEP";
            this.cCEPDataGridViewTextBoxColumn.Name = "cCEPDataGridViewTextBoxColumn";
            this.cCEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCIDADEDataGridViewTextBoxColumn
            // 
            this.cCIDADEDataGridViewTextBoxColumn.DataPropertyName = "CCIDADE";
            this.cCIDADEDataGridViewTextBoxColumn.HeaderText = "CCIDADE";
            this.cCIDADEDataGridViewTextBoxColumn.Name = "cCIDADEDataGridViewTextBoxColumn";
            this.cCIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cUFDataGridViewTextBoxColumn
            // 
            this.cUFDataGridViewTextBoxColumn.DataPropertyName = "CUF";
            this.cUFDataGridViewTextBoxColumn.HeaderText = "CUF";
            this.cUFDataGridViewTextBoxColumn.Name = "cUFDataGridViewTextBoxColumn";
            this.cUFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cRUADataGridViewTextBoxColumn
            // 
            this.cRUADataGridViewTextBoxColumn.DataPropertyName = "CRUA";
            this.cRUADataGridViewTextBoxColumn.HeaderText = "CRUA";
            this.cRUADataGridViewTextBoxColumn.Name = "cRUADataGridViewTextBoxColumn";
            this.cRUADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cBAIRRODataGridViewTextBoxColumn
            // 
            this.cBAIRRODataGridViewTextBoxColumn.DataPropertyName = "CBAIRRO";
            this.cBAIRRODataGridViewTextBoxColumn.HeaderText = "CBAIRRO";
            this.cBAIRRODataGridViewTextBoxColumn.Name = "cBAIRRODataGridViewTextBoxColumn";
            this.cBAIRRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFONEDataGridViewTextBoxColumn
            // 
            this.cFONEDataGridViewTextBoxColumn.DataPropertyName = "CFONE";
            this.cFONEDataGridViewTextBoxColumn.HeaderText = "CFONE";
            this.cFONEDataGridViewTextBoxColumn.Name = "cFONEDataGridViewTextBoxColumn";
            this.cFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cFONE2DataGridViewTextBoxColumn
            // 
            this.cFONE2DataGridViewTextBoxColumn.DataPropertyName = "CFONE2";
            this.cFONE2DataGridViewTextBoxColumn.HeaderText = "CFONE2";
            this.cFONE2DataGridViewTextBoxColumn.Name = "cFONE2DataGridViewTextBoxColumn";
            this.cFONE2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fOTODataGridViewImageColumn
            // 
            this.fOTODataGridViewImageColumn.DataPropertyName = "FOTO";
            this.fOTODataGridViewImageColumn.HeaderText = "FOTO";
            this.fOTODataGridViewImageColumn.Name = "fOTODataGridViewImageColumn";
            this.fOTODataGridViewImageColumn.ReadOnly = true;
            // 
            // frmRelatoriosHospedes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmRelatoriosHospedes";
            this.Text = "Relatórios de Hóspedes";
            this.Load += new System.EventHandler(this.frmRelatoriosHospedes_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.pnFiltros, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private HotelDBDataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbRelatorios;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource HOTELBindingSource;
        private HotelDBDataSetTableAdapters.HOTELTableAdapter HOTELTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nNUMECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATANASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDATACADASTRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOBSERVACAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRUADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBAIRRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fOTODataGridViewImageColumn;
    }
}
