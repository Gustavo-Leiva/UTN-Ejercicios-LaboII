using Biblioteca;

namespace Prestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("BBVA", 7000.25m);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(8000.45m);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(3000.43m);
            Console.WriteLine(cuenta.Mostrar());

        }
    }
}