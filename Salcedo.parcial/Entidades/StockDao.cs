using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StockDao
    {
        private static string connectionString;
        private static SqlCommand command;
        private static SqlConnection connection;

        static StockDao()
        {
            connectionString = @"Data Source=.; Initial Catalog = UTNPARCIAL_DB; Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void CargarStock()
        {
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Stock";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Stock.CantidadDePlacas = Convert.ToInt32(dataReader["cantidad_placas"]);
                        Stock.MetrosDeCable = Convert.ToInt32(dataReader["metros_cable"]);
                        Stock.CantidadDePlastico = Convert.ToInt32(dataReader["cantidad_plastico"]);
                        Stock.CantidadDeTornillos = Convert.ToInt32(dataReader["cantidad_tornillos"]);
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
        }




        public static void ActualizarStock()
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = "UPDATE Stock SET metros_cable = @cable, cantidad_plastico = @plastico, cantidad_tornillos = @tornillos, cantidad_placas = @placas";

                command.Parameters.AddWithValue("@placas", Stock.CantidadDePlacas);
                command.Parameters.AddWithValue("@cable", Stock.MetrosDeCable);
                command.Parameters.AddWithValue("@plastico", Stock.CantidadDePlastico);
                command.Parameters.AddWithValue("@tornillos", Stock.CantidadDeTornillos);
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
