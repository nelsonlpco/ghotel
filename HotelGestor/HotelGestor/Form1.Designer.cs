namespace HotelGestor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niveisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensParaConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospedagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelDBDataSet = new HotelGestor.HotelDBDataSet();
            this.hOTELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTELTableAdapter = new HotelGestor.HotelDBDataSetTableAdapters.HOTELTableAdapter();
            this.tableAdapterManager = new HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.lOGOPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGOPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.atendimentoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.formasDePagamentoToolStripMenuItem,
            this.itensParaConsumoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hóspedesToolStripMenuItem,
            this.quartosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sairToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.cadastro;
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.niveisToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.empresaToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.hotel;
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.empresaToolStripMenuItem.Text = "&Empresa";
            // 
            // hotelToolStripMenuItem
            // 
            this.hotelToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.hotel;
            this.hotelToolStripMenuItem.Name = "hotelToolStripMenuItem";
            this.hotelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hotelToolStripMenuItem.Text = "&Hotel";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.hospedes;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // niveisToolStripMenuItem
            // 
            this.niveisToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.usuario;
            this.niveisToolStripMenuItem.Name = "niveisToolStripMenuItem";
            this.niveisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.niveisToolStripMenuItem.Text = "&Niveis";
            this.niveisToolStripMenuItem.Click += new System.EventHandler(this.niveisToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.backupToolStripMenuItem.Text = "&Backup";
            this.backupToolStripMenuItem.Visible = false;
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.backupToolStripMenuItem_Click);
            // 
            // formasDePagamentoToolStripMenuItem
            // 
            this.formasDePagamentoToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.formapagamento32x32;
            this.formasDePagamentoToolStripMenuItem.Name = "formasDePagamentoToolStripMenuItem";
            this.formasDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.formasDePagamentoToolStripMenuItem.Text = "&Formas de pagamento";
            this.formasDePagamentoToolStripMenuItem.Click += new System.EventHandler(this.formasDePagamentoToolStripMenuItem_Click);
            // 
            // itensParaConsumoToolStripMenuItem
            // 
            this.itensParaConsumoToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.buy;
            this.itensParaConsumoToolStripMenuItem.Name = "itensParaConsumoToolStripMenuItem";
            this.itensParaConsumoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.itensParaConsumoToolStripMenuItem.Text = "&Itens para consumo";
            this.itensParaConsumoToolStripMenuItem.Click += new System.EventHandler(this.itensParaConsumoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // hóspedesToolStripMenuItem
            // 
            this.hóspedesToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.hospede;
            this.hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            this.hóspedesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.hóspedesToolStripMenuItem.Text = "&Hóspedes";
            this.hóspedesToolStripMenuItem.Click += new System.EventHandler(this.hóspedesToolStripMenuItem_Click);
            // 
            // quartosToolStripMenuItem
            // 
            this.quartosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quartosToolStripMenuItem1,
            this.categoriasToolStripMenuItem1});
            this.quartosToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.quarto;
            this.quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            this.quartosToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.quartosToolStripMenuItem.Text = "&Quartos";
            // 
            // quartosToolStripMenuItem1
            // 
            this.quartosToolStripMenuItem1.Image = global::HotelGestor.Properties.Resources.quarto;
            this.quartosToolStripMenuItem1.Name = "quartosToolStripMenuItem1";
            this.quartosToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.quartosToolStripMenuItem1.Text = "&Quartos";
            this.quartosToolStripMenuItem1.Click += new System.EventHandler(this.quartosToolStripMenuItem1_Click);
            // 
            // categoriasToolStripMenuItem1
            // 
            this.categoriasToolStripMenuItem1.Image = global::HotelGestor.Properties.Resources.category;
            this.categoriasToolStripMenuItem1.Name = "categoriasToolStripMenuItem1";
            this.categoriasToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem1.Text = "&Categorias";
            this.categoriasToolStripMenuItem1.Click += new System.EventHandler(this.categoriasToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.exit;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // atendimentoToolStripMenuItem
            // 
            this.atendimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospedagemToolStripMenuItem});
            this.atendimentoToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.atendimento;
            this.atendimentoToolStripMenuItem.Name = "atendimentoToolStripMenuItem";
            this.atendimentoToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.atendimentoToolStripMenuItem.Text = "&Atendimento";
            // 
            // hospedagemToolStripMenuItem
            // 
            this.hospedagemToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.checkin;
            this.hospedagemToolStripMenuItem.Name = "hospedagemToolStripMenuItem";
            this.hospedagemToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.hospedagemToolStripMenuItem.Text = "&Hospedagem";
            this.hospedagemToolStripMenuItem.Click += new System.EventHandler(this.hospedagemToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.report48x48;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::HotelGestor.Properties.Resources.hospede;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
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
            this.tableAdapterManager.ATORESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIAQUARTOTableAdapter = null;
            this.tableAdapterManager.CLIENTETableAdapter = null;
            this.tableAdapterManager.enderecoTableAdapter = null;
            this.tableAdapterManager.faturaTableAdapter = null;
            this.tableAdapterManager.FaturaXItensTableAdapter = null;
            this.tableAdapterManager.FORMASDEPAGAMENTOTableAdapter = null;
            this.tableAdapterManager.HOSPEDAGEMTableAdapter = null;
            this.tableAdapterManager.HOTELTableAdapter = this.hOTELTableAdapter;
            this.tableAdapterManager.ITEMCONSUMOTableAdapter = null;
            this.tableAdapterManager.QUARTOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HotelGestor.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // lOGOPictureBox
            // 
            this.lOGOPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.hOTELBindingSource, "LOGO", true));
            this.lOGOPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOGOPictureBox.Location = new System.Drawing.Point(0, 24);
            this.lOGOPictureBox.Name = "lOGOPictureBox";
            this.lOGOPictureBox.Size = new System.Drawing.Size(784, 537);
            this.lOGOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lOGOPictureBox.TabIndex = 3;
            this.lOGOPictureBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbUsuarioLogado});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.Size = new System.Drawing.Size(47, 17);
            this.lbUsuarioLogado.Text = "Usuário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lOGOPictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Hoteleiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGOPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensParaConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospedagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource hOTELBindingSource;
        private HotelDBDataSetTableAdapters.HOTELTableAdapter hOTELTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox lOGOPictureBox;
        private System.Windows.Forms.ToolStripMenuItem formasDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niveisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbUsuarioLogado;
    }
}

