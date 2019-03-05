using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Expediente
    {
        public Colaborador Colaborador { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Puesto Puesto { get; set; }
        public Carrera Carrera { get; set; }
        public Jornada Cornada { get; set; }
        public CarreraProfesional CarreraProfesional { get; set; }
    }
}
