using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guilherme_Lista1
{
    public partial class Form4_Guilherme : Form
    {
        public Form4_Guilherme()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double nCelsius, nFahrenheit;

                nCelsius = double.Parse(textBox2.Text);

                nFahrenheit = (9 * nCelsius + 160) / 5;

                label4.Text = nFahrenheit.ToString() + nCelsius.ToString( "°F");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira a temperatura em celsius ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            label4.Text = " ";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
