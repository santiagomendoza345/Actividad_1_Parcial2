using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1_Parcial_2.Formas
{
    public partial class FormPesos : Form
    {
        public FormPesos()
        {
            InitializeComponent();
        }

        private bool ValidarDato(string input)
        {
            if (double.TryParse(input, out double value))
            {
                if (value <= 0)
                {
                    MessageBox.Show("El valor debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void buttonDolares_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textPesos.Text))
            {
                Double dolar, pesosMXN;
                pesosMXN = double.Parse(textPesos.Text);
                dolar = pesosMXN * 0.057 / 2;
                textResultDolares.Text = dolar.ToString();
            }
        }

        private void buttonEuros_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textPesos.Text))
            {
                Double euro, pesosMXN;
                pesosMXN = double.Parse(textPesos.Text);
                euro = pesosMXN * 0.054 / 2;
                textResultEuros.Text = euro.ToString();
            }
        }

        private void textResultEuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResultDolares_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
