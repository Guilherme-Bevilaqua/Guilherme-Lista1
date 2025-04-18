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

                int dia, mes, ano;
                string ano2, mes2, dia2, digitos;

                dia = int.Parse(textBox1.Text);
                mes = int.Parse(textBox2.Text); 
                ano = int.Parse(textBox3.Text);
                
                mes2 = mes.ToString();
                dia2 = dia.ToString();

                if ( dia2.Length < 2 && mes2.Length < 2)
                {
                    dia2 = "0" + dia2;
                    mes2 = "0" + mes2;
                }

                ano2 = ano.ToString();
                digitos = ano2.Substring(ano2.Length - 2);

                label7.Text = digitos.ToString() + mes2.ToString() + dia2.ToString();

            }
            catch (FormatException)
            {
                MessageBox.Show(" Porfavor, Digite os valores no formato DDMMAA", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            label7.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
