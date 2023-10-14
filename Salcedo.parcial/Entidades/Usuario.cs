using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private string nombreUsuario;
        private string password;
        private bool esAdmin;

        public Usuario(string nombreUsuario, string password)
        {
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            
        }

        public Usuario(string nombreUsuario, string password, bool esAdmin) : this(nombreUsuario, password)
        {
            this.esAdmin = esAdmin;
        }

        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string Password { get => password; set => password = value; }
        public bool EsAdmin { get { return esAdmin; } set { esAdmin = value; } }


        /// <summary>
        /// Metodo que muestra los atributos del usuario.
        /// </summary>
        /// <returns>retorna un stringBuilder con los atributos del usuario</returns>
        public string MostrarUsuario()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre usuario: {NombreUsuario}");
            if (this.esAdmin)
            {
                sb.AppendLine($"Tipo de usuario: Supervisor");
            }
            else
            {
                sb.AppendLine("Tipo de usuario: Operario");
            }
            return sb.ToString();
        }
    }
}
