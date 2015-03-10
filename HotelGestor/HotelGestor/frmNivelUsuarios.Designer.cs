namespace HotelGestor
{
    partial class frmNivelUsuarios
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
            System.Windows.Forms.Label cdescricaoLabel;
            System.Windows.Forms.Label nnivelLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cdescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnivelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.aTORESTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.ATORESTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cdescricaoTextBox = new System.Windows.Forms.TextBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nnivelTextBox = new System.Windows.Forms.TextBox();
            cdescricaoLabel = new System.Windows.Forms.Label();
            nnivelLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
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
            this.tbConsulta.Controls.Add(this.nnivelTextBox);
            this.tbConsulta.Controls.Add(nnivelLabel);
            this.tbConsulta.Controls.Add(cdescricaoLabel);
            this.tbConsulta.Controls.Add(this.cdescricaoTextBox);
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
            this.pnFiltros.Controls.Add(this.label1);
            this.pnFiltros.Size = new System.Drawing.Size(770, 62);
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            // 
            // cdescricaoLabel
            // 
            cdescricaoLabel.AutoSize = true;
            cdescricaoLabel.Location = new System.Drawing.Point(204, 189);
            cdescricaoLabel.Name = "cdescricaoLabel";
            cdescricaoLabel.Size = new System.Drawing.Size(72, 18);
            cdescricaoLabel.TabIndex = 0;
            cdescricaoLabel.Text = "Descrição:";
            // 
            // nnivelLabel
            // 
            nnivelLabel.AutoSize = true;
            nnivelLabel.Location = new System.Drawing.Point(232, 243);
            nnivelLabel.Name = "nnivelLabel";
            nnivelLabel.Size = new System.Drawing.Size(44, 18);
            nnivelLabel.TabIndex = 2;
            nnivelLabel.Text = "Nivel:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdescricaoDataGridViewTextBoxColumn,
            this.nnivelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aTORESBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 378);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cdescricaoDataGridViewTextBoxColumn
            // 
            this.cdescricaoDataGridViewTextBoxColumn.DataPropertyName = "cdescricao";
            this.cdescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.cdescricaoDataGridViewTextBoxColumn.Name = "cdescricaoDataGridViewTextBoxColumn";
            this.cdescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdescricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // nnivelDataGridViewTextBoxColumn
            // 
            this.nnivelDataGridViewTextBoxColumn.DataPropertyName = "nnivel";
            this.nnivelDataGridViewTextBoxColumn.HeaderText = "Nível";
            this.nnivelDataGridViewTextBoxColumn.Name = "nnivelDataGridViewTextBoxColumn";
            this.nnivelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aTORESBindingSource
            // 
            this.aTORESBindingSource.DataMember = "ATORES";
            this.aTORESBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aTORESTableAdapter
            // 
            this.aTORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ATORESTableAdapter = this.aTORESTableAdapter;
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
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cdescricaoTextBox
            // 
            this.cdescricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTORESBindingSource, "cdescricao", true));
            this.cdescricaoTextBox.Location = new System.Drawing.Point(276, 187);
            this.cdescricaoTextBox.Name = "cdescricaoTextBox";
            this.cdescricaoTextBox.Size = new System.Drawing.Size(310, 23);
            this.cdescricaoTextBox.TabIndex = 1;
            this.cdescricaoTextBox.Leave += new System.EventHandler(this.cdescricaoTextBox_Leave);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(227, 19);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(372, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Nível:";
            // 
            // nnivelTextBox
            // 
            this.nnivelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aTORESBindingSource, "nnivel", true));
            this.nnivelTextBox.Location = new System.Drawing.Point(276, 238);
            this.nnivelTextBox.Name = "nnivelTextBox";
            this.nnivelTextBox.Size = new System.Drawing.Size(100, 23);
            this.nnivelTextBox.TabIndex = 4;
            // 
            // frmNivelUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmNivelUsuarios";
            this.Text = "Tipos de Usuários";
            this.Load += new System.EventHandler(this.frmNivelUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource aTORESBindingSource;
        private HotelDBDataSetTableAdapters.ATORESTableAdapter aTORESTableAdapter;
        private System.Windows.Forms.TextBox cdescricaoTextBox;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnivelDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox nnivelTextBox;
    }
}
