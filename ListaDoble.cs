
using System.Collections;

namespace Calculadora
{

    internal class ListaDoble
    {
        private Nodo cabeza;

        public void InsertarAlFinal (int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                    temp.Siguiente = nuevo;
                    nuevo.Anterior = temp;
                }
            }
        }

        public ArrayList Mostrar()
        {
            ArrayList lista = new ArrayList();
            Nodo temp = cabeza;
            while (temp != null)
            {
                lista.Add(temp.Dato.ToString());
                temp = temp.Siguiente;
            }

            return lista;
        }
    }
}
