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
    public partial class Form19_Guilherme : Form
    {
        public Form19_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               /* string formato1, formato2;

                formato1 = textBox1.Text;



                char[] charArray  = formato1.ToCharArray();
                Array.Reverse(charArray);
                formato2 = new string(charArray);

                int formatoint;

                formatoint = int.Parse(formato2);

                label7.Text = formatoint.ToString(); */

            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite os valores no formato DDMMAA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
