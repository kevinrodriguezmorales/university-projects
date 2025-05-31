using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosAuxilios
{
    internal class Pauta
    {
        public static int _contadorIndice = 0;

        public int Indice { get; }
        public string Descripcion { get; set; }

        public Pauta()
        {
            Indice = ++_contadorIndice;
        }

        public Pauta(string descripcion) : this()
        {
            Descripcion = descripcion;
        }
    }
}
