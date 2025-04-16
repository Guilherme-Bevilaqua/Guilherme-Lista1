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
    public partial class Form14_Guilherme : Form
    {
        public Form14_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double val1, val2, media;

                val1 = double.Parse(textBox1.Text);
                val2 = double.Parse(textBox2.Text);

                media = (val1 + val2) / 2;

                label5.Text = media.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show (" Porfavor, Digite o valor do primeiro e segundo numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
}
