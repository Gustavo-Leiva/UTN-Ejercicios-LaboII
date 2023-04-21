using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {

        private string _name;
        private string _address;
        private int _age;
        private string _gender;
        private string _country;
        private string[] _courses;


        public Ingresante(string name, string address, int age, string gender, string country, string[] courses)
        {
            this._name= name;
            this._address= address;
            this._age= age;
            this._gender = gender;
            this._country= country;
            this._courses = courses;
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {_name}");
            sb.AppendLine($"Direccion: {_address}");
            sb.AppendLine($"Edad: {_age}");
            sb.AppendLine($"Género: {_gender}");
            sb.AppendLine($"País: {_country}");
            sb.AppendLine($"Curso/s:");
            
            foreach (var item in _courses)
            {
                sb.AppendLine($"{item}");

            }

            return sb.ToString();
        }





    }
}