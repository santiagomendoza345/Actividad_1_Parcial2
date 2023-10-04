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
    public partial class FormLatidosM : Form
    {
        public FormLatidosM()
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

        private void buttonLatidos_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textEdad.Text))
            {
                Double latidos, edad;
                edad = double.Parse(textEdad.Text);
                latidos = 220 - edad;
                textFCM.Text = latidos.ToString();
            }
        }

        private void button60segH_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textEdad.Text))
            {
                Double latidosH, edad, FCM;
                edad = double.Parse(textEdad.Text);
                FCM = 220 - edad;
                latidosH = (FCM - edad) / 2;
                text60segH.Text = latidosH.ToString();
            }
        }

        private void button60segM_Click(object sender, EventArgs e)
        {
            if (ValidarDato(textEdad.Text))
            {
                Double latidosM, edad, FCM;
                edad = double.Parse(textEdad.Text);
                FCM = 220 - edad;
                latidosM = (FCM - edad) / 2.3;
                text60segM.Text = latidosM.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void text60segH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}