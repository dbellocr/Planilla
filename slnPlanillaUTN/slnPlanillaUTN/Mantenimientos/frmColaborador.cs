using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace slnPlanillaUTN.Mantenimientos
{
    public partial class frmColaborador : Form
    {
        OpenFileDialog dialog;
        private FilterInfoCollection dispositivosVideo;
        private VideoCaptureDevice videoFinal;
        int camaraDefecto = -1;
        public frmColaborador()
        {
            dialog=  new OpenFileDialog();
            InitializeComponent();
        }


        private void frmColaborador_Load(object sender, EventArgs e)
        {
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoFinal = new VideoCaptureDevice();

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdImagen = new OpenFileDialog();
            ofdImagen.Filter = "Solo imágenes  | *.png; *.jpg; *.jpeg";
            ofdImagen.Multiselect = false;
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = ofdImagen.FileName;

                string nombreImagen = ofdImagen.SafeFileName;

                string rutaProyecto = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
              //  System.IO.File.Copy(rutaImagen, rutaProyecto + "\\Archivos\\Fotografias\\" + nombreImagen);




            }
        }

        private void btnConfirmarTomar_Click(object sender, EventArgs e)
        {
           
            if (videoFinal.IsRunning)
            {
                videoFinal.Stop();
            }

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
         
          
            if (videoFinal.IsRunning)
            {
                videoFinal.Stop();
            }
          
            foreach (FilterInfo device in dispositivosVideo)
            {

                camaraDefecto++;
            }
            videoFinal = new VideoCaptureDevice(dispositivosVideo[camaraDefecto].MonikerString);
       
          
            videoFinal.NewFrame += VideoFinal_NewFrame;
            videoFinal.Start();
            btnConfirmarTomar.Visible = true;
            btnTomarFoto.Visible = false;
        }

        private void VideoFinal_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {


        

            Bitmap video = (Bitmap)eventArgs.Frame.Clone();

            Image oldImage = pbFotografía.Image;
            BeginInvoke(new Action(() => pbFotografía.Image = video));
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
        
        }

        private void frmColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (videoFinal.IsRunning)
            {
                videoFinal.Stop();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (videoFinal.IsRunning)
            {
                videoFinal.Stop();
            }

            string rutaProyecto = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)+ "\\Archivos\\Fotografias\\";
            string nombreImagen = txtID.Text;
            pbFotografía.Image.Save(rutaProyecto+ nombreImagen +".jpg", ImageFormat.Jpeg);


                

        }

        private void btnSubirCurriculum_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Solo imágenes y documentos pdf | *.png; *.jpg; *.jpeg; *.pdf";
            dialog.Multiselect = false;

            if (dialog.ShowDialog()==DialogResult.OK)
            {
                lblNombreArchivo.Visible = true;
                lblNombreArchivo.Text = dialog.SafeFileName;


            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (lblNombreArchivo.Text == "")
            {

                MessageBox.Show("Error, debe seleccionar un archivo para subir","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            string extensionArchivo = Path.GetExtension(dialog.FileName).ToLower();
            if (extensionArchivo == ".pdf")
            {
                frmVisualizarPDF pdf = new frmVisualizarPDF(dialog.FileName);
                pdf.ShowDialog();
            } else if (extensionArchivo==".png" || extensionArchivo==".jpg" || extensionArchivo == ".gif")
            {
                frmVisualizarCVImagen frmImagen = new frmVisualizarCVImagen(dialog.FileName);
                frmImagen.ShowDialog();


            }


        }
    }
}
