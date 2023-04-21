using Biblioteca;

namespace Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creaamos tres instancia de la clase Estudiante
            Estudiante estudiante1 = new Estudiante("Gustavo", "Leiva", "1234");
            Estudiante estudiante2 = new Estudiante("Maria", "Ledezma", "5555");
            Estudiante estudiante3 = new Estudiante("Juan", "Perez", "8888");


            //Cargar nota de todos los alumnos (1er y 2do parcial)
            estudiante1.SetNotaPrimerParcial(8);
            estudiante1.SetNotaSegundoParcial(6);




            //Mostrar datos
            Console.WriteLine(estudiante1.Mostrar());
        }
    }
}