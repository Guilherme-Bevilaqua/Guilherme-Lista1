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
    public partial class Form17_Guilherme : Form
    {
        public Form17_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int n1, divisor, quociente, resto;

                n1 = int.Parse(textBox1.Text);
                divisor = int.Parse(textBox2.Text);

                quociente = n1 / divisor;
                resto = n1 % divisor;

                label6.Text = quociente.ToString();
                label7.Text = resto.ToString();

            }
            catch (FormatException){
                MessageBox.Show(" Porfavor, Digite o numero e seu divisor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
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
