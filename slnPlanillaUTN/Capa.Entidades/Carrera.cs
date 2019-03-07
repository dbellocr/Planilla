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
    public class Carrera
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public string ID { get; set; }
        public string Descripcion { get; set; }
        public Director Director { get; set; }
    }
}
