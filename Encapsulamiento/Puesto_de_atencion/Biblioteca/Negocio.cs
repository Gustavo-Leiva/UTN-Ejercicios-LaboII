using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion _caja;
        Queue<Cliente> _clientes;
        private string _nombre;

        private Negocio()
        {
            this._clientes = new Queue<Cliente>(); //inicia la coleccion
            this._caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            :this()
        {
            this._nombre = nombre;

        }


        //La propiedad Cliente retornará el próximo cliente en la cola de atención en el get.
        //El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
        public Cliente Cliente
        {
            get { return _clientes.Dequeue(); }
            set { _ = this + value;} //utilizo una variable de descarte.
        }


        //El operador == retornará true si el cliente se encuentra en la colección.
        public static bool operator == (Negocio neg, Cliente cli )
        {
            foreach (Cliente item in neg._clientes)
            {
                if(cli == item)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Negocio neg, Cliente cli)
        {
            return !(neg == cli);
        }


        //El operador + será el único capaz de agregar un Cliente a la cola de atención.
        //Sólo se agregará un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente.


        public static bool operator + (Negocio neg, Cliente cli)
        {
            if(neg != cli)
            {
                neg._clientes.Enqueue(cli);
                return true;
            }

            return false;
        }


        //El operador ~ generará una atención del próximo cliente en la cola, utilizando la propiedad Cliente y el método Atender de PuestoAtencion.
        //Retornará true si pudo realizar la operación completa.
        public static bool operator ~ (Negocio neg)
        {
            if(neg._clientes.Count > 0) //me fijo si hay clientes en la lista
            {

                return neg._caja.Atender(neg.Cliente);//el proximo cliente a atender.

            }

            return false;

        }


        //La propiedad ClientesPendientes retornará la cantidad de clientes esperando a ser atendidos.

        public int ClientesPendientes
        {
            get { return this._clientes.Count; }
        }

    }
}
