using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juegosfera : Consola, IConsola
    {

        public Juegosfera()
        {

        }

        public Juegosfera(int id, DateTime fechaProduccion, decimal precio, int almacenamientoInterno, int cantidadJugadores, bool conectividadInternet, string nombre) : base(id, fechaProduccion, precio, almacenamientoInterno, cantidadJugadores, conectividadInternet, nombre)
        {


        }


        /// <summary>
        /// Metodo de la interfaz, calculara el precio de la consola dependiendo del almacenamiento de la misma
        /// </summary>
        public void CalcularPrecio()
        {
            if (almacenamiento == 64)
            {
                this.Precio = 20000;
            }
            else if (almacenamiento == 128)
            {
                this.Precio = 25000;
            }
            else if (almacenamiento == 256)
            {
                this.Precio = 30000;
            }
        }



        public override string ToString()
        {
            return base.ToString();
        }



    }
}
