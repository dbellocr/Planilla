using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class ColaboradorLogica
    {
        /// <summary>
        /// Inserta o actualiza el encargado dependiendo de su ID
        /// </summary>
        /// <param name="colaborador"></param>
        public void Insertar(Colaborador colaborador)
        {
            var enc = new ColaboradorDatos();
            if (enc.SeleccionarPorID(colaborador) != null)
            {
                enc.Actualizar(colaborador);
            }
            else
            {
                enc.Insertar(colaborador);
            }

        }
        /// <summary>
        /// Selecciona todos los encargados
        /// </summary>
        /// <returns></returns>
        public List<Colaborador> SeleccionarTodos()
        {
            return new ColaboradorDatos().SeleccionarTodos();
        }
        /// <summary>
        /// Selecciona un encargado el cual corresponde al ID recibido por parámetro
        /// </summary>
        /// <param name="colaborador"></param>
        /// <returns></returns>
        public Colaborador SeleccionarPorID(Colaborador colaborador)
        {
            return new ColaboradorDatos().SeleccionarPorID(colaborador);
        }
    }
}
