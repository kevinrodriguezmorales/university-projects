using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosAuxilios
{
    public partial class NuevaEmergencia : Form
    {
        private List<Pauta> _pautas = new List<Pauta>();
        public NuevaEmergencia()
        {
            InitializeComponent();

            // Agregar las columnas
            lvVistaPrevia.Columns.Add("Índice", 80, HorizontalAlignment.Left);
            lvVistaPrevia.Columns.Add("Descripción", 400, HorizontalAlignment.Left);
        }

        private void btnAnadirPauta_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtPauta.Text))
            {
                Pauta pauta = new Pauta(txtPauta.Text);
                _pautas.Add(pauta); // Agregar a la lista interna

                ListViewItem itemInView = new ListViewItem(pauta.Indice.ToString());
                itemInView.SubItems.Add(pauta.Descripcion);

                lvVistaPrevia.Items.Add(itemInView);

                txtPauta.Clear();
                txtPauta.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmergencia.Text))
            {
                MessageBox.Show("Por favor, ingrese un título para la emergencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_pautas.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos una pauta para la emergencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear la emergencia
            var tituloEmergencia = txtEmergencia.Text;
            var emergencia = new Emergencia(tituloEmergencia);


            // Agrega todas las pautas
            foreach (var pauta in _pautas)
            {
                emergencia.AgregarPauta(pauta);
            }

            // Registra la emergencia en el GestorDeDatos
            GestorDeDatos.Instance.AgregarEmergencia(emergencia);


            // Cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
