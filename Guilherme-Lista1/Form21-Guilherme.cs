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
    public partial class Form21_Guilherme : Form
    {
        public Form21_Guilherme()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string nome, sobrenome, nomecompleto;

                nome = textBox1.Text;
                sobrenome = textBox2.Text;

                nomecompleto = nome + " " + sobrenome;

                label5.Text = nomecompleto;

            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite seu nome e sobrenome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
