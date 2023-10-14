using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public abstract class Consola
    {
        protected DateTime fechaLanzamiento;
        protected decimal precio;
        protected float almacenamientoInterno;
        protected int cantidadJugadores;
        protected string conectividadInternet;
        protected string numeroDeSerie;
        protected static List<string> numerosDeSerieUtilizados = new List<string>();

        public Consola(string numeroDeSerie ,decimal precio,float almacenamientoInterno,int cantidadJugadores, string conectividadInternet)
        {
            this.numeroDeSerie = numeroDeSerie;
            this.precio = precio;
            this.almacenamientoInterno = almacenamientoInterno;
            this.cantidadJugadores = cantidadJugadores;
            this.conectividadInternet = conectividadInternet;
        }

        public Consola(DateTime fechaLanzamiento,string numeroDeSerie ,decimal precio, float almacenamientoInterno, int cantidadJugadores, string conectividadInternet):this(numeroDeSerie,precio,almacenamientoInterno,cantidadJugadores,conectividadInternet)
        {
            this.fechaLanzamiento = fechaLanzamiento;
  
        }

        //public string Nombre { get { return nombre; } set { nombre = value; } }
        public string NumeroDeSerie { get { return numeroDeSerie; } }
        public DateTime FechaLanzamiento { get {  return fechaLanzamiento; } set {  fechaLanzamiento = value; } }
        public decimal Precio { get { return precio; } set {  precio = value; } }
        public float AlmacenamientoInterno { get {  return almacenamientoInterno; } set { almacenamientoInterno = value; } }
        public int CantidadJugadores { get {  return cantidadJugadores; } set { cantidadJugadores = value; } }
        public string ConectividadInternet { get { return conectividadInternet; } set {  conectividadInternet = value; } }

        
         /// <summary>
         /// Metodo virtual que genera una planilla con los datos de la consola.
         /// </summary>
         /// <returns>retorna un StringBuilder con un formato determinado</returns>
        public virtual string MostrarConsola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero de serie: {this.numeroDeSerie}");
            sb.AppendLine($"Fecha de lanzamiento: {FechaLanzamiento.ToString("dd/MM/yyyy")}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Almacenamiento: {AlmacenamientoInterno}");
            sb.AppendLine($"Cantidad de jugadores: {CantidadJugadores}");
            sb.AppendLine($"Conectividad a internet: {ConectividadInternet}");
            return sb.ToString();
        }

        /// <summary>
        /// Metodo encargado de generar un numero de serie unico, para que no haya 2 consolas
        /// con un mismo numero.
        /// </summary>
        /// <returns>Retorna un numero de serie al azar, con un formato determinado</returns>
        public static string GenerarNumeroDeSerieUnico()
        {
            int numero = 0;
            string numeroDeSerie = "";
            Random random = new Random();

            do
            {
                numero = random.Next(1000, 1000000);
                numeroDeSerie = $"TS-{numero}";

            } while (numerosDeSerieUtilizados.Contains(numeroDeSerie));

            numerosDeSerieUtilizados.Add(numeroDeSerie);
            return numeroDeSerie;
        }

        /// <summary>
        /// Soobrecarga del operador == compara 2 consolas por numero de serie
        /// </summary>
        /// <param name="c1">primer consola a comparar</param>
        /// <param name="c2">segunda consola a comparar</param>
        /// <returns>false si son distintas, true si son iguales</returns>
        public static bool operator ==(Consola c1, Consola c2)
        {
            bool retorno = false;

            if (c1 != null && c2 != null)
            {
                if (c1.NumeroDeSerie == c2.NumeroDeSerie)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(Consola c1, Consola c2)
        {
            return !(c1 == c2);
        }
    }
}