using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        //enumerado
        public enum Puesto
        {
            Caja1,
            Caja2
        }

        //atributo
        private static int _numeroActual;
        private Puesto _puesto;


        //constructor
        static PuestoAtencion()
        {
            PuestoAtencion._numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
            
        {
            this._puesto = puesto;
        }


        public static int numeroActual
        {
          get
            {
                PuestoAtencion._numeroActual++;
                return _numeroActual;
            }

                 //operador de predecremento primero incrementa y luego retorna
                //return ++_numeroActual;
        }

        //metodo
        public bool Atender(Cliente cli)
        {
            if(!(cli is null) && cli.Numero >=0)
            {
                Thread.Sleep(3000);
                return true;
            }

            return false;
        }



    }
}
