using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public static class ConsolaDao
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static ConsolaDao()
        {
            connectionString = @"Data Source=.; Initial Catalog = UTNPARCIAL_DB; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Metodo encargado de traer de la base de datos las Consolas creadas.
        /// </summary>
        /// <returns>retorna una lista de Consolas cargada de la base de datos.</returns>
        public static List<Consola> Leer()
        {
            List<Consola> consolas = new List<Consola>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Consolas";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        switch (dataReader["nombre"].ToString())
                        {
                            case "Juegosfera":
                                consolas.Add(new Juegosfera(Convert.ToInt32(dataReader["consola_id"]), Convert.ToDateTime(dataReader["fecha_lanzamiento"]), Convert.ToDecimal(dataReader["precio"]), Convert.ToInt32(dataReader["almacenamiento_interno"]), Convert.ToInt32(dataReader["cantidad_jugadores"]), Convert.ToBoolean(dataReader["internet"]), dataReader["nombre"].ToString()));
                                break;

                            case "Polystation5":
                                consolas.Add(new PolyStation_5(Convert.ToInt32(dataReader["consola_id"]), Convert.ToDateTime(dataReader["fecha_lanzamiento"]), Convert.ToDecimal(dataReader["precio"]), Convert.ToInt32(dataReader["almacenamiento_interno"]), Convert.ToInt32(dataReader["cantidad_jugadores"]), Convert.ToBoolean(dataReader["internet"]), dataReader["nombre"].ToString()));
                                break;

                            case "SuperArcadium2000":
                                consolas.Add(new SuperArcadium2000(Convert.ToInt32(dataReader["consola_id"]), Convert.ToDateTime(dataReader["fecha_lanzamiento"]), Convert.ToDecimal(dataReader["precio"]), Convert.ToInt32(dataReader["almacenamiento_interno"]), Convert.ToInt32(dataReader["cantidad_jugadores"]), Convert.ToBoolean(dataReader["internet"]), dataReader["nombre"].ToString()));
                                break;
                        }
                    }
                }
                return consolas;
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
        /// Metodo encargado de guardar una consola en la base de datos.
        /// </summary>
        /// <param name="consola">Consola que sera insertada a la base de datos</param>
        public static void Guardar(Consola consola)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Consolas(fecha_lanzamiento, precio, almacenamiento_interno, cantidad_jugadores, internet, nombre) " +
                    "VALUES(@FECHA, @PRECIO, @ALMACENAMIENTO, @JUGADORES, @INTERNET, @NOMBRE)";
                command.Parameters.AddWithValue("@FECHA", consola.FechaProduccion);
                command.Parameters.AddWithValue("@PRECIO", consola.Precio);
                command.Parameters.AddWithValue("@ALMACENAMIENTO", consola.Almacenamiento);
                command.Parameters.AddWithValue("@JUGADORES", consola.CantidadJugadores);
                command.Parameters.AddWithValue("@INTERNET", consola.Wifi);
                command.Parameters.AddWithValue("@NOMBRE", consola.Nombre);
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
        /// Metodo que se encarga de buscar una consola en especifico dentro de la base de datos
        /// </summary>
        /// <param name="id">id de la consola a buscar</param>
        /// <returns></returns>
        public static Consola Leer(int id)
        {
            bool consolaEncontrada = false;
            Consola auxConsola = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Consolas WHERE consola_id = @ID";
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        auxConsola = new Juegosfera(Convert.ToInt32(dataReader["consola_id"]), Convert.ToDateTime(dataReader["fecha_lanzamiento"]), Convert.ToDecimal(dataReader["precio"]), Convert.ToInt32(dataReader["almacenamiento_interno"]), Convert.ToInt32(dataReader["cantidad_jugadores"]), Convert.ToBoolean(dataReader["internet"]), dataReader["nombre"].ToString());
                        consolaEncontrada = true;

                    }                 
                }
                if (!consolaEncontrada)
                {
                    throw new ConsolaNoEncontradException(id);
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
            return auxConsola;
        }


        /// <summary>
        /// Metodo encargado de eliminar consolas de la base de datos
        /// </summary>
        /// <param name="id">id de la consola que se desea eliminar</param>
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Consolas WHERE consola_id = @ID";
                command.Parameters.AddWithValue("@ID", id);
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














