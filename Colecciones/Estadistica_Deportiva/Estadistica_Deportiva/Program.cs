
namespace Estadistica_Deportiva
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Equipo equipo = new Equipo(2, "equipo");
            Jugador jugador1 = new Jugador(1234, "Gustavo", 12, 8);
            Jugador jugador2 = new Jugador(1234, "Lucas", 5, 4);
            Jugador jugador3 = new Jugador(1235, "Martin", 5, 4);
            Jugador jugador4 = new Jugador(1236, "Pablo", 5, 4);


            AgregarJugador(equipo, jugador1); //se tiene que agregar
            AgregarJugador(equipo, jugador2); //no se tiene que agregar mismo dni
            AgregarJugador(equipo, jugador3); //se tiene que agregar
            AgregarJugador(equipo, jugador4); //no se tiene que agregar por exceder capacidad



            //el guion bajo es como una variable de descarte.
            _ = equipo + jugador1;

           
        }


        static void AgregarJugador(Equipo equipo, Jugador jugador)
        {
            if (equipo + jugador)
            {
                Console.WriteLine($"jugador agregado:  {jugador.MostrarDatos()}");

            }
            else
            {
                Console.WriteLine($"No se pudo agregar el jugador: {jugador.MostrarDatos()}");

            }


        }


    }
}