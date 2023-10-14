using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Entidades
{
    public static class Datos
    {

        static Datos()
        {
            HardCodearUsuarios();
        }

        //STOCK
        private static int metrosDeCable = 50000;
        private static int cantidadDePlastico = 90000;
        private static int cantidadDeTornillos = 3000;
        private static int cantidadDePlacas = 50000;
        public static int MetrosDeCableDisponible { get { return metrosDeCable; } }
        public static int CantidadPlasticoDisponible { get { return cantidadDePlastico; } }
        public static int CantidadTornillosDisponibles { get { return cantidadDeTornillos; } set { cantidadDeTornillos = value; } }
        public static int CantidadDePlacasDisponibles  { get { return cantidadDePlacas; } }


        //BODEGA
        public static List<Consola> bodegaConsolas = new List<Consola>();

        //CONSOLAS
        public static SuperArcadium2000 consola1 = new SuperArcadium2000(new DateTime(2023,07,15),"TS-918393",12,60,2,"Si",500);
        public static SuperArcadium2000 consola2 = new SuperArcadium2000(new DateTime(2023, 07, 21),"TS-283743",12,60,2,"Si",500);
        public static PolyStation_5 consola3 = new PolyStation_5("TS-912423",1200,500,4,"No",16,ETiposPolyStation.LectoraCD);
        public static Juegosfera consola4 = new Juegosfera("TS-821421",2000,256,2,"Si",ETiposJuegosfera.RCA);

        //USUARIOS
        public static Usuario usuario1 = new Usuario("devthomas12", "sistemas123", true);
        public static Usuario usuario2 = new Usuario("JuanCarlos", "10peso", false);
        public static Usuario usuario3 = new Usuario("pepito", "pepito123", true);
        public static List<Usuario> usuariosEnSistema = new List<Usuario>();


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Consola> HardCodearBodega()
        {
            bodegaConsolas.Add(consola1);
            bodegaConsolas.Add(consola2);
            bodegaConsolas.Add(consola3);
            bodegaConsolas.Add(consola4);

            return bodegaConsolas;
        }

        /// <summary>
        /// Recibe una consola por parametro y la agrega a la lista de consolas.
        /// </summary>
        /// <param name="consola">Consola que sera enviada a la bodega</param>
        public static void EnviarConsolaABodega(Consola consola)
        {
            bodegaConsolas.Add(consola); 
        }


        public static void DescontarCable(int cantidad)
        {
            if (cantidad > 0)
            {
                metrosDeCable -= cantidad;
            }
        }
        public static void AgregarCable(int cantidad)
        {
            if (cantidad > 0)
            {
                metrosDeCable += cantidad;
            }
        }

        public static void DescontarPlastico(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDePlastico -= cantidad;
            }
        }

        public static void AgregarPlastico(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDePlastico += cantidad;
            }
        }

        public static void DescontarPlacas(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDePlacas -= cantidad;
            }
        }

        public static void AgregarPlacas(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDePlacas += cantidad;
            }
        }

        public static void DescontarTornillos(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDeTornillos -= cantidad;
            }
        }

        public static void AgregarTornillos(int cantidad)
        {
            if (cantidad > 0)
            {
                cantidadDeTornillos += cantidad;
            }
        }

        /// <summary>
        /// Metodo estatico que mete al sistema 3 usuarios.
        /// </summary>
        public static  void HardCodearUsuarios()
        {
            usuariosEnSistema.Add(usuario1);
            usuariosEnSistema.Add(usuario2);
            usuariosEnSistema.Add(usuario3);
        }

        /// <summary>
        /// Recorre la lista con los usuarios en sistema y busca si existe un usuario con los argumentos pasados
        /// </summary>
        /// <param name="usuarios">Lista cargada con los usuarios en sistema</param>
        /// <param name="password">password a comparar </param>
        /// <param name="nombreUsuario">nombre de usuario a comparar</param>
        /// <returns>retorna null si el usuario no existe, si existe retorna el usuario</returns>
        public static Usuario VerificarPassword(List<Usuario> usuarios, string password, string nombreUsuario)
        {
            Usuario user = null;

            if (usuarios is not null)
            {
                foreach (Usuario item in usuarios)
                {
                    if (item.Password == password && item.NombreUsuario == nombreUsuario)
                    {
                        user = item;
                    }
                }
            }
            return user;
        }

        /// <summary>
        /// Busca el usuario pasado por argumento
        /// </summary>
        /// <param name="usuario">nombre de usuario a comparar</param>
        /// <param name="pass">password a comparar</param>
        /// <returns>null si el usuario no existe, si este existe retorna el usuario</returns>
        public static Usuario BuscarUsuario(string usuario, string pass)
        {
            Usuario auxUsuario = null;

            foreach (Usuario item in Datos.usuariosEnSistema)
            {
                if (item.NombreUsuario == usuario && item.Password == pass)
                {
                    auxUsuario = item;
                }
            }
            return auxUsuario;
        }


        /// <summary>
        /// Busca en la bodega,si existe la consola con el numero de serie pasado por argumento.
        /// </summary>
        /// <param name="numeroDeSerie">numero de serie a comparar</param>
        /// <returns>null si la consola no existe, si esta existe ,devuelve la consola</returns>
        public static Consola BuscarConsolaPorNumeroDeSerie(string numeroDeSerie)
        {
            Consola auxConsola = null;
            foreach (Consola item in Datos.bodegaConsolas)
            {
                if (numeroDeSerie == item.NumeroDeSerie)
                {
                    auxConsola = item;
                }
            }
            return auxConsola;
        }


    }
}
