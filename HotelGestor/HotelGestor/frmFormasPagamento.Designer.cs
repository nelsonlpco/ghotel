namespace HotelGestor
{
    partial class frmFormasPagamento
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
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.fORMASDEPAGAMENTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORMASDEPAGAMENTOTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.FORMASDEPAGAMENTOTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cDESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            cDESCRICAOLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASDEPAGAMENTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.tbConsulta.Controls.Add(cDESCRICAOLabel);
            this.tbConsulta.Controls.Add(this.cDESCRICAOTextBox);
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
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // cDESCRICAOLabel
            // 
            cDESCRICAOLabel.AutoSize = true;
            cDESCRICAOLabel.Location = new System.Drawing.Point(110, 103);
            cDESCRICAOLabel.Name = "cDESCRICAOLabel";
            cDESCRICAOLabel.Size = new System.Drawing.Size(72, 18);
            cDESCRICAOLabel.TabIndex = 0;
            cDESCRICAOLabel.Text = "Descrição:";
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORMASDEPAGAMENTOBindingSource
            // 
            this.fORMASDEPAGAMENTOBindingSource.DataMember = "FORMASDEPAGAMENTO";
            this.fORMASDEPAGAMENTOBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // fORMASDEPAGAMENTOTableAdapter
            // 
            this.fORMASDEPAGAMENTOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONSUMOTableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = this.fORMASDEPAGAMENTOTableAdapter;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cDESCRICAOTextBox
            // 
            this.cDESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORMASDEPAGAMENTOBindingSource, "CDESCRICAO", true));
            this.cDESCRICAOTextBox.Location = new System.Drawing.Point(204, 100);
            this.cDESCRICAOTextBox.Name = "cDESCRICAOTextBox";
            this.cDESCRICAOTextBox.Size = new System.Drawing.Size(426, 23);
            this.cDESCRICAOTextBox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDESCRICAODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fORMASDEPAGAMENTOBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 343);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // cDESCRICAODataGridViewTextBoxColumn
            // 
            this.cDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "CDESCRICAO";
            this.cDESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.cDESCRICAODataGridViewTextBoxColumn.Name = "cDESCRICAODataGridViewTextBoxColumn";
            this.cDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDESCRICAODataGridViewTextBoxColumn.Width = 500;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(284, 31);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(372, 23);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisar forma de pagamento:";
            // 
            // frmFormasPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmFormasPagamento";
            this.Text = "Registro de formas de pagamento";
            this.Load += new System.EventHandler(this.frmFormasPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORMASDEPAGAMENTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource fORMASDEPAGAMENTOBindingSource;
        private HotelDBDataSetTableAdapters.FORMASDEPAGAMENTOTableAdapter fORMASDEPAGAMENTOTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cDESCRICAOTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;

        
    }
}
