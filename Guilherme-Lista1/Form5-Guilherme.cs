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
    public partial class Form5_Guilherme : Form
    {
        public Form5_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double nCelsius, nFah;

            nFah = double.Parse(textBox1.Text);

            nCelsius = (nFah - 32) * 5 / 9;

            label5.Text = nCelsius.ToString() + nCelsius.ToString( "°C");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            label5.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }
    }
}
