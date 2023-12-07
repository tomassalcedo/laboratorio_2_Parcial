using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entidades
{

    /// <summary>
    /// Clase que maneja el Stock de materia prima para la produccion.
    /// </summary>
    public static class Stock
    {
        private static int metrosDeCable;
        private static int cantidadDePlastico;
        private static int cantidadDeTornillos;
        private static int cantidadDePlacas;

        static Stock()
        {
            StockDao.CargarStock();
        }
       

        public static int MetrosDeCable { get => metrosDeCable; set => metrosDeCable = value; }
        public static int CantidadDePlastico { get => cantidadDePlastico; set => cantidadDePlastico = value; }
        public static int CantidadDeTornillos { get => cantidadDeTornillos; set => cantidadDeTornillos = value; }
        public static int CantidadDePlacas { get => cantidadDePlacas; set => cantidadDePlacas = value; }



        public static void DescontarCable(int cantidad)
        {
            if (cantidad > 0)
            {
                MetrosDeCable -= cantidad;
                if (metrosDeCable < 0)
                {
                    metrosDeCable = 0;
                    // throw new MiExcepcion("No hay cable suficiente , hable con un supervisor");
                    throw new StockInsuficienteExeption("Cable");
                }

            }
        }


        public static void AgregarCable(int cantidad)
        {
            if (cantidad > 0)
            {
                MetrosDeCable += cantidad;
            }
        }


        public static void DescontarPlastico(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDePlastico -= cantidad;
                if (cantidadDePlastico < 0)
                {
                    cantidadDePlastico = 0;
                    throw new StockInsuficienteExeption("Plastico");
                }
            }
        }

        public static void AgregarPlastico(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDePlastico += cantidad;
            }
        }

        public static void DescontarPlacas(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDePlacas -= cantidad;
                if (cantidadDePlacas < 0)
                {
                    cantidadDePlacas = 0;
                    throw new StockInsuficienteExeption("Placas");
                }
            }
        }

        public static void AgregarPlacas(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDePlacas += cantidad;
            }
        }

        public static void DescontarTornillos(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDeTornillos -= cantidad;
                if (cantidadDeTornillos < 0)
                {
                    cantidadDeTornillos = 0;
                    throw new StockInsuficienteExeption("Tornillos");
                }
            }
        }

        public static void AgregarTornillos(int cantidad)
        {
            if (cantidad > 0)
            {
                CantidadDeTornillos += cantidad;
            }
        }
    }
}
