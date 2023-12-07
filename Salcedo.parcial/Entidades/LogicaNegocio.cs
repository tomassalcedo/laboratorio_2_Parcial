using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{

    public static class LogicaNegocio
    {



        /// <summary>
        /// Metodo encargado de buscar en la base de datos un usuario especifico
        /// </summary>
        /// <param name="nombreUsuario">nombre de usuario a comparar</param>
        /// <param name="pass">password a comparar</param>
        /// <returns>retorna el usuario que coincida con la busqueda</returns>
        /// <exception cref="Exception"></exception>
        public static Usuario BuscarUsuario(string nombreUsuario, string pass)
        {
            Usuario user = null;
            List<Usuario> usuarios = UsuarioDao.Leer();

            if (usuarios is not null)
            {
                foreach (Usuario item in usuarios)
                {
                    if (item.NombreUsuario == nombreUsuario && item.Password == pass)
                    {
                        user = item;
                        break;
                    }                  
                }
            }
            else
            {
                throw new MiExcepcion("Usuario/Contraseña Incorrecto");
            }
          
            return user;
        }


        /// <summary>
        /// Metodo encargado de consultar la categoria de un usuario especifico
        /// </summary>
        /// <param name="usuario">usuario al que se desea saber su categoria</param>
        /// <returns>Retorna un string con la categoria del usuario</returns>
        public static string ConsuntarCategoria(Usuario usuario)
        {
            string retorno = string.Empty;

            if (usuario is not null)
            {
                if (usuario.EsAdmin)
                {
                    retorno = $"Usuario: {usuario.NombreUsuario} \nCategoria: Supervisor";
                }
                else
                {
                    retorno = $"Usuario: {usuario.NombreUsuario} \nCategoria: Operario";
                }
            }
            else
            {
                retorno = "Usuario inexistente";
            }
            
            return retorno;
        }


        /// <summary>
        /// Metodo encargado de ordenar las consolas en bodega utiliza una expresion lambda
        /// </summary>
        /// <returns>retorna las consolas de la bodega pero ordenadas segun su precio de manera ascendente</returns>
        public static List<Consola> OrdenarPorPrecio()
        {
            List<Consola> consolas = ConsolaDao.Leer();

            consolas.Sort((c1, c2) => c1.Precio.CompareTo(c2.Precio));
            return consolas;            
        }

      

    }
}
