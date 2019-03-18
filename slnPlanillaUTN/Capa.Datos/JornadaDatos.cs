using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
  public class JornadaDatos
    {

        public Jornada SeleccionarPorID(string jornadaID)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Jornada_PA_SeleccionarPorID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", jornadaID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    Jornada p = new Jornada()
                    {

                        ID = Convert.ToInt16(reader["ID"].ToString()),
                        Descripcion = reader["Descripción"].ToString(),
                  
                    };

                    return p;
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
        /// <summary>
        /// Selecciona todos los encargados de la BD
        /// </summary>
        /// <returns></returns>
        public List<Jornada> SeleccionarTodos()
        {
            List<Jornada> Jornadas = new List<Jornada>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Jornada_PA_SeleccionarTodos";

                SqlCommand comando = new SqlCommand(sql, conexion);


                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Jornada p = new Jornada()
                    {
                        ID = Convert.ToInt16(reader["ID"].ToString()),
                        Descripcion = reader["Descripción"].ToString()
                         
                    };
                    Jornadas.Add(p);
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
            return Jornadas;
        }


    }
}
