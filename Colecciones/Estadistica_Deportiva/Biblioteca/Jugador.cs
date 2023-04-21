using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Estadistica_Deportiva
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioDeGoles;
        private int _totalGoles;
         
        private Jugador()
        {
            
            this._partidosJugados = 0;
            this._promedioDeGoles = 0;
            this._totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
            :this()
        {
            this._dni = dni;
            this._nombre = nombre;
        }

        public Jugador(int dni, string nombre,  int totalGoles, int partidosJugados)
            :this(dni, nombre)
        {
          
            this._totalGoles = totalGoles;
            this._partidosJugados = partidosJugados;
        }



        public float GetPromedioGoles()
        {
            if(_partidosJugados == 0)
            {
                return 0;
            }
            _promedioDeGoles = (float)_totalGoles/ _partidosJugados;

            return _promedioDeGoles;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"DNI: {_dni}");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Cantidad de partidos jugados: {_partidosJugados}");
            sb.AppendLine($"Total goles: {_totalGoles}");
            sb.AppendLine($"Promedio Goles: {GetPromedioGoles()}");      

            return sb.ToString();
        }

        public static bool operator == (Jugador jugador1, Jugador jugador2)
        {
            if(jugador1 is not null && jugador2 is not null)
            {
                return jugador1._dni == jugador2._dni;
            }

            return false;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }

       
    }
}
