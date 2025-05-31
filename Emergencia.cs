using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosAuxilios
{
    internal class Emergencia
    {
        private static int _contadorID = 0;

        public int ID { get; }
        public string Titulo { get; set; }
        public ListaEnlazada<Pauta> Pautas { get; set; }

        public Emergencia()
        {
            ID = ++_contadorID;
            Pautas = new ListaEnlazada<Pauta>();
        }

        public Emergencia(string titulo): this()
        {
            Titulo = titulo;
        }

        // Método para agregar una pauta individual
        public void AgregarPauta(Pauta pauta)
        {
            if (pauta != null)
            {
                Pautas.InsertarAlFinal(pauta);
            }
        }
    }
}
