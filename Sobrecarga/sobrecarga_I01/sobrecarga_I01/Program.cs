using Bibliotecas;

namespace sobrecarga_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador suma1 = new Sumador();
            Sumador suma2= new Sumador();

            
            Console.WriteLine(suma1.Sumar(5, 6));
            Console.WriteLine(suma2.Sumar("Hola"," Gato"));
        }
    }
}