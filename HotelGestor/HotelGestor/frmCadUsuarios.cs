using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelGestor
{
    public partial class frmCadUsuarios : HotelGestor.template.frmMainCadastro
    {
        public frmCadUsuarios()
        {
            InitializeComponent();
            addeventos();
        }

        private VideoCaptureDevice videoSource;
        private bool ffoto;

        private DataRowView currentRow;

        private void addeventos()
        {
            cNOMETextBox.TextChanged += onEdit;
            cNICKTextBox.TextChanged += onEdit;
            cSENHATextBox.TextChanged += onEdit;
            cEMAILTextBox.TextChanged += onEdit;
            cFONEMaskedTextBox.TextChanged += onEdit;
            cFONE2MaskedTextBox.TextChanged += onEdit;
            nATORComboBox.SelectedValueChanged += onEdit;
        }


        public override bool isEmptyDataset()
        {
            bool saida = true;
            if (hotelDBDataSet.USUARIOS.Rows.Count > 0)
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
            currentRow = (DataRowView)uSUARIOSBindingSource.Current;
            uSUARIOSBindingSource.EndEdit();
            uSUARIOSTableAdapter.Update(hotelDBDataSet.USUARIOS);
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
                currentRow = (DataRowView)uSUARIOSBindingSource.Current;
                try
                {
                    currentRow.Delete();
                    uSUARIOSTableAdapter.Update(hotelDBDataSet.USUARIOS);
                }
                catch (Exception ex)
                {
                    Comum.msgAlert("Não é possivel excluir o Usuario pois o mesmo possuiu histórico de hospedagens!");
                    uSUARIOSTableAdapter.Fill(hotelDBDataSet.USUARIOS);

                }

            }
            lbStatus.Text = Comum.screenStats('c');
            buttonStates();
        }

        public override void cancelar()
        {
            uSUARIOSBindingSource.CancelEdit();
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
            uSUARIOSBindingSource.AddNew();
            cNOMETextBox.Focus();
            buttonStates();
            tbMain.SelectedIndex = 1;
        }

        public override void selecionar()
        {
            currentRow = (DataRowView)uSUARIOSBindingSource.Current;
            SelectId = (int)currentRow["IDUSUARIO"];
            SelectDescription = (string)currentRow["CNOME"];
            this.Close();
        }

        public override void filtro()
        {
            string filtro = string.Format(" CDESCRICAO like '%{0}%'", txtFiltro.Text);

            uSUARIOSBindingSource.Filter = filtro;

        }


        private void frmCadUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.ATORES' table. You can move, or remove it, as needed.
            this.aTORESTableAdapter.Fill(this.hotelDBDataSet.ATORES);
            // TODO: This line of code loads data into the 'hotelDBDataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.hotelDBDataSet.USUARIOS);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            tbMain.SelectedIndex = 1;
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void cNOMETextBox_Leave(object sender, EventArgs e)
        {
            Comum.confNomeProprio(sender);
        }
    }
}
