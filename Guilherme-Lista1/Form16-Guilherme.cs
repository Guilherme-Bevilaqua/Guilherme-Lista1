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
    public partial class Form16_Guilherme : Form
    {
        public Form16_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double km, ms;

                km = double.Parse(textBox1.Text);

                ms = km / 3.6;

                label4.Text = ms.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show (" Porfavor, Digite o valor da velocidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();

            label4.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
