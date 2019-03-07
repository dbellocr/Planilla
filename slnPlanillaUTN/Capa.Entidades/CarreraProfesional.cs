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
    public class CarreraProfesional
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public int ID { get; set; }
        public string Grado { get; set; }
        public int Puntos { get; set; }
    }
}
