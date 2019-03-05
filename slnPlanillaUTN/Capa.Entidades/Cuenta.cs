using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Cuenta
    {
        public int ID { get; set; }
        public string NombreUsuario { get; set; }
        public int IDColaborador { get; set; }
        public string Contraseña { get; set; }
    }
}
