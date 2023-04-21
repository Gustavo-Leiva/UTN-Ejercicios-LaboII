using System.Text;

namespace Biblioteca
{

    public class Estudiante
    {
        //Atributos
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        //private Random random = 0;

        //Tendrá un constructor estático que inicializará el atributo estático random.(FALTA)


        //Constructor
        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        //Métodos setters
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private float CalcularPromedio(int nota1, int nota2)
        {
            float promedio;

            promedio = (nota1 + nota2) / 2;

            return promedio;
        }



        //pendiente
        /*
        public float CalcularNotaFinal (Random nota1, Random nota2)
        {


        }
        */


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"============================================================");
            sb.AppendLine($"Nombre: {nombre},   Apellido: {apellido},  Legajo: {legajo}");
            sb.AppendLine($"Nota 1: {notaPrimerParcial},    Nota 2: {notaSegundoParcial}");
            //sb.AppendLine($"Promedio: {CalcularPromedio}");
            sb.AppendLine($"=============================================================");

            return sb.ToString();
        }



    }
}