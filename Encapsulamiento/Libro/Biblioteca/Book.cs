namespace Biblioteca
{
    public class Book
    {
        private List<string> paginas;

        public Book()
        {
           this.paginas = new List<string>();
        }


       public string this [int i]
       {

            get 
            { 
                if( i >= 0 && i < this.paginas.Count ) 
                {

                    return paginas[i];
                }

                return "pagina no valida";
            
            }


            set
            {
                if(i > this.paginas.Count)
                {
                    this.paginas.Add( value );
                }

                else if(i >=0)
                {
                    this.paginas.Insert(i,value);
                }
            }

       
       }




    }
}