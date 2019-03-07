using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class CarreraLogica
    {
        /// <summary>
        /// Selecciona todos los encargados
        /// </summary>
        /// <returns></returns>
        public List<Carrera> SeleccionarTodos()
        {
            return new CarreraDatos().SeleccionarTodos();
        }
        /// <summary>
        /// Selecciona un encargado el cual corresponde al ID recibido por parámetro
        /// </summary>
        /// <param name="carrera"></param>
        /// <returns></returns>
        public Carrera SeleccionarPorID(Carrera carrera)
        {
            return new CarreraDatos().SeleccionarPorID(carrera);
        }
    }
}
