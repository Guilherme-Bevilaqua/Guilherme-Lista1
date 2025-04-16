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
    public partial class Form6_Guilherme : Form
    {
        public Form6_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double nRaio, nVolume, nAltura;

                nRaio = double.Parse(textBox1.Text);
                nAltura = double.Parse(textBox2.Text);

                nRaio = Math.Pow(nRaio, 2);

                nVolume = nRaio * nAltura * 3.14159;
                

                label5.Text = nVolume.ToString() + nVolume.ToString("m³");

            }

            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite o valor do Raio e Altura da lata de oleo para que se possa calcular o seu volume", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            label5.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
