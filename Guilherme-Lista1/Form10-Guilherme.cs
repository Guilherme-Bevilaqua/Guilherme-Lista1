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
    public partial class Form10_Guilherme : Form
    {
        public Form10_Guilherme()
        {
            InitializeComponent();
        }

        private void Form10_Guilherme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                double Altura, Comprimento, Largura, Volume;

                Comprimento = double.Parse(textBox1.Text);
                Largura = double.Parse(textBox2.Text); 
                Altura = double.Parse(textBox3.Text);

                Volume = Comprimento * Largura * Altura;

                label8.Text = Volume.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite o valor da Comprimento, Largura e Altura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label8.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
