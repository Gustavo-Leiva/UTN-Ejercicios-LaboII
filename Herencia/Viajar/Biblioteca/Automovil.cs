using System.Drawing;
using System.Text;

namespace Biblioteca
{
    public class Automovil : Vehiculo_Terrestre
    {

        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarVehiculoTerrestre()}");
            sb.AppendLine($"Cantidad Marchas: {cantidadMarchas}");
            sb.AppendLine($"Cantidad Pasajeros: {cantidadPasajeros}");
            return sb.ToString();


        }

      }
    }