using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Moto : Vehiculo_Terrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color,short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarVehiculoTerrestre()}");
            sb.AppendLine($"Cilindrada: {cilindrada}");
            return sb.ToString();

        }
    }
}
