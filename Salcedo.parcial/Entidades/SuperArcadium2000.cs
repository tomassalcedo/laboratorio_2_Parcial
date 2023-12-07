using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SuperArcadium2000 : Consola, IConsola
    {


        public SuperArcadium2000()
        {

        }

        public SuperArcadium2000(int id, DateTime fechaProduccion, decimal precio,int almacenamiento, int cantidadJugadores, bool wifi, string nombre) : base(id, fechaProduccion, precio, almacenamiento, cantidadJugadores, wifi, nombre)
        {

        }


        /// <summary>
        /// Metodo de la interfaz, calcula el precio de la consola segun el almacenamiento de la misma.
        /// </summary>
        public void CalcularPrecio()
        {
            if (almacenamiento == 64)
            {
                Precio = 5000;
            }
            else if (almacenamiento == 128)
            {
                Precio = 15000;
            }
            else if (almacenamiento == 256)
            {
                Precio = 20000;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}

