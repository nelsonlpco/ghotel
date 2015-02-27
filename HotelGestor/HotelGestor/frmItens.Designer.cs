﻿namespace HotelGestor
{
    partial class frmItens
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
            System.Windows.Forms.Label nVALORITEMLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.cDESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nVALORITEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMCONSUMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.iTEMCONSUMOTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.ITEMCONSUMOTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cDESCRICAOTextBox = new System.Windows.Forms.TextBox();
            this.nVALORITEMNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            cDESCRICAOLabel = new System.Windows.Forms.Label();
            nVALORITEMLabel = new System.Windows.Forms.Label();
            this.tbMain.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMCONSUMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORITEMNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbMain_Selecting);
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.dgvItens);
            this.tbCadastro.Controls.SetChildIndex(this.pnFiltros, 0);
            this.tbCadastro.Controls.SetChildIndex(this.dgvItens, 0);
            // 
            // pnFiltros
            // 
            this.pnFiltros.Controls.Add(this.txtFiltro);
            this.pnFiltros.Controls.Add(this.label1);
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(nVALORITEMLabel);
            this.tbConsulta.Controls.Add(this.nVALORITEMNumericUpDown);
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
            cDESCRICAOLabel.Location = new System.Drawing.Point(125, 106);
            cDESCRICAOLabel.Name = "cDESCRICAOLabel";
            cDESCRICAOLabel.Size = new System.Drawing.Size(72, 18);
            cDESCRICAOLabel.TabIndex = 0;
            cDESCRICAOLabel.Text = "Descrição:";
            // 
            // nVALORITEMLabel
            // 
            nVALORITEMLabel.AutoSize = true;
            nVALORITEMLabel.Location = new System.Drawing.Point(103, 180);
            nVALORITEMLabel.Name = "nVALORITEMLabel";
            nVALORITEMLabel.Size = new System.Drawing.Size(94, 18);
            nVALORITEMLabel.TabIndex = 2;
            nVALORITEMLabel.Text = "Valor do Item:";
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cDESCRICAODataGridViewTextBoxColumn,
            this.nVALORITEMDataGridViewTextBoxColumn});
            this.dgvItens.DataSource = this.iTEMCONSUMOBindingSource;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(3, 96);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(770, 338);
            this.dgvItens.TabIndex = 1;
            this.dgvItens.DoubleClick += new System.EventHandler(this.dgvItens_DoubleClick);
            // 
            // cDESCRICAODataGridViewTextBoxColumn
            // 
            this.cDESCRICAODataGridViewTextBoxColumn.DataPropertyName = "CDESCRICAO";
            this.cDESCRICAODataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.cDESCRICAODataGridViewTextBoxColumn.Name = "cDESCRICAODataGridViewTextBoxColumn";
            this.cDESCRICAODataGridViewTextBoxColumn.ReadOnly = true;
            this.cDESCRICAODataGridViewTextBoxColumn.Width = 300;
            // 
            // nVALORITEMDataGridViewTextBoxColumn
            // 
            this.nVALORITEMDataGridViewTextBoxColumn.DataPropertyName = "NVALORITEM";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.nVALORITEMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.nVALORITEMDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.nVALORITEMDataGridViewTextBoxColumn.Name = "nVALORITEMDataGridViewTextBoxColumn";
            this.nVALORITEMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTEMCONSUMOBindingSource
            // 
            this.iTEMCONSUMOBindingSource.DataMember = "ITEMCONSUMO";
            this.iTEMCONSUMOBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMCONSUMOTableAdapter
            // 
            this.iTEMCONSUMOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.CONSUMOTableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = null;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = this.iTEMCONSUMOTableAdapter;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cDESCRICAOTextBox
            // 
            this.cDESCRICAOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iTEMCONSUMOBindingSource, "CDESCRICAO", true));
            this.cDESCRICAOTextBox.Location = new System.Drawing.Point(199, 104);
            this.cDESCRICAOTextBox.Name = "cDESCRICAOTextBox";
            this.cDESCRICAOTextBox.Size = new System.Drawing.Size(458, 23);
            this.cDESCRICAOTextBox.TabIndex = 1;
            // 
            // nVALORITEMNumericUpDown
            // 
            this.nVALORITEMNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.iTEMCONSUMOBindingSource, "NVALORITEM", true));
            this.nVALORITEMNumericUpDown.DecimalPlaces = 2;
            this.nVALORITEMNumericUpDown.Location = new System.Drawing.Point(199, 178);
            this.nVALORITEMNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nVALORITEMNumericUpDown.Name = "nVALORITEMNumericUpDown";
            this.nVALORITEMNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.nVALORITEMNumericUpDown.TabIndex = 3;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(265, 35);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(372, 23);
            this.txtFiltro.TabIndex = 3;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Item de consumo:";
            // 
            // frmItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmItens";
            this.Text = "Registro de Itens de consumo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmItens_FormClosing);
            this.Load += new System.EventHandler(this.frmItens_Load);
            this.tbMain.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.pnFiltros.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMCONSUMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nVALORITEMNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItens;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource iTEMCONSUMOBindingSource;
        private HotelDBDataSetTableAdapters.ITEMCONSUMOTableAdapter iTEMCONSUMOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVALORITEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown nVALORITEMNumericUpDown;
        private System.Windows.Forms.TextBox cDESCRICAOTextBox;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
    }
}