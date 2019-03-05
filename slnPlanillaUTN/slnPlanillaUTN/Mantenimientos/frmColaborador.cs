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

namespace slnPlanillaUTN.Mantenimientos
{
    public partial class frmColaborador : Form
    {
        public frmColaborador()
        {
            InitializeComponent();
        }


        private void frmColaborador_Load(object sender, EventArgs e)
        {

        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Solo imágenes  | *.png; *.jpg; *.jpeg";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = dialog.FileName;


                pbFotografía.Image = Image.FromFile(rutaImagen);

                FileInfo fileInfo = new FileInfo(rutaImagen);

                string nombreImagen = fileInfo.Name;

                string rutaProyecto = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                System.IO.File.Copy(rutaImagen, rutaProyecto + "\\Archivos\\Fotografias\\" + nombreImagen);




            }
        }
    }
}
