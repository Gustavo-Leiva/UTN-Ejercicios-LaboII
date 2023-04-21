namespace Biblioteca
{
    public class Boligrafo
    {
        private short cantidadTintaMaxima;
        private ConsoleColor color;
        private short tinta;
        const int CantidadTintaMaxima = 100;


        public Boligrafo(short tinta, ConsoleColor color) 
        { 
            this.tinta = tinta;
            this.color = color;
        
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }


        private void SetTinta(short nivelTinta)
        {
            if()

        }










    }


   

   }
}