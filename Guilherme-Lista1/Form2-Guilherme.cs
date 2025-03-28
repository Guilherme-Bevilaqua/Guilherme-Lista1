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
    public partial class Form2_Guilherme : Form
    {
        public Form2_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int n1, n2, resultado;

                n1 = Convert.ToInt32(textBox1.Text);
                n2 = Convert.ToInt32(textBox2.Text);

                resultado = n1 + n2;

                label5.Text = resultado.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores validos para horas trabalhadas, valor da hora e percentual de desconto, ", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
