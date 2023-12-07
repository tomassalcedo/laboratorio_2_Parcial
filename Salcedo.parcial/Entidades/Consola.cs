using System.ComponentModel;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public abstract class Consola
    {
        protected int id;
        protected DateTime fechaProduccion;
        protected decimal precio;
        protected int almacenamiento;
        protected int cantidadJugadores;
        protected bool wifi;
        protected string nombre;

        public Consola()
        {
                
        }

        public Consola(int id,DateTime fechaProduccion,decimal precio,int almacenamiento, int cantidadJugadores, bool wifi, string nombre)
        {
            this.Id = id;
            this.fechaProduccion = fechaProduccion;
            this.Precio = precio;
            this.Almacenamiento = almacenamiento;
            this.CantidadJugadores = cantidadJugadores;
            this.Wifi = wifi;
            this.Nombre = nombre;
        }


        public int Id { get => id; set => id = value; }
        public DateTime FechaProduccion { get => fechaProduccion; set => fechaProduccion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
        public int CantidadJugadores { get => cantidadJugadores; set => cantidadJugadores = value; }
        public bool Wifi { get => wifi; set => wifi = value; }
        public string Nombre { get => nombre; set => nombre = value; }




        /// <summary>
        /// Metodo virtual que genera una planilla con los datos de la consola.
        /// </summary>
        /// <returns>retorna un StringBuilder con un formato determinado</returns>
        protected string MostrarConsola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {id}");
            sb.AppendLine($"Fecha de lanzamiento: {FechaProduccion.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Almacenamiento: {Almacenamiento}");
            sb.AppendLine($"Cantidad de jugadores: {CantidadJugadores}");
            sb.AppendLine($"Conectividad a internet: {wifi}");
            sb.AppendLine($"Nombre: {Nombre}");
            return sb.ToString();
        }


        public override string ToString()
        {
            return MostrarConsola();
        }


    
      

        

    }
}