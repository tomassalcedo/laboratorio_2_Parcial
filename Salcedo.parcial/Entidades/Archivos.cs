using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Archivos<T>
    {
        static string ruta;

        static Archivos()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivos";
        }


        /// <summary>
        /// Metodo utilizado para escribir archivos xml
        /// </summary>
        /// <param name="datos">el objeto a serializar</param>
        /// <param name="archivo">nombre que llevara el archivo</param>
        /// <exception cref="MiExcepcion"></exception>
        public static void EscribirXml(T datos, string archivo)
        {
            string completa = ruta + @"\Serializacion_" + archivo + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(sw, datos);
                }
            }
            catch (Exception)
            {

                throw new MiExcepcion("Error al serializar");
            }
        }



        /// <summary>
        /// Metodo similar al primero, pero lo hace de forma asincronica en otro hilo.
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// <exception cref="MiExcepcion"></exception>
        public static async Task EscribirXmlAsync(T datos, string archivo)
        {       
            string completa = ruta + @"\Serializacion_" + archivo + ".xml";
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    await Task.Run(() => xmlSerializer.Serialize(sw, datos));
                }
            }
            catch (Exception)
            {
                throw new MiExcepcion("Error al serializar");
            }
        }


        /// <summary>
        /// Metodo encargado de leer el archivo json con las configuraciones del sistema
        /// </summary>
        /// <param name="archivo">nombre del archivo a leer</param>
        /// <returns>retorna un objeto de tipo Configuracion, con los atributos del json</returns>
        /// <exception cref="MiExcepcion"></exception>
        public static Configuracion LeerConfiguracion(string archivo)
        {
            string completa = ruta + @"\Serializacion_" + archivo + ".json";

            try
            {
                using (StreamReader sr = new StreamReader(completa))
                {
                    string json = sr.ReadToEnd();
                    return JsonConvert.DeserializeObject<Configuracion>(json);
                }
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("Error al leer la configuración", ex);
            }
        }


        /// <summary>
        /// Metodo encargado de guardar en un archivo json las configuraciones del sistema
        /// </summary>
        /// <param name="configuracion">objeto de tipo configuracion que sera serializado</param>
        /// <param name="archivo">Nombre con el que se guardara el archivo</param>
        /// <exception cref="MiExcepcion"></exception>
        public static void GuardarConfiguracion(Configuracion configuracion, string archivo)
        {
            string completa = ruta + @"\Serializacion_" + archivo + ".json";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                string json = JsonConvert.SerializeObject(configuracion);

                using (StreamWriter sw = new StreamWriter(completa))
                {
                    sw.Write(json);
                }
            }
            catch (Exception)
            {
                throw new MiExcepcion("Error al guardar la configuración");
            }
        }
    }
}
