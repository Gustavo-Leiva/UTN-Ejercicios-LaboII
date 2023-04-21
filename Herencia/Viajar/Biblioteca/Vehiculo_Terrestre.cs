using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Colores
    {
        Rojo,
        Blanco,
        Azul,
        Gris,
        Negro

    }
    public class Vehiculo_Terrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public Vehiculo_Terrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public string MostrarVehiculoTerrestre()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------");
            sb.AppendLine($"Cantidad Ruedas: {cantidadRuedas}");
            sb.AppendLine($"Cantidad Puertas: {cantidadPuertas}");
            sb.AppendLine($"Color: {color}");            
            return sb.ToString();
        }

        
    }
}
