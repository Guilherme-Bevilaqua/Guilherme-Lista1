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
    public partial class Form7_Guilherme : Form
    {
        public Form7_Guilherme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double nLitrosGasto, nVelocidadeMedia, nTempo, nDistancia;

            nTempo = double.Parse(textBox1.Text);
            nVelocidadeMedia = double.Parse(textBox2.Text);

            nDistancia = nTempo * nVelocidadeMedia;

            nLitrosGasto = nDistancia / 12;
            label5.Text = nLitrosGasto.ToString();

            label7.Text = nTempo.ToString() + nTempo.ToString(" Horas ");
            label9.Text = nVelocidadeMedia.ToString() + nVelocidadeMedia.ToString(" Km/h ");
            label11.Text = nDistancia.ToString() + nDistancia.ToString("Km");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            label5.Text = " ";
            label7.Text = " ";
            label9.Text = " ";
            label11.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Form7_Guilherme_Load(object sender, EventArgs e)
        {

        }
    }
}
