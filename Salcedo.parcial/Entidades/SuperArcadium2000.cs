using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SuperArcadium2000 : Consola
    {
        private int cantidadDeJuegos;
        
        public SuperArcadium2000(string numeroDeSerie,decimal precio,float almacenamientoInterno, int cantidadJugadores, string conectividadInternet, int cantidadDeJuegos):base(numeroDeSerie,precio,almacenamientoInterno,cantidadJugadores,conectividadInternet)
        {
            this.cantidadDeJuegos = cantidadDeJuegos;
            this.FechaLanzamiento = DateTime.Today;
        }

        public SuperArcadium2000(DateTime fecha,string numeroDeSerie, decimal precio, float almacenamientoInterno, int cantidadJugadores, string conectividadInternet, int cantidadDeJuegos):this(numeroDeSerie,precio,almacenamientoInterno,cantidadDeJuegos,conectividadInternet,cantidadDeJuegos)
        {
            FechaLanzamiento = fecha;
        }


        public int CantidadDeJuegos { get { return cantidadDeJuegos; } set { cantidadDeJuegos = value; } }
        

        /// <summary>
        /// Metodo sobreescrito de la clase base, muestra los datos de la clase base mas su atributo propio.
        /// </summary>
        /// <returns></returns>
        public override string MostrarConsola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***SUPER ARCADIUM 2000®***");
            sb.Append(base.MostrarConsola());
            sb.AppendLine($"Cantidad de juegos: {CantidadDeJuegos}");
            return sb.ToString();
        }
    }
}
