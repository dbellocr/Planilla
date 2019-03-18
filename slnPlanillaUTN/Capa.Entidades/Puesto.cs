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
    public class Puesto
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double SalarioBase { get; set; }
        public override string ToString()
        {
            return Descripcion;
        }


    }
}
