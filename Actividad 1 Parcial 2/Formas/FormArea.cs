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
    public partial class FormArea : Form
    {
        public FormArea()
        {
            InitializeComponent();
        }

        private bool ValidarDatos(double baseT, double alturaT)
        {
            if (baseT <= 0 || alturaT <= 0)
            {
                MessageBox.Show("La base y la altura deben ser valores positivos mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBase.Text, out double baseT) && double.TryParse(textAltura.Text, out double alturaT))
            {
                if (ValidarDatos(baseT, alturaT))
                {
                    double area = baseT * alturaT / 2;
                    textArea.Text = area.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBase_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textArea_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FormArea_Load(object sender, EventArgs e)
        {

        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
