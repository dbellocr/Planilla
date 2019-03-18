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
    /// Se encarga de dar persistencia a los puestos
    /// </summary>
    public class PuestosDatos
    {
        /// <summary>
        /// Selecciona el encargado de la BD que corresponda al parametro
        /// </summary>
        /// <param name="puesto"></param>
        /// <returns></returns>
        public Puesto SeleccionarPorID(Puesto puesto)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Puesto_PA_SeleccionarPorID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", puesto.ID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    Puesto p = new Puesto()
                    {

                        ID =Convert.ToInt16(reader["ID"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        SalarioBase = Convert.ToDouble(reader["SalarioBase"])
                    };

                    return puesto;
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
        public List<Puesto> SeleccionarTodos()
        {
            List<Puesto> puestos = new List<Puesto>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Puesto_PA_SeleccionarTodos";

                SqlCommand comando = new SqlCommand(sql, conexion);


                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Puesto p = new Puesto()
                    {
                        ID = Convert.ToInt16(reader["ID"].ToString()),
                        Descripcion = reader["Descripcion"].ToString(),
                        SalarioBase = Convert.ToDouble(reader["SalarioBase"])
                    };
                    puestos.Add(p);
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
            return puestos;
        }
    }
}
