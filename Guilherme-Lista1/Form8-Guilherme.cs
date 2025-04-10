using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guilherme_Lista1
{
    public partial class Form8_Guilherme : Form
    {
        public Form8_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double a, b, c;

                a = double.Parse(textBox1.Text);
                b = double.Parse(textBox2.Text);

                c = a;
                a = b;
                b = c;

                label6.Text = a.ToString();
                label7.Text = b.ToString();

            }
            catch (FormatException) {
                MessageBox.Show(" Porfavor, Digite o valor de A e B", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            label6.Text = " ";
            label7.Text = " ";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
