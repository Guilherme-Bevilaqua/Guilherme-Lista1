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
    public partial class Form11_Guilherme : Form
    {
        public Form11_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num1, quadrado, cubo;

            num1 = int.Parse(textBox1.Text);

            quadrado = Math.Pow(num1, 2);
            cubo = Math.Pow(num1, 3);

            quadrado = Convert.ToInt32(quadrado);
            cubo = Convert.ToInt32(cubo);

            label8.Text = quadrado.ToString();
            label4.Text = cubo.ToString();


        }
    }
}
