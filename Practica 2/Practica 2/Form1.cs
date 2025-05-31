namespace Practica_2
{
    public partial class Form1 : Form
    {
        FormAgregarInstruccion formAgregar;
        public Form1()
        {
            InitializeComponent();
        }

        private void ckl_opciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ckl_opciones.Items.Add("Pide ayuda medica");
            ckl_opciones.Items.Add("Cubre a la persona para que no se enfrie");
            ckl_opciones.Items.Add("Intente reconocer el producto ingerido");
            ckl_opciones.Items.Add("Lava la herida con agua");
            ckl_opciones.Items.Add("Si es pequeña y no sangra, lava con agua y jabon y cubrela con gasa");
            ckl_opciones.Items.Add("Si es grande y no para de sangrar cubrela con gasa y presiona");
            ckl_opciones.Items.Add("Quita todo los accesorios: relojes, pulseras, anillos");
            ckl_opciones.Items.Add("Lava la zona con abundante agua durante 15 minutos");
            ckl_opciones.Items.Add("Si es grave, pide atencion medica inmediata. No uses pomadas ni cremas");

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            lst_muestreo.Items.Add("---------------");
            string emergencia = txt_emergencia.Text.Trim();

            if (!string.IsNullOrEmpty(emergencia))
            {
                lst_muestreo.Items.Add($"La emergencia es : {emergencia}");
            }
            else
            {
                lst_muestreo.Items.Add("No especifico ninguna emergencia");
            }

            if (ckl_opciones.CheckedItems.Count > 0)
            {
                lst_muestreo.Items.Add("Pasos de cuidado:");
                foreach (var item in ckl_opciones.CheckedItems)
                {
                    lst_muestreo.Items.Add("- " + item.ToString());
                }
            }
            else
            {
                lst_muestreo.Items.Add("No a seleccionado ningun paso.");
            }
        }

        private void txt_emergencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formAgregar == null || formAgregar.IsDisposed)
            {
                formAgregar = new FormAgregarInstruccion();

                // Suscribirse al evento
                formAgregar.Instruccionagregada += (opcion) =>
                {
                    if (!ckl_opciones.Items.Contains(opcion))
                    {
                        ckl_opciones.Items.Add(opcion);
                    }
                    else
                    {
                        MessageBox.Show("La opción ya existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                };

                formAgregar.Show(); // Mostrar sin cerrar el principal
            }
            else
            {
                formAgregar.BringToFront();
            }
        }
    }
}

