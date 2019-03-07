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
    public class PlanillaSalarial
    {
        /// <summary>
        /// Declarar las variables
        /// </summary>
        public int ID { get; set; }
        public Colaborador Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public double TotalAnualidad { get; set; }
        public double TottalCarreraProfesional { get; set; }
        public double DeduccionBP { get; set; }
        public double DeduccionCCSS { get; set; }
        public double DeduccionIVM { get; set; }
        public double DeduccionImpuestoRenta { get; set; }
        public double SalarioNeto { get; set; }
    }
}
