using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosAuxilios
{
    internal class Nodo<T>
    {
        public T Valor { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null;
        }

        public Nodo(T valor, Nodo<T> siguiente)
        {
            Valor = valor;
            Siguiente = siguiente;
        }
    }
}
