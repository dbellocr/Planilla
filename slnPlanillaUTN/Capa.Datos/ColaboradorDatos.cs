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
    /// Se encarga de dar persistencia a los encargados
    /// </summary>
    public class ColaboradorDatos
    {
        /// <summary>
        /// Inserta un colaborador a la BD
        /// </summary>
        /// <param name="colaborador"></param>
        public void Insertar(Colaborador colaborador)
        {
            
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Colaborador_PA_Insertar";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", colaborador.ID);
                comando.Parameters.AddWithValue("@Nombre", colaborador.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", colaborador.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", colaborador.SegundoApellido);
                comando.Parameters.AddWithValue("@Telefono", colaborador.Telefono);
                comando.Parameters.AddWithValue("@Email", colaborador.Email);
                comando.Parameters.AddWithValue("@Curriculum", colaborador.Curriculum);
                comando.Parameters.AddWithValue("@Foto", colaborador.Foto);
                comando.Parameters.AddWithValue("@Estado", colaborador.Estado);
                comando.Parameters.AddWithValue("@Rol", 3);
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
        /// <summary>
        /// Actualiza un ecargado de la base de datos
        /// </summary>
        /// <param name="colaborador"></param>
        public void Actualizar(Colaborador colaborador)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Colaborador_PA_Actualizar";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", colaborador.ID);
                comando.Parameters.AddWithValue("@Nombre", colaborador.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", colaborador.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", colaborador.SegundoApellido);
                comando.Parameters.AddWithValue("@Telefono", colaborador.Telefono);
                comando.Parameters.AddWithValue("@Email", colaborador.Email);
                comando.Parameters.AddWithValue("@Curriculum", colaborador.Curriculum);
                comando.Parameters.AddWithValue("@Foto", colaborador.Foto);
                comando.Parameters.AddWithValue("@Estado", colaborador.Estado);
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
        /// <summary>
        /// Selecciona el encargado de la BD que corresponda al parametro 
        /// </summary>
        /// <param name="colaborador"></param>
        /// <returns></returns>
        public static Colaborador SeleccionarPorID(string colaboradorID)
        {


            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Colaborador_PA_SeleccionarPorID";

                SqlCommand comando = new SqlCommand(sql, conexion);

                comando.Parameters.AddWithValue("@ID", colaboradorID);

                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {

                    Colaborador c = new Colaborador()
                    {

                        ID = reader["ID"].ToString(),
                        Foto = reader["Foto"].ToString(),
                        Curriculum = reader["Curriculum"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Estado = Convert.ToBoolean(reader["Estado"].ToString()),
                        Email = reader["Email"].ToString(),
                        PrimerApellido = reader["PrimerApellido"].ToString(),
                        SegundoApellido = reader["SegundoApellido"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Rol = reader["Rol"].ToString() == "3" ? Rol.Docente : reader["Rol"].ToString() == "1" ? Rol.Adminitrativo : Rol.Director

                    };

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
        /// <summary>
        /// Selecciona todos los encargados de la BD 
        /// </summary>
        /// <returns></returns>
        public List<Colaborador> SeleccionarTodos()
        {
            List<Colaborador> colaboradores = new List<Colaborador>();

            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                conexion.Open();
                string sql = "Colaborador_PA_SeleccionarTodos";

                SqlCommand comando = new SqlCommand(sql, conexion);


                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    Colaborador c = new Colaborador()
                    {
                        ID = reader["ID"].ToString(),
                        Foto = reader["Foto"].ToString(),
                        Curriculum = reader["Curriculum"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Email = reader["Email"].ToString(),
                        PrimerApellido = reader["PrimerApellido"].ToString(),
                        SegundoApellido = reader["SegundoApellido"].ToString(),
                        Nombre = reader["Nombre"].ToString(),

                    };
                    colaboradores.Add(c);
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
            return colaboradores;
        }
    }
}
