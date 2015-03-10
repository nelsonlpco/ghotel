namespace HotelGestor
{
    partial class frmCadUsuarios
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
            System.Windows.Forms.Label cNICKLabel;
            System.Windows.Forms.Label cSENHALabel;
            System.Windows.Forms.Label cEMAILLabel;
            System.Windows.Forms.Label cFONELabel;
            System.Windows.Forms.Label cFONE2Label;
            System.Windows.Forms.Label label1;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFONE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnCamera = new System.Windows.Forms.Button();
            this.uSUARIOSTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.USUARIOSTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.fOTOPictureBox = new System.Windows.Forms.PictureBox();
            this.cNOMETextBox = new System.Windows.Forms.TextBox();
            this.cNICKTextBox = new System.Windows.Forms.TextBox();
            this.cSENHATextBox = new System.Windows.Forms.TextBox();
            this.cEMAILTextBox = new System.Windows.Forms.TextBox();
            this.cFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONE2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nATORComboBox = new System.Windows.Forms.ComboBox();
            this.aTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aTORESTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.ATORESTableAdapter();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            cNOMELabel = new System.Windows.Forms.Label();
            cNICKLabel = new System.Windows.Forms.Label();
            cSENHALabel = new System.Windows.Forms.Label();
            cEMAILLabel = new System.Windows.Forms.Label();
            cFONELabel = new System.Windows.Forms.Label();
            cFONE2Label = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTORESBindingSource)).BeginInit();
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
            this.btnGravar.TabIndex = 0;
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
            this.tbConsulta.Controls.Add(label1);
            this.tbConsulta.Controls.Add(this.nATORComboBox);
            this.tbConsulta.Controls.Add(this.cFONE2MaskedTextBox);
            this.tbConsulta.Controls.Add(this.cFONEMaskedTextBox);
            this.tbConsulta.Controls.Add(this.cEMAILTextBox);
            this.tbConsulta.Controls.Add(this.cSENHATextBox);
            this.tbConsulta.Controls.Add(this.cNICKTextBox);
            this.tbConsulta.Controls.Add(this.cNOMETextBox);
            this.tbConsulta.Controls.Add(this.fOTOPictureBox);
            this.tbConsulta.Controls.Add(this.panel2);
            this.tbConsulta.Controls.Add(cFONE2Label);
            this.tbConsulta.Controls.Add(cFONELabel);
            this.tbConsulta.Controls.Add(cEMAILLabel);
            this.tbConsulta.Controls.Add(cSENHALabel);
            this.tbConsulta.Controls.Add(cNICKLabel);
            this.tbConsulta.Controls.Add(cNOMELabel);
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
            this.pnFiltros.Controls.Add(this.txtFiltro);
            this.pnFiltros.Controls.Add(this.label2);
            this.pnFiltros.Size = new System.Drawing.Size(770, 67);
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            // 
            // cNOMELabel
            // 
            cNOMELabel.AutoSize = true;
            cNOMELabel.Location = new System.Drawing.Point(106, 90);
            cNOMELabel.Name = "cNOMELabel";
            cNOMELabel.Size = new System.Drawing.Size(47, 18);
            cNOMELabel.TabIndex = 2;
            cNOMELabel.Text = "Nome:";
            // 
            // cNICKLabel
            // 
            cNICKLabel.AutoSize = true;
            cNICKLabel.Location = new System.Drawing.Point(93, 125);
            cNICKLabel.Name = "cNICKLabel";
            cNICKLabel.Size = new System.Drawing.Size(60, 18);
            cNICKLabel.TabIndex = 4;
            cNICKLabel.Text = "Usuário:";
            // 
            // cSENHALabel
            // 
            cSENHALabel.AutoSize = true;
            cSENHALabel.Location = new System.Drawing.Point(103, 160);
            cSENHALabel.Name = "cSENHALabel";
            cSENHALabel.Size = new System.Drawing.Size(50, 18);
            cSENHALabel.TabIndex = 6;
            cSENHALabel.Text = "Senha:";
            // 
            // cEMAILLabel
            // 
            cEMAILLabel.AutoSize = true;
            cEMAILLabel.Location = new System.Drawing.Point(102, 195);
            cEMAILLabel.Name = "cEMAILLabel";
            cEMAILLabel.Size = new System.Drawing.Size(51, 18);
            cEMAILLabel.TabIndex = 8;
            cEMAILLabel.Text = "E-mail:";
            // 
            // cFONELabel
            // 
            cFONELabel.AutoSize = true;
            cFONELabel.Location = new System.Drawing.Point(87, 230);
            cFONELabel.Name = "cFONELabel";
            cFONELabel.Size = new System.Drawing.Size(66, 18);
            cFONELabel.TabIndex = 10;
            cFONELabel.Text = "Telefone:";
            // 
            // cFONE2Label
            // 
            cFONE2Label.AutoSize = true;
            cFONE2Label.Location = new System.Drawing.Point(75, 265);
            cFONE2Label.Name = "cFONE2Label";
            cFONE2Label.Size = new System.Drawing.Size(78, 18);
            cFONE2Label.TabIndex = 12;
            cFONE2Label.Text = "Telefone 2:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(63, 304);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 18);
            label1.TabIndex = 47;
            label1.Text = "Tipo usuário:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNOMEDataGridViewTextBoxColumn,
            this.cEMAILDataGridViewTextBoxColumn,
            this.cFONEDataGridViewTextBoxColumn,
            this.cFONE2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSUARIOSBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 373);
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
            // cEMAILDataGridViewTextBoxColumn
            // 
            this.cEMAILDataGridViewTextBoxColumn.DataPropertyName = "CEMAIL";
            this.cEMAILDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.cEMAILDataGridViewTextBoxColumn.Name = "cEMAILDataGridViewTextBoxColumn";
            this.cEMAILDataGridViewTextBoxColumn.ReadOnly = true;
            this.cEMAILDataGridViewTextBoxColumn.Width = 250;
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
            // uSUARIOSBindingSource
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
            this.uSUARIOSBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnArquivo);
            this.panel2.Controls.Add(this.btnCamera);
            this.panel2.Location = new System.Drawing.Point(492, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 50);
            this.panel2.TabIndex = 38;
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
            // uSUARIOSTableAdapter
            // 
            this.uSUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATORESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.faturaTableAdapter = null;
            this.tableAdapterManager.FaturaXItensTableAdapter = null;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.HOSPEDAGEMTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = this.uSUARIOSTableAdapter;
            // 
            // fOTOPictureBox
            // 
            this.fOTOPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fOTOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.uSUARIOSBindingSource, "FOTO", true));
            this.fOTOPictureBox.Location = new System.Drawing.Point(492, 88);
            this.fOTOPictureBox.Name = "fOTOPictureBox";
            this.fOTOPictureBox.Size = new System.Drawing.Size(245, 148);
            this.fOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fOTOPictureBox.TabIndex = 39;
            this.fOTOPictureBox.TabStop = false;
            // 
            // cNOMETextBox
            // 
            this.cNOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CNOME", true));
            this.cNOMETextBox.Location = new System.Drawing.Point(158, 88);
            this.cNOMETextBox.Name = "cNOMETextBox";
            this.cNOMETextBox.Size = new System.Drawing.Size(291, 23);
            this.cNOMETextBox.TabIndex = 0;
            this.cNOMETextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cNICKTextBox
            // 
            this.cNICKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CNICK", true));
            this.cNICKTextBox.Location = new System.Drawing.Point(158, 123);
            this.cNICKTextBox.MaxLength = 24;
            this.cNICKTextBox.Name = "cNICKTextBox";
            this.cNICKTextBox.Size = new System.Drawing.Size(213, 23);
            this.cNICKTextBox.TabIndex = 1;
            // 
            // cSENHATextBox
            // 
            this.cSENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CSENHA", true));
            this.cSENHATextBox.Location = new System.Drawing.Point(158, 158);
            this.cSENHATextBox.MaxLength = 14;
            this.cSENHATextBox.Name = "cSENHATextBox";
            this.cSENHATextBox.PasswordChar = '*';
            this.cSENHATextBox.Size = new System.Drawing.Size(213, 23);
            this.cSENHATextBox.TabIndex = 2;
            // 
            // cEMAILTextBox
            // 
            this.cEMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CEMAIL", true));
            this.cEMAILTextBox.Location = new System.Drawing.Point(158, 193);
            this.cEMAILTextBox.Name = "cEMAILTextBox";
            this.cEMAILTextBox.Size = new System.Drawing.Size(291, 23);
            this.cEMAILTextBox.TabIndex = 3;
            // 
            // cFONEMaskedTextBox
            // 
            this.cFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CFONE", true));
            this.cFONEMaskedTextBox.Location = new System.Drawing.Point(158, 228);
            this.cFONEMaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONEMaskedTextBox.Name = "cFONEMaskedTextBox";
            this.cFONEMaskedTextBox.Size = new System.Drawing.Size(115, 23);
            this.cFONEMaskedTextBox.TabIndex = 4;
            // 
            // cFONE2MaskedTextBox
            // 
            this.cFONE2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "CFONE2", true));
            this.cFONE2MaskedTextBox.Location = new System.Drawing.Point(158, 263);
            this.cFONE2MaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONE2MaskedTextBox.Name = "cFONE2MaskedTextBox";
            this.cFONE2MaskedTextBox.Size = new System.Drawing.Size(115, 23);
            this.cFONE2MaskedTextBox.TabIndex = 5;
            // 
            // nATORComboBox
            // 
            this.nATORComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.uSUARIOSBindingSource, "NATOR", true));
            this.nATORComboBox.DataSource = this.aTORESBindingSource;
            this.nATORComboBox.DisplayMember = "cdescricao";
            this.nATORComboBox.FormattingEnabled = true;
            this.nATORComboBox.Location = new System.Drawing.Point(158, 300);
            this.nATORComboBox.Name = "nATORComboBox";
            this.nATORComboBox.Size = new System.Drawing.Size(291, 26);
            this.nATORComboBox.TabIndex = 6;
            this.nATORComboBox.ValueMember = "idator";
            // 
            // aTORESBindingSource
            // 
            this.aTORESBindingSource.DataMember = "ATORES";
            this.aTORESBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // aTORESTableAdapter
            // 
            this.aTORESTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(262, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(372, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisar Usuários:";
            // 
            // frmCadUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadUsuarios";
            this.Load += new System.EventHandler(this.frmCadUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fOTOPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTORESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private HotelDBDataSetTableAdapters.USUARIOSTableAdapter uSUARIOSTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ComboBox nATORComboBox;
        private System.Windows.Forms.MaskedTextBox cFONE2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cFONEMaskedTextBox;
        private System.Windows.Forms.TextBox cEMAILTextBox;
        private System.Windows.Forms.TextBox cSENHATextBox;
        private System.Windows.Forms.TextBox cNICKTextBox;
        private System.Windows.Forms.TextBox cNOMETextBox;
        private System.Windows.Forms.PictureBox fOTOPictureBox;
        private System.Windows.Forms.BindingSource aTORESBindingSource;
        private HotelDBDataSetTableAdapters.ATORESTableAdapter aTORESTableAdapter;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFONE2DataGridViewTextBoxColumn;
    }
}
