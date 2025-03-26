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
                double p1, raio, area;
                raio = double.Parse(textBox1.Text);

                p1 = 3.14159;
                area = p1 * (raio * raio);

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valor do raio da circunsferencia", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
