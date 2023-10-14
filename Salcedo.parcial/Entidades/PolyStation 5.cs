using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PolyStation_5 : Consola
    {

        private int cantidadNucleosProcesador;
        private ETiposPolyStation tipo;

        public PolyStation_5(string numeroDeSerie ,decimal precio, float almacenamientoInterno, int cantidadJugadores, string conectividadInternet, int cantidadNucleosProcesador,ETiposPolyStation tipo) : base(numeroDeSerie ,precio, almacenamientoInterno, cantidadJugadores, conectividadInternet)
        {
            this.FechaLanzamiento = DateTime.Today;
            this.cantidadNucleosProcesador = cantidadNucleosProcesador;
            this.tipo = tipo;
        }


        public int CantidadNucleosProcesador { get { return cantidadNucleosProcesador;} set { cantidadNucleosProcesador = value; } }

        public ETiposPolyStation Tipo { get { return tipo; } }

        /// <summary>
        /// Metodo sobreescrito de la clase base, muestra los datos de la clase base mas su atributo propio.
        /// </summary>
        /// <returns></returns>
        public override string MostrarConsola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***PolyStation 5®***");
            sb.Append(base.MostrarConsola());
            sb.AppendLine($"Cantidad de nucleos: {CantidadNucleosProcesador}");
            sb.AppendLine($"Tipo de PolyStation: {Tipo}");
            return sb.ToString();
        }
    }
}
