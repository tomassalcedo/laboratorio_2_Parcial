using Entidades;
namespace TestConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SuperArcadium2000 arca = new SuperArcadium2000(2000,250,2,false,10000);
            //Console.WriteLine(arca.MostrarConsola());

            //Console.WriteLine("------------------------------------------------------------------");

            //PolyStation_5 poli = new PolyStation_5(3600,1000,4,true,16,ETiposPolyStation.Digital);
            //Console.WriteLine(poli.MostrarConsola());

            //Console.WriteLine("-------------------------------------------------------------------");

            //Console.WriteLine($"Cantidad Tornillos: {StockMateriaPrima.CantidadTornillosDisponibles}");
            //Console.WriteLine($"Cantidad Plastico: {StockMateriaPrima.CantidadPlasticoDisponible}");
            //Console.WriteLine($"Cantidad Cable: {StockMateriaPrima.MetrosDeCableDisponible}");
            //StockMateriaPrima.DescontarTornillos(249);
            //StockMateriaPrima.DescontarPlastico(30);
            //StockMateriaPrima.DescontarCable(100);
            //Console.WriteLine("-------------------------------------------------------------------");

            //Console.WriteLine($"Cantidad Tornillos: {StockMateriaPrima.CantidadTornillosDisponibles}");
            //Console.WriteLine($"Cantidad Plastico: {StockMateriaPrima.CantidadPlasticoDisponible}");
            //Console.WriteLine($"Cantidad Cable: {StockMateriaPrima.MetrosDeCableDisponible}");


            Usuario tomas = new Usuario("tomascarp12","lalala",true);
            Console.WriteLine(  tomas.MostrarUsuario());
            Console.WriteLine("-----------------------------------");
            Usuario carla = new Usuario("carla","lololo",false);
            Console.WriteLine(carla.MostrarUsuario());







        }
    }
}