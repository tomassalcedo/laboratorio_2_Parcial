using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDao
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;


        static UsuarioDao()
        {
            connectionString = @"Data Source=.; Initial Catalog = UTNPARCIAL_DB; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }


        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Usuarios";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usuarios.Add(new Usuario(Convert.ToInt32(dataReader["usuario_id"]), dataReader["nombreUsuario"].ToString(), dataReader["password"].ToString(), Convert.ToBoolean(dataReader["esAdmin"])));
                    }
                }
            }
            catch (Exception)
            {
                 
                throw;
            }
            finally
            {
                connection.Close();
            }
            return usuarios;
        }


        public static Usuario Leer(int id)
        {
            Usuario auxUsuario = null;
           
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Usuarios WHERE usuario_id = @ID";
                command.Parameters.AddWithValue("@ID",id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        auxUsuario = new Usuario(Convert.ToInt32(dataReader["usuario_id"]), dataReader["nombreUsuario"].ToString(), dataReader["password"].ToString(), Convert.ToBoolean(dataReader["esAdmin"]));
                    }
                }                          
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
            return auxUsuario;
        }

        /// <summary>
        /// Metodo encargado de modificar un usuario de la base de datos
        /// </summary>
        /// <param name="usuario">usuario a modificar</param>
        public static void Modificar(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE Usuarios SET nombreUsuario = @nombre, password = @pass, esAdmin = @admin WHERE usuario_id = @id";
                command.Parameters.AddWithValue("@nombre",usuario.NombreUsuario);
                command.Parameters.AddWithValue("@pass",usuario.Password);
                command.Parameters.AddWithValue("@admin",usuario.EsAdmin);
                command.Parameters.AddWithValue("@id",usuario.Id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Metodo encargado de guardar un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">usuario a guardar en la base de datos</param>
        public static void Guardar(Usuario usuario)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Usuarios(nombreUsuario,password,esAdmin) VALUES (@NOMBRE, @PASS, @ADMIN)";
                command.Parameters.AddWithValue("@NOMBRE",usuario.NombreUsuario);
                command.Parameters.AddWithValue("@PASS",usuario.Password);
                command.Parameters.AddWithValue("@ADMIN",usuario.EsAdmin);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }


        /// <summary>
        /// Metodo encargado de eliminar un usuario en especifico de la base de datos
        /// </summary>
        /// <param name="id">id del usuario a eliminar</param>
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Usuarios WHERE usuario_id = @ID";
                command.Parameters.AddWithValue("@ID",id);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
