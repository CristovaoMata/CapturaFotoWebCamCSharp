using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapturaFotoWebCam
{
    public partial class FrmCapturaFoto : Form
    {

        private FilterInfoCollection dispositivosVideo;
        private VideoCaptureDevice videoSource;

        public FrmCapturaFoto()
        {
            InitializeComponent();
        }

        private void FrmCapturaFoto_Load(object sender, EventArgs e)
        {
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (dispositivosVideo.Count > 0)
            {
                videoSource = new VideoCaptureDevice(dispositivosVideo[1].MonikerString); 
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
            }
            else
            {
                MessageBox.Show("Nenhuma câmera encontrada.");
            }

        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagem = (Bitmap)eventArgs.Frame.Clone();
            pictureBoxCamera.Image = imagem;
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                pictureBoxFotoCapturada.Image = (Bitmap)pictureBoxCamera.Image.Clone();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (pictureBoxFotoCapturada.Image != null)
            {
                string caminho = Path.Combine(Application.StartupPath, "fotos");
                Directory.CreateDirectory(caminho);

                string nomeArquivo = Path.Combine(caminho, $"foto_{DateTime.Now.Ticks}.jpg");
                pictureBoxFotoCapturada.Image.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("Foto Salva com sucessso:\n" + nomeArquivo);
            }
        }

        private void FrmCapturaFoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}
