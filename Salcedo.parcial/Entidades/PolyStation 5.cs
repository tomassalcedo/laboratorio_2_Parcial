using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PolyStation_5 : Consola ,IConsola
    {
        public PolyStation_5()
        {
                
        }

        public PolyStation_5(int id, DateTime fechaProduccion, decimal precio,int almacenamiento, int cantidadJugadores, bool wifi, string nombre) : base(id, fechaProduccion, precio, almacenamiento, cantidadJugadores, wifi, nombre)
        {
           
        }




        /// <summary>
        /// Metodo de la interfaz, calcula el precio de la consola segun el almacenamiento de la misma.
        /// </summary>
        public void CalcularPrecio()
        {           
            if (almacenamiento == 64)
            {
                Precio = 80000;
            }
            else if (almacenamiento == 128)
            {
                Precio = 85000;
            }
            else if (almacenamiento == 256)
            {
                Precio = 90000;
            }        
        }

        public override string ToString()
        {
            return base.ToString(); 
        }


    }
}
