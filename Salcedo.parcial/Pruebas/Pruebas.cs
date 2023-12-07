using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Pruebas
{
    [TestClass]
    public class Pruebas
    {
        [TestMethod]
        public void BuscarUsuario_CuandoNoExistenLosValores_DeberiaRetornarNull()
        {
            //ARRANGE
            Usuario expected = null;

            //ACT
            Usuario actual = LogicaNegocio.BuscarUsuario("noexisto","nono");

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(StockInsuficienteExeption))]
        public void DescontarPlacas_CuandoNoHayPlacas_DeberiaRetornarStockInsuficienteException()
        {
            //ARRANGE
            Stock.CantidadDePlacas = 0;

            //ACT
            Stock.DescontarPlacas(1);
        }


        [TestMethod]
        [ExpectedException(typeof(ConsolaNoEncontradException))]
        public void Leer_CuandoNoExisteLaConsola_DeberiaRetornarConsolaNoEncontradException()
        {
            //ARRANGE
            int idInexistente = 9999;
            Consola consola;

            //ACT
            consola = ConsolaDao.Leer(idInexistente);
            
        }


    }
}
