using System.Text;

namespace Ejercicio_I03_Los_primos
{
    /*
     Consigna
        
        Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
        Validar que el dato ingresado por el usuario sea un número.
        Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
        Si ingresa "salir", cerrar la consola.
        Al finalizar, preguntar al usuario si desea volver a operar.    
        Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

     */ 


    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int numeroIngresado = int.Parse(Console.ReadLine());

            
            
            
            Console.WriteLine(ListarNumeroPrimos(numeroIngresado));
            
            //bool sePudo = int.TryParse("3", out int resultado);
            //Parsear el numero y pasarselo metodo.
        }



        public static bool esNumerico(string cadena)
        {
            return int.TryParse(cadena, out int resultado);
        }

        public static string ListarNumeroPrimos(int hasta)
        {
            //es la instancia de un objeto que permite utilizar el metodo Append.
            StringBuilder sb= new StringBuilder();

            
            for (int i = 2; i <=hasta ; i++)
            {
                //manjerar la logica de si i es primo          
                if(EsPrimo(i))
                {
                    sb.Append($"{i},");
                }
            }

            return sb.ToString();

        }

        public static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if(numero % i ==  0)
                {
                    return false;
                }                         

            }

            return true;
        }



    }
}