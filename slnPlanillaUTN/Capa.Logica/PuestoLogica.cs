using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class PuestoLogica
    {
        /// <summary>
        /// Selecciona todos los encargados
        /// </summary>
        /// <returns></returns>
        public List<Puesto> SeleccionarTodos()
        {
            return new PuestosDatos().SeleccionarTodos();
        }
        /// <summary>
        /// Selecciona un encargado el cual corresponde al ID recibido por parámetro
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns></returns>
        public Puesto SeleccionarPorID(Puesto puesto)
        {
            return new PuestosDatos().SeleccionarPorID(puesto);
        }
    }
}
