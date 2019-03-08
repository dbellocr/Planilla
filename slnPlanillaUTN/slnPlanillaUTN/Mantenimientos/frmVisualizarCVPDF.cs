using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnPlanillaUTN
{
    public partial class frmVisualizarPDF : Form
    {
        private string rutaPDF;
        public frmVisualizarPDF(string rutaPDF)
        {
            this.rutaPDF = rutaPDF;
            InitializeComponent();
            
        }

        private void frmVisualizarPDF_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = rutaPDF;
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }
    }
}
