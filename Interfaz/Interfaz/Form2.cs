using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Interfaz
{
    public partial class Form2 : Form
    {
        public int cantImagenes;
        public int siguienteImg=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cantImagenes = AlgoritmoGenetico.AGenetico.listaMejoresImagenes.Length;
            if (siguienteImg<cantImagenes)
            {
                pictureBox1.Image = AlgoritmoGenetico.AGenetico.listaMejoresImagenes[siguienteImg].img;
                siguienteImg++;
            }
            else
            {
                siguienteImg = 0;
                pictureBox1.Image = AlgoritmoGenetico.AGenetico.listaMejoresImagenes[siguienteImg].img;
            }
        }
    }
}
