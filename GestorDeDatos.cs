using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosAuxilios
{
    internal class GestorDeDatos
    {
        private ListaEnlazada<Emergencia> _listaEmergencias;

        public GestorDeDatos()
        {
            _listaEmergencias = new ListaEnlazada<Emergencia>();
            InicializarDatos();
        }

        // Datos iniciales (opcional)
        private void InicializarDatos()
        {
            var ingestion = new Emergencia("Ingestión de productos químicos");
            ingestion.AgregarPauta(new Pauta("Pide ayuda médica."));
            ingestion.AgregarPauta(new Pauta("Cubre a la persona para que no se enfríe."));
            ingestion.AgregarPauta(new Pauta("Intenta reconocer el producto ingerido."));

            _listaEmergencias.InsertarAlFinal(ingestion);

            var derrameProductos = new Emergencia("Derrame de productos químicos sobre la piel");
            derrameProductos.AgregarPauta(new Pauta(">> Lava la zona con abundante agua durante 15 minutos."));
            derrameProductos.AgregarPauta(new Pauta(">> Si la zona perjudica es grande, usa la ducha. Bajo el agua, quita la ropa impregnada."));
            derrameProductos.AgregarPauta(new Pauta(">> Quita todos los accesorios: relojes, pulseras, anillos…"));
            derrameProductos.AgregarPauta(new Pauta(">> Pide asistencia médica."));

            _listaEmergencias.InsertarAlFinal(derrameProductos);
        }

        // Insertar nueva emergencia
        public void AgregarEmergencia(Emergencia emergencia)
        {
            _listaEmergencias.InsertarAlFinal(emergencia);
        }

        // Obtener todas las emergencias
        public ListaEnlazada<Emergencia> ObtenerTodasLasEmergencias()
        {
            return _listaEmergencias;
        }

        // Buscar por ID
        public Emergencia BuscarPorID(int id)
        {
            return _listaEmergencias.Buscar(e => e.ID == id);
        }

        // Buscar por título (parcial o completo)
        public List<Emergencia> BuscarPorTitulo(string titulo)
        {
            return _listaEmergencias.BuscarTodos(e =>
                e.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0);
        }
    }
}
