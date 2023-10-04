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
    public partial class FormSalario : Form
    {
        public FormSalario()
        {
            InitializeComponent();
        }

        private bool ValidarDato(string input)
        {
            if (double.TryParse(input, out double value))
            {
                if (value < 0)
                {
                    MessageBox.Show("El valor no puede ser negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonNewSalario_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textAumento.Text) && ValidarDato(textSalarioActual.Text))
            {
                Double salarioAct, newSalario, salarioNuevo, salarioActual, aumento;
                aumento = double.Parse(textAumento.Text);
                salarioActual = double.Parse(textSalarioActual.Text);
                salarioAct = double.Parse(textSalarioActual.Text);
                newSalario = salarioAct / 100 * aumento;
                salarioNuevo = newSalario + salarioActual;
                textSalarioNuevo.Text = salarioNuevo.ToString();
            }
        }

        private void textSalarioNuevo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
