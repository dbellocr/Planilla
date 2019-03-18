using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class JornadaLogica
    {
        public Jornada SeleccionarPorID(string jornadaID)
        {
            JornadaDatos jornadaDatos = new JornadaDatos();
            return jornadaDatos.SeleccionarPorID(jornadaID);

        }
        public List<Jornada> SeleccionarTodos()
        {
            JornadaDatos jornadaDatos = new JornadaDatos();
            return jornadaDatos.SeleccionarTodos();

        }
    }
}
