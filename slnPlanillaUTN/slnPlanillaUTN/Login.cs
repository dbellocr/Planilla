using Capa.Entidades;
using Capa.Logica;
using slnPlanillaUTN.Mantenimientos;
using slnPlanillaUTN.Mantenimientos.Administrativo;
using slnPlanillaUTN.Mantenimientos.Director;
using slnPlanillaUTN.Mantenimientos.Docente;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginLogica loginLogica = new LoginLogica();
           Cuenta cuenta= loginLogica.IniciarSesion(txtUsuario.Text, txtContraseña.Text);

            if (cuenta == null)
            {
                MessageBox.Show("Error, el usuario o la contraseña ingresados son incorrectos, verifique sus datos e inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (cuenta.Colaborador.Rol==Rol.Docente)
            {
                frmDocente frm = new frmDocente();
                frm.Show();
            }
            else if (cuenta.Colaborador.Rol == Rol.Director)
            {

                frmDirector frm = new frmDirector();
                frm.Show();
            }
            else if (cuenta.Colaborador.Rol==Rol.Adminitrativo)
            {
                frmAdministrativo frm = new frmAdministrativo();
                frm.Show();
            }
           
        }
    }
}
