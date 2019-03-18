using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica
{
    public class LoginLogica
    {

        public static string Encriptar(string contrasena)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(contrasena);
            result = Convert.ToBase64String(encryted);
            return result;
        }
        public static string DesEncriptar(string contrasena)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(contrasena);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
        public Cuenta IniciarSesion(string colaboradorID, string contraseña)
        {
            CuentaLogica cuenta = new CuentaLogica();
            Cuenta objCuenta = cuenta.SeleccionarPorID(colaboradorID);


            if (objCuenta != null)
            {
                string contraDesencrptada = DesEncriptar(objCuenta.Contraseña);
                if (contraDesencrptada == contraseña)
                    return objCuenta;
            }

            return null;
        }


    }


}

