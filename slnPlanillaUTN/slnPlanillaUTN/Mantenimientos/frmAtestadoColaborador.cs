using Capa.Entidades;
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
    public partial class frmAtestadoColaborador : Form
    {
        public OpenFileDialog dialog { get; set; }
        public Colaborador Colaborador { get; set; }
        //Lista que contendrá el nombre de todos los atestados;
        public List<AtestadoColaborador> listaAtestados { get; set; }
        public frmAtestadoColaborador()
        {
            listaAtestados = new List<AtestadoColaborador>();
            Colaborador = new Colaborador();
            dialog = new OpenFileDialog();
            InitializeComponent();
        }

        private void frmAtestadoColaborador_Load(object sender, EventArgs e)
        {



        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            dialog.Filter = "Solo imágenes y documentos pdf | *.png; *.jpg; *.jpeg; *.pdf";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                AtestadoColaborador atestado = new AtestadoColaborador()
                {
                    Colaborador = Colaborador,
                    Atestado = dialog.SafeFileName,
                    RutaCompleta = dialog.FileName
                };
                listaAtestados.Add(atestado);
            }
            LlenarListBox();
        }
        public void AsignarColaborador(Colaborador colaborador)
        {

            foreach (var atestado in listaAtestados)
            {
                atestado.Colaborador = colaborador;
            }

        }
        public void GuardarArchivos()
        {
            string rutaAtestado = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10) + "\\Archivos\\Atestados\\";

            int cont = 0;
            foreach (var atestado in listaAtestados)
            {

                File.Copy(atestado.RutaCompleta, rutaAtestado + "Atestado N°"+ (cont++) +  atestado.Colaborador.NombreCompleto + Path.GetExtension(atestado.RutaCompleta).ToLower());


            }

        }
        public void LlenarListBox()
        {

            lstAtestados.DataSource = listaAtestados;
    

        }
    }
}
