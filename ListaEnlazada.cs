using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosAuxilios
{
    internal class ListaEnlazada<T>
    {
        private Nodo<T> _raiz;

        public ListaEnlazada()
        {
            _raiz = null;
        }

        // Inserta al inicio
        public void InsertarAlInicio(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            nuevo.Siguiente = _raiz;
            _raiz = nuevo;
        }

        // Inserta al final
        public void InsertarAlFinal(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);

            if (_raiz == null)
            {
                _raiz = nuevo;
            }
            else
            {
                Nodo<T> actual = _raiz;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Busca el primer elemento que cumple con un criterio
        public T Buscar(Func<T, bool> criterio)
        {
            Nodo<T> actual = _raiz;
            while (actual != null)
            {
                if (criterio(actual.Valor))
                    return actual.Valor;

                actual = actual.Siguiente;
            }
            return default(T);
        }

        // Devuelve todos los elementos que cumplen con un criterio
        public List<T> BuscarTodos(Func<T, bool> criterio)
        {
            List<T> resultados = new List<T>();
            Nodo<T> actual = _raiz;

            while (actual != null)
            {
                if (criterio(actual.Valor))
                    resultados.Add(actual.Valor);

                actual = actual.Siguiente;
            }

            return resultados;
        }

        // Permite recorrer la lista (útil para mostrarla o procesarla)
        public void Recorrer(Action<T> accion)
        {
            Nodo<T> actual = _raiz;
            while (actual != null)
            {
                accion(actual.Valor);
                actual = actual.Siguiente;
            }
        }
    }
}
