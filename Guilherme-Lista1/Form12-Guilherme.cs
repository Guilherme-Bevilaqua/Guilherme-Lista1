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
    public partial class Form12_Guilherme : Form
    {
        public Form12_Guilherme()
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
                int a, b, quadradosoma;

                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);

                quadradosoma = (a + b) * (a + b);

                label5.Text = quadradosoma.ToString();

            }
            catch (FormatException) { MessageBox.Show (" Porfavor, digit o valor do primeiro e segundo numero", "Erro", MessageBoxButtons.OK
                , MessageBoxIcon.Warning); }

        }
    }
}
