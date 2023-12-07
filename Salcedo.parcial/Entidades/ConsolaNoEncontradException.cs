using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class ConsolaNoEncontradException : MiExcepcion
    {
        public ConsolaNoEncontradException(int id):base($"La consola con el id: {id} no existe")
        {
                
        }
    }
}
