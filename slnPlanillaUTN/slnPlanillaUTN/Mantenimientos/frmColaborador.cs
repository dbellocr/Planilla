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
using Capa.Entidades;
using Capa.Logica;
using slnPlanillaUTN.Mantenimientos;

namespace slnPlanillaUTN.Mantenimientos
{
    public partial class frmColaborador : Form
    {
        OpenFileDialog dialog;
        OpenFileDialog ofdImagen;
        frmAtestadoColaborador frmAtestado;
        private FilterInfoCollection dispositivosVideo;
        private VideoCaptureDevice videoFinal;
        int camaraDefecto = -1;
        string extensionImagen;
        public frmColaborador()
        {
            frmAtestado = new frmAtestadoColaborador();
            ofdImagen =  new OpenFileDialog();
            dialog =  new OpenFileDialog();
            InitializeComponent();
        }


        private void frmColaborador_Load(object sender, EventArgs e)
        {
            CargarComboEstado();
            dispositivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoFinal = new VideoCaptureDevice();

        }

        private void CargarComboEstado()
        {
            cmbEstado.DataSource = Enum.GetValues(typeof(Estado));
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
          
            ofdImagen.Filter = "Solo imágenes  | *.png; *.jpg; *.jpeg";
            ofdImagen.Multiselect = false;
            if (ofdImagen.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = ofdImagen.FileName;

                string nombreImagen = ofdImagen.SafeFileName;

                string rutaProyecto = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                //  System.IO.File.Copy(rutaImagen, rutaProyecto + "\\Archivos\\Fotografias\\" + nombreImagen);
                pbFotografía.Image = Image.FromFile(rutaImagen);

              extensionImagen=  Path.GetExtension(ofdImagen.FileName).ToLower();

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
                oldImage.Dispose();
        }

        private void frmColaborador_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (videoFinal.IsRunning)
                videoFinal.Stop();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (videoFinal.IsRunning)
                videoFinal.Stop();
         
            string rutaImagenes = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)+ "\\Archivos\\Fotografias\\";
            string rutaCurriculum = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Archivos\\Curriculum\\";

            string nombreImagen = txtID.Text;
           


            if(ofdImagen.SafeFileName!="")
            nombreImagen += extensionImagen;
           
            
         
            try
            {
                pbFotografía.Image.Save(rutaImagenes + nombreImagen + ".jpg", ImageFormat.Jpeg);
                File.Copy(dialog.FileName, rutaCurriculum+ "Curriculum " + txtID.Text+ Path.GetExtension(dialog.FileName).ToLower());

                // Crea el objeto colaborador a partir de un patrón Factory 
                Colaborador colaborador = ColaboradorFactory.CrearColaborador(txtID.Text, txtNombre.Text, txtPirmerApellido.Text, txtSegundoApellido.Text, mktTelefono.Text, txtEmail.Text, dialog.SafeFileName, nombreImagen, (Estado)cmbEstado.SelectedItem == Estado.Activo ? true : false);
                ColaboradorLogica colaboradorLogica = new ColaboradorLogica();
                colaboradorLogica.Insertar(colaborador);
                frmAtestado.AsignarColaborador(colaborador);
                frmAtestado.GuardarArchivos();
                MessageBox.Show("Se ha guardado el colaborador", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                Logging.LogError(ex.ToString());
                MessageBox.Show("Ha ocurrido un error a la hora de guardar el colaborador" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }

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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnEditarAtestados_Click(object sender, EventArgs e)
        {

            Colaborador oColaborador = new Colaborador();
           
            frmAtestado.ShowDialog();

        }
    }
}
