using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnPlanillaUTN.Mantenimientos
{
    public partial class frmVisualizarCVImagen : Form
    {
        private string rutaImagen;
        public frmVisualizarCVImagen(string rutaImagen)
        {
            this.rutaImagen = rutaImagen;
            InitializeComponent();
        }

        private void frmVisualizarCVImagen_Load(object sender, EventArgs e)
        {
            pbImagen.Image = Image.FromFile(rutaImagen);
        }
    }
}
