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
    public partial class Form9_Guilherme : Form
    {
        public Form9_Guilherme()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Form9_Guilherme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                double A, B, C, D, ASomaB, ASomaC, ASomaD, AMultiB, AMultiC, AMultiD, BSomaC, BSomaD, BMultiC, BMultiD, CSomaD, CMultiD;

                A = double.Parse(textBox1.Text);
                B = double.Parse(textBox2.Text);
                C = double.Parse(textBox3.Text);
                D = double.Parse(textBox4.Text);

                ASomaB = A + B;
                ASomaC = A + C;
                ASomaD = A + D;
                AMultiB = A * B;
                AMultiC = A * C;
                AMultiD = A * D;

                BSomaC = B + C;
                BSomaD = B + D; 
                BMultiC = B * C;
                BMultiD = B * D;

                CSomaD = C + D;
                CMultiD = C * D;

                
                label8.Text = ASomaB.ToString();
                label9.Text = AMultiB.ToString();

                label12.Text = ASomaC.ToString();
                label13.Text = AMultiC.ToString();

                label16.Text = ASomaD.ToString();
                label17.Text = AMultiD.ToString();

                label22.Text = BSomaC.ToString();
                label23.Text = BMultiC.ToString();

                label24.Text = BSomaD.ToString();
                label25.Text = BMultiD.ToString();

                label28.Text = CSomaD.ToString();
                label29.Text = CMultiD.ToString();


            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite o valor de A, B, C e D", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            label8.Text = " ";
            label9.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
            label16.Text = " ";
            label17.Text = " ";
            label22.Text = " ";
            label23.Text = " ";
            label24.Text = " ";
            label25.Text = " ";
            label28.Text = " ";
            label29.Text = " ";

        }
    }
}
