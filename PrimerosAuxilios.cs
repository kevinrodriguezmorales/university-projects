namespace PrimerosAuxilios
{
    public partial class PrimerosAuxilios : Form
    {
        private GestorDeDatos gestor;
        public PrimerosAuxilios()
        {
            InitializeComponent();
            gestor = GestorDeDatos.Instance;
            CargarEmergencias();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CargarEmergencias()
        {
            cmbEmergencias.Items.Clear();

            GestorDeDatos.Instance.ObtenerTodasLasEmergencias().Recorrer(emergencia =>
            {
                cmbEmergencias.Items.Add(emergencia.Titulo);
            });

            if (cmbEmergencias.Items.Count > 0)
            {
                cmbEmergencias.SelectedIndex = 0;
            }
        }

        private void MostrarPautas(Emergencia emergencia)
        {
            lvPautas.Items.Clear();

            // Limpiar columnas previas si es necesario
            lvPautas.Columns.Clear();

            // Agregar las columnas
            lvPautas.Columns.Add("Índice", 80, HorizontalAlignment.Left);
            lvPautas.Columns.Add("Descripción", 400, HorizontalAlignment.Left);

            emergencia.Pautas.Recorrer(pauta =>
            {
                ListViewItem item = new ListViewItem(pauta.Indice.ToString());
                item.SubItems.Add(pauta.Descripcion);
                lvPautas.Items.Add(item);
            });
        }

        private void cmbEmergencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tituloSeleccionado = cmbEmergencias.SelectedItem as string;
            if (!string.IsNullOrEmpty(tituloSeleccionado))
            {
                var emergencia = gestor.BuscarPorTitulo(tituloSeleccionado).FirstOrDefault();
                if (emergencia != null)
                {
                    MostrarPautas(emergencia);
                }
            }
        }

        private void lvPautas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // NuevaEmergencia formNuevaEmergencia = new NuevaEmergencia();
            // formNuevaEmergencia.Show();

            using (var formNuevaEmergencia = new NuevaEmergencia())
            {
                if (formNuevaEmergencia.ShowDialog() == DialogResult.OK)
                {
                    // Aquí sí puedes actualizar el ComboBox
                    CargarEmergencias();
                }
            }
        }
    }
}
