using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase que guarda la configuracion del sistema para posteriormente serializar a json.
    /// </summary>
    public class Configuracion
    {
        private Color colorFondo;
        private string fuente;

        public Color ColorFondo { get => colorFondo; set => colorFondo = value; }
        public string Fuente { get => fuente; set => fuente = value; }
    }
}
