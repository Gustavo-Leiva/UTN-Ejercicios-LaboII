using Biblioteca;

namespace Viajar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion camion = new Camion(4,4,Colores.Gris,5,2);
            Moto moto = new Moto(2,2,Colores.Rojo,160);
            Automovil auto = new Automovil(4,4,Colores.Blanco,5,4);


            Console.WriteLine(camion.MostrarCamion());            
            Console.WriteLine(moto.MostrarMoto());
            Console.WriteLine(auto.MostrarAuto());
        }
    }
}