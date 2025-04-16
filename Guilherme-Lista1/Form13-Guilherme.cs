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
    public partial class Form13_Guilherme : Form
    {
        public Form13_Guilherme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Form13_Guilherme_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            label5.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, somaquadrado;

                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);

                somaquadrado = (a * a) + (b * b);

                label5.Text = somaquadrado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show (" Porfavor, Digite o valor do primeiro e segundo numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
