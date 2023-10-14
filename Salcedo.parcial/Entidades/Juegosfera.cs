using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Juegosfera : Consola
    {
        private ETiposJuegosfera tipo;

        public Juegosfera(string numeroDeSerie, decimal precio, float almacenamientoInterno, int cantidadJugadores, string conectividadInternet,ETiposJuegosfera tipo) : base(numeroDeSerie, precio, almacenamientoInterno, cantidadJugadores, conectividadInternet)
        {
            this.FechaLanzamiento = DateTime.Today;
            this.tipo = tipo;
        }

        public ETiposJuegosfera Tipo { get { return tipo; } }

        public override string MostrarConsola()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***Juegosfera®***");
            sb.Append(base.MostrarConsola());
            sb.AppendLine($"Tipo de Juegosfera: {Tipo}");
            return sb.ToString();
        }
    }
}
