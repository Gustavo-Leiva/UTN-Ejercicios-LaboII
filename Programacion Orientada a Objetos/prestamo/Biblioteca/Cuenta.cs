using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        //Atributos
        private string titular;
        private decimal cantidad;


        //Constructor
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;

        }

        //Metódos Getters

        public string GetTitular()
        {
            return titular;
        }

        public decimal GetCantidad()
        {

            return cantidad;
        }

        //Método mostrar
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"========================");
            sb.AppendLine($"Razon Social: {titular}");
            sb.AppendLine($"Monto:        {cantidad}");
            sb.AppendLine($"========================");



            return sb.ToString();
        }


        //Método Ingresar
        public void Ingresar(decimal montoIngresar)
        {
            if (montoIngresar > 0)
            {
                cantidad += montoIngresar;
            }
        }


        //Método Retirar

        public void Retirar(decimal montoRetirar)
        {
            cantidad -= montoRetirar;
        }




    }
}