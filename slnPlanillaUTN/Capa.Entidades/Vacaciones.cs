using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Vacaciones
    {
        public Colaborador Colaborador { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Director Encargado { get; set; }
        public char Estado { get; set; }
    }
}
