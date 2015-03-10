using AForge.Video.DirectShow;
using HotelGestor.relatorios.hospedes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmHospedes : HotelGestor.template.frmMainCadastro
    {
        public frmHospedes()
        {
            InitializeComponent();
            addeventos();
            lbStatus.Text = Comum.screenStats('c');
        }
        private VideoCaptureDevice videoSource;
        private bool ffoto;

        private DataRowView currentRow;

        private void addeventos()
        {
            cNOMETextBox.TextChanged += onEdit;
            cRGTextBox.TextChanged += onEdit;
            cCPFMaskedTextBox.TextChanged += onEdit;
            dDATANASCDateTimePicker.ValueChanged += onEdit;
            cCEPMaskedTextBox.TextChanged += onEdit;
            cCIDADETextBox.TextChanged += onEdit;
            cUFTextBox.TextChanged += onEdit;
            cBAIRROTextBox.TextChanged += onEdit;
            cRUATextBox.TextChanged += onEdit;
            cFONE2MaskedTextBox.TextChanged += onEdit;
            cFONEMaskedTextBox.TextChanged += onEdit;
            cEMAILTextBox.TextChanged += onEdit;
        }


        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.CLIENTE.Rows.Count > 0)
                saida = false;
            return saida;
        }

        private void startPhotoLibrary()
        {
            AForge.Video.DirectShow.FilterInfoCollection videosources = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
            ffoto = true;
            buttonStates();
            if (videosources != null)
            {
                try
                {
                    videoSource = new VideoCaptureDevice(videosources[0].MonikerString);

                    videoSource.NewFrame += (s, e) => fOTOPictureBox.Image = (Bitmap)e.Frame.Clone();
                    videoSource.Start();
                }
                catch (Exception ex)
                {
                    Comum.msgErro("Não foi encontrada camera ligada ao computador");
                    ffoto = false;
                    buttonStates();
                }
                
            }
        }

        private void stopPhotoLibrary()
        {
            ffoto = false;
            buttonStates();
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
        }

        private void takePhoto()
        {
            fOTOPictureBox.Image.Save("snapshot.png", System.Drawing.Imaging.ImageFormat.Png);
            stopPhotoLibrary();
        }

        private void imagemDoArquivo()
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                fOTOPictureBox.ImageLocation = file.FileName;
            }
        }

        private void tirarfoto()
        {
            if (ffoto)
            {
                takePhoto();
                btnCamera.Text = "Câmera";
            }
            else
            {
                startPhotoLibrary();
                btnCamera.Text = "Foto";
            }
        }

        public override void buttonStates()
        {
            btnTransferir.Enabled = !SavePrompt && !isEmptyDataset() && !ffoto;
            btnIncluir.Enabled = !SavePrompt && !ffoto;
            btnGravar.Enabled = SavePrompt && !ffoto;
            btnCancelar.Enabled = SavePrompt;
            btnExcluir.Enabled = !SavePrompt && !isEmptyDataset() && !ffoto;
            btnSair.Enabled = !SavePrompt && !ffoto;
        }

        public void selectMod()
        {
            btnTransferir.Visible = true;
            lbStatus.Text = Comum.screenStats('t');
        }


        public override void salvar()
        {
            currentRow = (DataRowView)cLIENTEBindingSource.Current;
            currentRow["DDATACADASTRO"] = System.DateTime.Now;
           

            cLIENTEBindingSource.EndEdit();
            cLIENTETableAdapter.Update(hotelDBDataSet.CLIENTE);
            SavePrompt = false;
            IsInclude = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public override void excluir()
        {
            lbStatus.Text = Comum.screenStats('d');
            if (Comum.msgExcluir(Comum.MSG_EXCLUIR))
            {
                currentRow = (DataRowView)cLIENTEBindingSource.Current;
                try
                {
                    currentRow.Delete();
                    cLIENTETableAdapter.Update(hotelDBDataSet.CLIENTE);
                }
                catch (Exception ex)
                {
                    Comum.msgAlert("Não é possivel excluir o hóspede pois o mesmo possuiu histórico de hospedagens!");
                    cLIENTETableAdapter.Fill(hotelDBDataSet.CLIENTE);
                        
                }
                
            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public override void cancelar()
        {
            cLIENTEBindingSource.CancelEdit();
            stopPhotoLibrary();
            SavePrompt = false;
            IsInclude = false;
            lbStatus.Text = Comum.screenStats('c');
            tbMain.SelectedIndex = 0;
            buttonStates();
        }

        public override void incluir()
        {
            lbStatus.Text = Comum.screenStats('i');
            IsInclude = true;
            SavePrompt = true;
            cLIENTEBindingSource.AddNew();
            cNOMETextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)cLIENTEBindingSource.Current;
            SelectId = (int)currentRow["NNUMECLIENTE"];
            SelectDescription = (string)currentRow["CNOME"];
            this.Close();
        }

        private void frmHospedes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.hotelDBDataSet.CLIENTE);
            buttonStates();

        }


        private void btnCamera_Click(object sender, EventArgs e)
        {
            onEdit(sender, e);
            tirarfoto();
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            onEdit(sender, e);
            imagemDoArquivo();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter = string.Format(" CNOME LIKE '{0}%'", txtFiltro.Text);
            cLIENTEBindingSource.Filter = filter;
        }

        private void btnBuscaCep_Click(object sender, EventArgs e)
        {
            string[] endereco = Comum.buscacep(cCEPMaskedTextBox.Text);
            currentRow = (DataRowView)cLIENTEBindingSource.Current;
            currentRow["CCIDADE"] = endereco[2];
            currentRow["CUF"] = endereco[3];
            currentRow["CBAIRRO"] = endereco[1];
            currentRow["CRUA"] = endereco[0];
            cCIDADETextBox.Text = endereco[2];
            cUFTextBox.Text = endereco[3];
            cBAIRROTextBox.Text = endereco[1];
            cRUATextBox.Text = endereco[0];
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
        }

        private void cNOMETextBox_Leave(object sender, EventArgs e)
        {
            Comum.confNomeProprio(sender);
        }

        private void cRGTextBox_Leave(object sender, EventArgs e)
        {
            Comum.toUpper(sender);
        }

        private void cCPFMaskedTextBox_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 0;
        }

        private void cFONEMaskedTextBox_Enter(object sender, EventArgs e)
        {
            ((MaskedTextBox)sender).SelectionStart = 1;
        }

        private void tbMain_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.SavePrompt && tbMain.SelectedIndex == 0)
            {
                Comum.msgAlert(Comum.MSG_EMEDICAO);
                e.Cancel = true;
                return;
            }
            else if (isEmptyDataset() && !IsInclude && tbMain.SelectedIndex == 1)
            {
                Comum.msgAlert(Comum.MSG_SEMREGISTRO);
                e.Cancel = true;
                return;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatoriosHospedes frm = new frmRelatoriosHospedes();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
