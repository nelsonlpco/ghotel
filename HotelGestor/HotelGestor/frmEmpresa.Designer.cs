namespace HotelGestor
{
    partial class frmEmpresa
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
            System.Windows.Forms.Label cCNPJLabel;
            System.Windows.Forms.Label cINSCLabel;
            System.Windows.Forms.Label cFONELabel;
            System.Windows.Forms.Label cFONE2Label;
            System.Windows.Forms.Label cFONE3Label;
            System.Windows.Forms.Label cEMAILSLabel;
            System.Windows.Forms.Label cCEPLabel;
            System.Windows.Forms.Label cCIDADELabel;
            System.Windows.Forms.Label cUFLabel;
            System.Windows.Forms.Label cBAIRROLabel;
            System.Windows.Forms.Label cENDERECOLabel;
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.HOTELTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.cNOMETextBox = new System.Windows.Forms.TextBox();
            this.cCNPJMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cINSCTextBox = new System.Windows.Forms.TextBox();
            this.cFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONE2MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cFONE3MaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cEMAILSTextBox = new System.Windows.Forms.TextBox();
            this.cCEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cCIDADETextBox = new System.Windows.Forms.TextBox();
            this.cUFTextBox = new System.Windows.Forms.TextBox();
            this.cBAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cENDERECOTextBox = new System.Windows.Forms.TextBox();
            this.lOGOPictureBox = new System.Windows.Forms.PictureBox();
            this.btnArquivo = new System.Windows.Forms.Button();
            this.btnBuscaCep = new System.Windows.Forms.Button();
            cNOMELabel = new System.Windows.Forms.Label();
            cCNPJLabel = new System.Windows.Forms.Label();
            cINSCLabel = new System.Windows.Forms.Label();
            cFONELabel = new System.Windows.Forms.Label();
            cFONE2Label = new System.Windows.Forms.Label();
            cFONE3Label = new System.Windows.Forms.Label();
            cEMAILSLabel = new System.Windows.Forms.Label();
            cCEPLabel = new System.Windows.Forms.Label();
            cCIDADELabel = new System.Windows.Forms.Label();
            cUFLabel = new System.Windows.Forms.Label();
            cBAIRROLabel = new System.Windows.Forms.Label();
            cENDERECOLabel = new System.Windows.Forms.Label();
            this.tbMain.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGOPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tbConsulta
            // 
            this.tbConsulta.AutoScroll = true;
            this.tbConsulta.Controls.Add(this.btnBuscaCep);
            this.tbConsulta.Controls.Add(this.btnArquivo);
            this.tbConsulta.Controls.Add(cNOMELabel);
            this.tbConsulta.Controls.Add(this.cNOMETextBox);
            this.tbConsulta.Controls.Add(cCNPJLabel);
            this.tbConsulta.Controls.Add(this.cCNPJMaskedTextBox);
            this.tbConsulta.Controls.Add(cINSCLabel);
            this.tbConsulta.Controls.Add(this.cINSCTextBox);
            this.tbConsulta.Controls.Add(cFONELabel);
            this.tbConsulta.Controls.Add(this.cFONEMaskedTextBox);
            this.tbConsulta.Controls.Add(cFONE2Label);
            this.tbConsulta.Controls.Add(this.cFONE2MaskedTextBox);
            this.tbConsulta.Controls.Add(cFONE3Label);
            this.tbConsulta.Controls.Add(this.cFONE3MaskedTextBox);
            this.tbConsulta.Controls.Add(cEMAILSLabel);
            this.tbConsulta.Controls.Add(this.cEMAILSTextBox);
            this.tbConsulta.Controls.Add(cCEPLabel);
            this.tbConsulta.Controls.Add(this.cCEPMaskedTextBox);
            this.tbConsulta.Controls.Add(cCIDADELabel);
            this.tbConsulta.Controls.Add(this.cCIDADETextBox);
            this.tbConsulta.Controls.Add(cUFLabel);
            this.tbConsulta.Controls.Add(this.cUFTextBox);
            this.tbConsulta.Controls.Add(cBAIRROLabel);
            this.tbConsulta.Controls.Add(this.cBAIRROTextBox);
            this.tbConsulta.Controls.Add(cENDERECOLabel);
            this.tbConsulta.Controls.Add(this.cENDERECOTextBox);
            this.tbConsulta.Controls.Add(this.lOGOPictureBox);
            this.tbConsulta.Text = "Dados";
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.FlatAppearance.BorderSize = 0;
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.Visible = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // cNOMELabel
            // 
            cNOMELabel.AutoSize = true;
            cNOMELabel.Location = new System.Drawing.Point(39, 44);
            cNOMELabel.Name = "cNOMELabel";
            cNOMELabel.Size = new System.Drawing.Size(103, 18);
            cNOMELabel.TabIndex = 2;
            cNOMELabel.Text = "Nome/Fantasia:";
            // 
            // cCNPJLabel
            // 
            cCNPJLabel.AutoSize = true;
            cCNPJLabel.Location = new System.Drawing.Point(97, 75);
            cCNPJLabel.Name = "cCNPJLabel";
            cCNPJLabel.Size = new System.Drawing.Size(45, 18);
            cCNPJLabel.TabIndex = 4;
            cCNPJLabel.Text = "CNPJ:";
            // 
            // cINSCLabel
            // 
            cINSCLabel.AutoSize = true;
            cINSCLabel.Location = new System.Drawing.Point(17, 107);
            cINSCLabel.Name = "cINSCLabel";
            cINSCLabel.Size = new System.Drawing.Size(125, 18);
            cINSCLabel.TabIndex = 6;
            cINSCLabel.Text = "Inscrição estadual:";
            // 
            // cFONELabel
            // 
            cFONELabel.AutoSize = true;
            cFONELabel.Location = new System.Drawing.Point(77, 136);
            cFONELabel.Name = "cFONELabel";
            cFONELabel.Size = new System.Drawing.Size(65, 18);
            cFONELabel.TabIndex = 8;
            cFONELabel.Text = "Telefone:";
            // 
            // cFONE2Label
            // 
            cFONE2Label.AutoSize = true;
            cFONE2Label.Location = new System.Drawing.Point(291, 136);
            cFONE2Label.Name = "cFONE2Label";
            cFONE2Label.Size = new System.Drawing.Size(77, 18);
            cFONE2Label.TabIndex = 10;
            cFONE2Label.Text = "Telefone 2:";
            // 
            // cFONE3Label
            // 
            cFONE3Label.AutoSize = true;
            cFONE3Label.Location = new System.Drawing.Point(65, 163);
            cFONE3Label.Name = "cFONE3Label";
            cFONE3Label.Size = new System.Drawing.Size(77, 18);
            cFONE3Label.TabIndex = 12;
            cFONE3Label.Text = "Telefone 3:";
            // 
            // cEMAILSLabel
            // 
            cEMAILSLabel.AutoSize = true;
            cEMAILSLabel.Location = new System.Drawing.Point(90, 195);
            cEMAILSLabel.Name = "cEMAILSLabel";
            cEMAILSLabel.Size = new System.Drawing.Size(52, 18);
            cEMAILSLabel.TabIndex = 14;
            cEMAILSLabel.Text = "Emails:";
            // 
            // cCEPLabel
            // 
            cCEPLabel.AutoSize = true;
            cCEPLabel.Location = new System.Drawing.Point(106, 309);
            cCEPLabel.Name = "cCEPLabel";
            cCEPLabel.Size = new System.Drawing.Size(36, 18);
            cCEPLabel.TabIndex = 16;
            cCEPLabel.Text = "CEP:";
            // 
            // cCIDADELabel
            // 
            cCIDADELabel.AutoSize = true;
            cCIDADELabel.Location = new System.Drawing.Point(87, 338);
            cCIDADELabel.Name = "cCIDADELabel";
            cCIDADELabel.Size = new System.Drawing.Size(55, 18);
            cCIDADELabel.TabIndex = 18;
            cCIDADELabel.Text = "Cidade:";
            // 
            // cUFLabel
            // 
            cUFLabel.AutoSize = true;
            cUFLabel.Location = new System.Drawing.Point(624, 338);
            cUFLabel.Name = "cUFLabel";
            cUFLabel.Size = new System.Drawing.Size(30, 18);
            cUFLabel.TabIndex = 20;
            cUFLabel.Text = "UF:";
            // 
            // cBAIRROLabel
            // 
            cBAIRROLabel.AutoSize = true;
            cBAIRROLabel.Location = new System.Drawing.Point(91, 368);
            cBAIRROLabel.Name = "cBAIRROLabel";
            cBAIRROLabel.Size = new System.Drawing.Size(51, 18);
            cBAIRROLabel.TabIndex = 22;
            cBAIRROLabel.Text = "Bairro:";
            // 
            // cENDERECOLabel
            // 
            cENDERECOLabel.AutoSize = true;
            cENDERECOLabel.Location = new System.Drawing.Point(72, 397);
            cENDERECOLabel.Name = "cENDERECOLabel";
            cENDERECOLabel.Size = new System.Drawing.Size(70, 18);
            cENDERECOLabel.TabIndex = 24;
            cENDERECOLabel.Text = "Endereço:";
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTELBindingSource
            // 
            this.hOTELBindingSource.DataMember = "HOTEL";
            this.hOTELBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hOTELTableAdapter
            // 
            this.hOTELTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = this.hOTELTableAdapter;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // cNOMETextBox
            // 
            this.cNOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CNOME", true));
            this.cNOMETextBox.Location = new System.Drawing.Point(148, 41);
            this.cNOMETextBox.Name = "cNOMETextBox";
            this.cNOMETextBox.Size = new System.Drawing.Size(407, 23);
            this.cNOMETextBox.TabIndex = 0;
            this.cNOMETextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cCNPJMaskedTextBox
            // 
            this.cCNPJMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CCNPJ", true));
            this.cCNPJMaskedTextBox.Location = new System.Drawing.Point(148, 72);
            this.cCNPJMaskedTextBox.Mask = "999.999.999/9999-99";
            this.cCNPJMaskedTextBox.Name = "cCNPJMaskedTextBox";
            this.cCNPJMaskedTextBox.Size = new System.Drawing.Size(227, 23);
            this.cCNPJMaskedTextBox.TabIndex = 1;
            this.cCNPJMaskedTextBox.Click += new System.EventHandler(this.cCNPJMaskedTextBox_Click);
            // 
            // cINSCTextBox
            // 
            this.cINSCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CINSC", true));
            this.cINSCTextBox.Location = new System.Drawing.Point(148, 104);
            this.cINSCTextBox.Name = "cINSCTextBox";
            this.cINSCTextBox.Size = new System.Drawing.Size(227, 23);
            this.cINSCTextBox.TabIndex = 2;
            this.cINSCTextBox.Leave += new System.EventHandler(this.cINSCTextBox_Leave);
            // 
            // cFONEMaskedTextBox
            // 
            this.cFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CFONE", true));
            this.cFONEMaskedTextBox.Location = new System.Drawing.Point(148, 133);
            this.cFONEMaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONEMaskedTextBox.Name = "cFONEMaskedTextBox";
            this.cFONEMaskedTextBox.Size = new System.Drawing.Size(132, 23);
            this.cFONEMaskedTextBox.TabIndex = 3;
            this.cFONEMaskedTextBox.Click += new System.EventHandler(this.cFONEMaskedTextBox_Click);
            // 
            // cFONE2MaskedTextBox
            // 
            this.cFONE2MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CFONE2", true));
            this.cFONE2MaskedTextBox.Location = new System.Drawing.Point(376, 133);
            this.cFONE2MaskedTextBox.Mask = "(99) 0000-0000";
            this.cFONE2MaskedTextBox.Name = "cFONE2MaskedTextBox";
            this.cFONE2MaskedTextBox.Size = new System.Drawing.Size(179, 23);
            this.cFONE2MaskedTextBox.TabIndex = 4;
            this.cFONE2MaskedTextBox.Click += new System.EventHandler(this.cFONEMaskedTextBox_Click);
            // 
            // cFONE3MaskedTextBox
            // 
            this.cFONE3MaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CFONE3", true));
            this.cFONE3MaskedTextBox.Location = new System.Drawing.Point(148, 160);
            this.cFONE3MaskedTextBox.Mask = "(99)9999-9999";
            this.cFONE3MaskedTextBox.Name = "cFONE3MaskedTextBox";
            this.cFONE3MaskedTextBox.Size = new System.Drawing.Size(132, 23);
            this.cFONE3MaskedTextBox.TabIndex = 5;
            this.cFONE3MaskedTextBox.Click += new System.EventHandler(this.cFONEMaskedTextBox_Click);
            // 
            // cEMAILSTextBox
            // 
            this.cEMAILSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CEMAILS", true));
            this.cEMAILSTextBox.Location = new System.Drawing.Point(148, 192);
            this.cEMAILSTextBox.Multiline = true;
            this.cEMAILSTextBox.Name = "cEMAILSTextBox";
            this.cEMAILSTextBox.Size = new System.Drawing.Size(550, 109);
            this.cEMAILSTextBox.TabIndex = 6;
            // 
            // cCEPMaskedTextBox
            // 
            this.cCEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CCEP", true));
            this.cCEPMaskedTextBox.Location = new System.Drawing.Point(148, 307);
            this.cCEPMaskedTextBox.Mask = "99999-999";
            this.cCEPMaskedTextBox.Name = "cCEPMaskedTextBox";
            this.cCEPMaskedTextBox.Size = new System.Drawing.Size(100, 23);
            this.cCEPMaskedTextBox.TabIndex = 7;
            this.cCEPMaskedTextBox.Click += new System.EventHandler(this.cCNPJMaskedTextBox_Click);
            // 
            // cCIDADETextBox
            // 
            this.cCIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CCIDADE", true));
            this.cCIDADETextBox.Location = new System.Drawing.Point(148, 336);
            this.cCIDADETextBox.Name = "cCIDADETextBox";
            this.cCIDADETextBox.Size = new System.Drawing.Size(407, 23);
            this.cCIDADETextBox.TabIndex = 9;
            this.cCIDADETextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cUFTextBox
            // 
            this.cUFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CUF", true));
            this.cUFTextBox.Location = new System.Drawing.Point(660, 336);
            this.cUFTextBox.Name = "cUFTextBox";
            this.cUFTextBox.Size = new System.Drawing.Size(38, 23);
            this.cUFTextBox.TabIndex = 10;
            this.cUFTextBox.Leave += new System.EventHandler(this.cINSCTextBox_Leave);
            // 
            // cBAIRROTextBox
            // 
            this.cBAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CBAIRRO", true));
            this.cBAIRROTextBox.Location = new System.Drawing.Point(148, 366);
            this.cBAIRROTextBox.Name = "cBAIRROTextBox";
            this.cBAIRROTextBox.Size = new System.Drawing.Size(550, 23);
            this.cBAIRROTextBox.TabIndex = 11;
            this.cBAIRROTextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // cENDERECOTextBox
            // 
            this.cENDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOTELBindingSource, "CENDERECO", true));
            this.cENDERECOTextBox.Location = new System.Drawing.Point(148, 394);
            this.cENDERECOTextBox.Name = "cENDERECOTextBox";
            this.cENDERECOTextBox.Size = new System.Drawing.Size(550, 23);
            this.cENDERECOTextBox.TabIndex = 12;
            this.cENDERECOTextBox.Leave += new System.EventHandler(this.cNOMETextBox_Leave);
            // 
            // lOGOPictureBox
            // 
            this.lOGOPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lOGOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hOTELBindingSource, "LOGO", true));
            this.lOGOPictureBox.Location = new System.Drawing.Point(564, 41);
            this.lOGOPictureBox.Name = "lOGOPictureBox";
            this.lOGOPictureBox.Size = new System.Drawing.Size(134, 112);
            this.lOGOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lOGOPictureBox.TabIndex = 27;
            this.lOGOPictureBox.TabStop = false;
            // 
            // btnArquivo
            // 
            this.btnArquivo.Image = global::HotelGestor.Properties.Resources.imagfold32x32;
            this.btnArquivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArquivo.Location = new System.Drawing.Point(564, 153);
            this.btnArquivo.Name = "btnArquivo";
            this.btnArquivo.Size = new System.Drawing.Size(134, 33);
            this.btnArquivo.TabIndex = 13;
            this.btnArquivo.Text = "Carregar Logo";
            this.btnArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArquivo.UseVisualStyleBackColor = true;
            this.btnArquivo.Click += new System.EventHandler(this.btnArquivo_Click);
            // 
            // btnBuscaCep
            // 
            this.btnBuscaCep.Location = new System.Drawing.Point(254, 306);
            this.btnBuscaCep.Name = "btnBuscaCep";
            this.btnBuscaCep.Size = new System.Drawing.Size(121, 24);
            this.btnBuscaCep.TabIndex = 8;
            this.btnBuscaCep.Text = "Busca Endereço";
            this.btnBuscaCep.UseVisualStyleBackColor = true;
            this.btnBuscaCep.Click += new System.EventHandler(this.btnBuscaCep_Click);
            // 
            // frmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmEmpresa";
            this.Text = "Dados da Empresa";
            this.Load += new System.EventHandler(this.frmEmpresa_Load);
            this.tbMain.ResumeLayout(false);
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGOPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private HotelDBDataSetTableAdapters.HOTELTableAdapter hOTELTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cNOMETextBox;
        private System.Windows.Forms.MaskedTextBox cCNPJMaskedTextBox;
        private System.Windows.Forms.TextBox cINSCTextBox;
        private System.Windows.Forms.MaskedTextBox cFONEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cFONE2MaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cFONE3MaskedTextBox;
        private System.Windows.Forms.TextBox cEMAILSTextBox;
        private System.Windows.Forms.MaskedTextBox cCEPMaskedTextBox;
        private System.Windows.Forms.TextBox cCIDADETextBox;
        private System.Windows.Forms.TextBox cUFTextBox;
        private System.Windows.Forms.TextBox cBAIRROTextBox;
        private System.Windows.Forms.TextBox cENDERECOTextBox;
        private System.Windows.Forms.PictureBox lOGOPictureBox;
        private System.Windows.Forms.Button btnArquivo;
        private System.Windows.Forms.Button btnBuscaCep;
    }
}
