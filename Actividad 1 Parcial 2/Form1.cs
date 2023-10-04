using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad_1_Parcial_2.Formas;

namespace Actividad_1_Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuArea_Click(object sender, EventArgs e)
        {
            FormArea home = new FormArea();
            home.Show();
        }

        private void menuPesos_Click(object sender, EventArgs e)
        {
            FormPesos home = new FormPesos();
            home.Show();
        }

        private void menuLatidos_Click(object sender, EventArgs e)
        {
            FormLatidosM home = new FormLatidosM();
            home.Show();
        }

        private void menuSalario_Click(object sender, EventArgs e)
        {
            FormSalario home = new FormSalario();
            home.Show();
        }

        private void menuEcuacion_Click(object sender, EventArgs e)
        {
            FormEcuacion home = new FormEcuacion();
            home.Show();
        }
    }
}
