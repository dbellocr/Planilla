using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    /// <summary>
    /// Dar persistencia a las variables 
    /// </summary>
    public class Vacaciones
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public Colaborador Colaborador { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string Motivo { get; set; }
        public DateTime FechaIncio { get; set; }
        public DateTime FechaFinal { get; set; }
        public Director Encargado { get; set; }
        public char Estado { get; set; }
    }
}
