using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
  

    public class Camion : Vehiculo_Terrestre
    {

        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color,short cantidadMarchas, int pesoCarga)
            :base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }

        public string MostrarCamion()
        {
            StringBuilder sb= new StringBuilder();
            sb.AppendLine($"{base.MostrarVehiculoTerrestre()}");
            sb.AppendLine($"Cantidad Marchas: {cantidadMarchas}");
            sb.AppendLine($"Peso Carga: {pesoCarga}");
            return sb.ToString();

        }
    }
}
