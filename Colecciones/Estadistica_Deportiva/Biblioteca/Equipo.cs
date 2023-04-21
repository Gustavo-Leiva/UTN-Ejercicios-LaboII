using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_Deportiva
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores; //hay que instanciarlos porque va a tener null
        private string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadJugadores, string nombre):this()
        {
            this.cantidadJugadores = cantidadJugadores;
            this.nombre = nombre;
        }


        //siempre las sobrecargas son estaticas
        //desde un metodo estatico no puedo acceder a una instancia.
        //si los atributos son privados puedo acceder porque estoy en la misma clase.
        public static bool operator + (Equipo equipo, Jugador jugador)
        {
            if (equipo.jugadores.Count < equipo.cantidadJugadores)
            {
                //recorro el jugador en la lista de jugadores
                foreach (Jugador jug in equipo.jugadores)
                {
                    //pregunto si esta 
                    if(jug == jugador)
                    {
                        return false;
                    }

                }

                equipo.jugadores.Add(jugador);
                return true;
            }

            return false;

        }
    }
}
