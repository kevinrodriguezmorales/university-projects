using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class FormAgregarInstruccion : Form
    {
        public event Action<string> Instruccionagregada;
        public FormAgregarInstruccion()
        {
            InitializeComponent();
        }

        private void FormAgregarInstruccion_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregarpaso_Click(object sender, EventArgs e)
        {
            string instruccion = txt_paso.Text.Trim();

            if (!string.IsNullOrEmpty(instruccion))
            {
                Instruccionagregada?.Invoke(instruccion);
                txt_paso.Clear();
            }
            else
            {
                MessageBox.Show("Por favor llenar la instruccion.", "Error");
            }
        }
    }
}
