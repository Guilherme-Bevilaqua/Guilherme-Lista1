using System;
using System.Windows.Forms;

namespace Guilherme_Lista1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double nPi, raio, area;
                raio = double.Parse(textBox1.Text);

                nPi = 3.14159;
                area = nPi * (raio * raio);


                label4.Text = area.ToString() + area.ToString("cm²");

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valor do raio da circunsferencia", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
