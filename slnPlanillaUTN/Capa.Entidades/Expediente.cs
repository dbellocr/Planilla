using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Expediente
    {
        public int IDColaborador { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IDPuesto { get; set; }
        public int IDCarrera { get; set; }
        public int IDJornada { get; set; }
        public int IDCarreraProfesional { get; set; }
    }
}
