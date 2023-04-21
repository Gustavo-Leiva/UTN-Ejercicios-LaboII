using Biblioteca;

namespace Libro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Book libro = new Book();
           libro[0] = "Jon i";
           libro[1] = "Dayneris II";


            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);

            }

            libro[1] = "Tyrion III";
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(libro[i]);
            }
        }
    }
}