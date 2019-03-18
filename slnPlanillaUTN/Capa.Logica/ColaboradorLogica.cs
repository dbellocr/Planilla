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
        public void Insertar(Colaborador colaborador, Cuenta cuenta)
        {
            var enc = new ColaboradorDatos();
            if (ColaboradorDatos.SeleccionarPorID(colaborador.ID) != null)
            {
                enc.Actualizar(colaborador);
                CuentaLogica.Guardar(cuenta);
            }
            else
            {
                enc.Insertar(colaborador);
                CuentaLogica.Guardar(cuenta);

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
        public Colaborador SeleccionarPorID(string colaboradorID)
        {
            return  ColaboradorDatos.SeleccionarPorID(colaboradorID);
        }
    }
}
