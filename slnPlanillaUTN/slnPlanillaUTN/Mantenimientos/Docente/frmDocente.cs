using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnPlanillaUTN.Mantenimientos.Docente
{
    public partial class frmDocente : Form
    {
        public frmDocente()
        {
            InitializeComponent();
        }

        private void btnVerExpediente_Click(object sender, EventArgs e)
        {
            frmColaborador frm = new frmColaborador();
            frm.Show();
        }
    }
}
