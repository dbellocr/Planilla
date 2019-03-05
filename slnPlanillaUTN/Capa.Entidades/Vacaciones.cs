using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Vacaciones
    {
        public int IDColaborador { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int IDEncargado { get; set; }
        public char Estado { get; set; }
    }
}
