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
    public partial class Form20_Guilherme : Form
    {
        public Form20_Guilherme()
        {
            InitializeComponent();
        }

        private void Form20_Guilherme_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            label12.Text = " ";
            label13.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int ano, semestre, ddd;

                ano = int.Parse(textBox2.Text);
                semestre = int.Parse(textBox3.Text);
                ddd = int.Parse(textBox4.Text);

                ano = ano + 2000;

                label12.Text = ano.ToString();
                label13.Text = semestre.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite o AA, S e DDD conforme pedido no formulario", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
