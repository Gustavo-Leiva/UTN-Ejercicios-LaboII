namespace Bibliotecas
{

    public class Sumador
    {
        private int cantidadSumas;



        public Sumador(int cantSumas)
        {
            _cantidadSumas = cantSumas;
        }


        public Sumador() : this(0)
        {

        }

        public int CantidadSumas (get { return _cantidadSumas; })
        
            
            
         


        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;

        }

        public string Sumar(string a, string b) 
        {
            this.cantidadSumas++;
            return a + b;        
        }


        //la conversiones explicitas debe ser static, la palabra explicit y operator
        public static explicit operator int (Sumador sumador) 
        { 
        
            return sumador.
        }

    }
}