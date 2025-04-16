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
    public partial class Form18_Guilherme : Form
    {
        public Form18_Guilherme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();

            label7.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double salariobruto, desconto1, desconto2;

                salariobruto = double.Parse(textBox1.Text);

                desconto1 = (salariobruto * 10) / 100;
                salariobruto = salariobruto - desconto1;

                desconto2 = (salariobruto * 5) / 100;
                salariobruto = salariobruto - desconto2;

                label7.Text = ( "$" ) + salariobruto.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show (" Porfavor, Digite o valor do salario Bruto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
