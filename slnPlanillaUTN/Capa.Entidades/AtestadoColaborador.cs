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
    public class AtestadoColaborador
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public Colaborador Colaborador { get; set; }
        public string Atestado { get; set; }
        public string RutaCompleta { get; set; }


        public override string ToString()
        {
            return Colaborador.NombreCompleto + " " + Atestado;
        }
    }
}
