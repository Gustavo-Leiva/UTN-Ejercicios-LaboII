namespace Biblioteca
{
    public class Cliente
    {
        //atributos
        private int _numero;
        private string _nombre;


        //constructores
        public Cliente(int numero)
        {
            this._numero = numero;
        }

        public Cliente( int numero, string nombre)
            : this(numero)
        {
            this._nombre = nombre;

        }

        //propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        
        }


        public int Numero
        {
            get { return _numero; }
        }

        public static bool operator == (Cliente c1, Cliente c2)
        {
            return c1._numero == c2._numero;
        }

        public static bool operator != (Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}