using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class Conexion
    {
        /// <summary>
        /// Se encarga de obtener la cadena de conexión con la Base de Datos
        /// </summary>
        public static string Cadena
        {
            get
            {
                string nombre = "SQLServer";
                return System.Configuration.ConfigurationManager.ConnectionStrings[nombre].ConnectionString;
            }
        }

    }
}
