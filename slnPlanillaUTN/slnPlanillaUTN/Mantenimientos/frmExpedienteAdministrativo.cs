using Capa.Entidades;
using Capa.Logica;
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
    public partial class frmExpedienteAdministrativo : Form
    {
       private Colaborador colaborador;
        private CarreraProfesionalLogica carreraProfesionalLogica;
        private JornadaLogica jornadaLogica;
        private PuestoLogica puestoLogica;
        public frmExpedienteAdministrativo(Colaborador colaborador)
        {
            this.colaborador = colaborador;
            jornadaLogica = new JornadaLogica();
            this.puestoLogica = new PuestoLogica();
            carreraProfesionalLogica = new CarreraProfesionalLogica();

            InitializeComponent();
        }

        private void btnVerExpediente_Click(object sender, EventArgs e)
        {

        }
        public void CargarCombo()
        {


            cmbCProfesional.DataSource = CarreraProfesionalLogica.SeleccionarTodos();
        
            cmbIDJornada.DataSource = jornadaLogica.SeleccionarTodos();

            cmbIDPuesto.DataSource = puestoLogica.SeleccionarTodos();
       

        }
        private void frmExpedienteAdministrativo_Load(object sender, EventArgs e)
        {
            CargarCombo();
            txtNombreColaborador.Text = colaborador.NombreCompleto;
        }
    }
}
