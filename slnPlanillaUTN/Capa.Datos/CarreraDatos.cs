using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    /// <summary>
    /// Se encarga de dar persistencia a las carreras
    /// </summary>
    public class CarreraDatos
    {
        /// <summary>
        /// Selecciona el encargado de la BD que corresponda al parametro
        /// </summary>
        /// <param name="carrera"></param>
        /// <returns></returns>
        public Carrera SeleccionarPorID(Carrera carrera)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Carrera_PA_SeleccionarPorID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", carrera.ID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    Carrera ca = new Carrera()
                    {
                        
                        ID = reader["ID"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        //La vez pasada tuve este mismo problema con convertir esto a un objeto....
                        //Director =Convert.ToInt64(reader["Director"].ToString()),
                    };

                    return carrera;
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
        public List<Carrera> SeleccionarTodos()
        {
            List<Carrera> carreras = new List<Carrera>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Carrera_PA_SeleccionarTodos";

                SqlCommand comando = new SqlCommand(sql, conexion);


                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Carrera ca = new Carrera()
                    {
                        ID = reader["ID"].ToString(),
                        Descripcion = reader["Descripcion"].ToString(),
                        //La vez pasada tuve este mismo problema con convertir esto a un objeto....
                        //Director =Convert.ToInt64(reader["Director"].ToString()),
                    };
                    carreras.Add(ca);
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
            return carreras;
        }
    }
}
