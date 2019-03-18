using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
   public class CuentaDatos
    {
        public void Insertar(Cuenta cuenta)
        {

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Cuenta_PA_Insertar";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID_Colaborador", cuenta.Colaborador.ID);
                comando.Parameters.AddWithValue("@Contraseña", cuenta.Contraseña);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
            }
            catch
            {

                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
        public Cuenta SeleccionarPorID(string colaboradorID)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Cuenta_PA_SeleccionarPorIDColaborador";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID_Colaborador", colaboradorID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    Cuenta cuenta = new Cuenta()
                    {

                        Contraseña = reader["Contraseña"].ToString(),
                        Colaborador = ColaboradorDatos.SeleccionarPorID(colaboradorID)

                    };

                    return cuenta;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return null;
        }


    }
}
