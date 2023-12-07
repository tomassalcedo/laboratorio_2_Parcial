using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StockInsuficienteExeption : MiExcepcion
    {
        public StockInsuficienteExeption(string material):base($"No hay suficiente stock de : {material}, hable con un supervisor")
        {
                
        }
    }
}
