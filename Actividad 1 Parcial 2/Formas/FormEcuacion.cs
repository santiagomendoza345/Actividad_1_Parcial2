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
    public partial class FormEcuacion : Form
    {
        public FormEcuacion()
        {
            InitializeComponent();
        }

        private void buttonEcuacion_Click(object sender, EventArgs e)
        {
            double valorA, valorB, valorC, discriminante;

            if (!double.TryParse(textValorA.Text, out valorA) ||
                !double.TryParse(textValorB.Text, out valorB) ||
                !double.TryParse(textValorC.Text, out valorC))
            {
                MessageBox.Show("Por favor ingresa un numero para a b y c.");
                return;
            }
            if (valorA == 0)
            {
                MessageBox.Show("El valor de a no puede ser cero.");
                return;
            }
            discriminante = valorB * valorB - 4 * valorA * valorC;
            if (discriminante > 0)
            {
                double x1 = (-valorB + Math.Sqrt(discriminante)) / (2 * valorA);
                double x2 = (-valorB - Math.Sqrt(discriminante)) / (2 * valorA);
                MessageBox.Show($"Raíz 1: {x1}\nRaíz 2: {x2}");
            }
            else if (discriminante == 0)
            {
                double x1 = -valorB / (2 * valorA);
                MessageBox.Show($"Raíz única: {x1}");
            }
            else
            {
                double realPart = -valorB / (2 * valorA);
                double imaginaryPart = Math.Sqrt(Math.Abs(discriminante)) / (2 * valorA);
                MessageBox.Show($"Raíz 1 (Parte real): {realPart} + {imaginaryPart}i\n" +
                                $"Raíz 2 (Parte real): {realPart} - {imaginaryPart}i");

            }
        }

    }
}
