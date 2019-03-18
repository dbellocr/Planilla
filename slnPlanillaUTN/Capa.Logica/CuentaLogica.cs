using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class CuentaLogica
    {


        public static void Guardar(Cuenta cuenta)
        {
            CuentaDatos cuentaDatos = new CuentaDatos();
            if (cuentaDatos.SeleccionarPorID(cuenta.Colaborador.ID) != null)
            {




            }
            else
            {
                cuentaDatos.Insertar(cuenta);
            }

        }
        public Cuenta SeleccionarPorID(string colaboradorID)
        {

            CuentaDatos cuentaDatos = new CuentaDatos();

            return cuentaDatos.SeleccionarPorID(colaboradorID);
        }
    }
}
