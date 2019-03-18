using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
  public  class CarreraProfesionalDatos
    {

        public static CarreraProfesional SeleccionarPorID(string carreraID)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Carrera_Profesional_PA_SeleccionarPorID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", carreraID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    CarreraProfesional c = new CarreraProfesional();
                    c.Grado = reader["Grado"].ToString();
                    c.ID = Convert.ToInt32(reader["ID"]);
                    c.Puntos = Convert.ToInt32(reader["Puntos"]);


                    return c;
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
        public static List<CarreraProfesional> SeleccionarTodos()
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            List<CarreraProfesional> listaCarreras = new List<CarreraProfesional>();
            try
            {
                conexion.Open();
                string sql = "Carrera_Profesional_PA_SeleccionarTodos";

                SqlCommand comando = new SqlCommand(sql, conexion);

            

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    CarreraProfesional c = new CarreraProfesional();
                    c.Grado = reader["Grado"].ToString();
                    c.ID = Convert.ToInt32(reader["ID"]);
                    c.Puntos = Convert.ToInt32(reader["Puntos"]);


                    listaCarreras.Add(c);
                }
                return listaCarreras;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
              
                conexion.Close();
               
            }
            
        }

    }
}
