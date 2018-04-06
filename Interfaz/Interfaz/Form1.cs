using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            AlgoritmoGenetico.AGenetico = new AlgoritmoGenetico();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void lblAbrir_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "imagenes|*.jpg;*.png";
            openFileDialog1.Title = "Abriendo imagen";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblAbrir.Text=openFileDialog1.FileName;
                string urlArchivo = openFileDialog1.FileName;
                string nombre = openFileDialog1.SafeFileName;             
                pictureBox1.Load(urlArchivo);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Bitmap imgMeta = new Bitmap(lblAbrir.Text);
            AlgoritmoGenetico.AGenetico.imagenMeta = new Imagen(imgMeta);
            AlgoritmoGenetico.AGenetico.poblacionInicial = int.Parse(txtTamañoPoblacion.Text);
            AlgoritmoGenetico.AGenetico.porcentajeMenosAptos = int.Parse(txtMenosAptos.Text);
            AlgoritmoGenetico.AGenetico.probabilidadMutacion = int.Parse(txtProbDeMutar.Text);
            AlgoritmoGenetico.AGenetico.porcentajeMutacionImg = int.Parse(txtMutacionImagen.Text);
            AlgoritmoGenetico.AGenetico.cantidadGeneraciones = int.Parse(txtCantGeneraciones.Text);
            AlgoritmoGenetico.AGenetico.rutaGuardar = txtGuardar.Text;
            if (radioManCol.Checked==true)
            {
                AlgoritmoGenetico.AGenetico.opcionAEjecutar = "ManhattanColor";
            }
            else if (radioBManPro.Checked==true)
            {
                AlgoritmoGenetico.AGenetico.opcionAEjecutar = "ManhattanPropio";
            }
            else if (radioBProCol.Checked == true)
            {
                AlgoritmoGenetico.AGenetico.opcionAEjecutar = "PropioColor";
            }
            else if (radioBProPro.Checked==true)
            {
                AlgoritmoGenetico.AGenetico.opcionAEjecutar = "PropioPropio";
            }

            AlgoritmoGenetico.AGenetico.Algoritmo();

 
            AlgoritmoGenetico.AGenetico.poblacionInicial = 0;
            AlgoritmoGenetico.AGenetico.porcentajeMenosAptos = 0;
            AlgoritmoGenetico.AGenetico.probabilidadMutacion = 0;
            AlgoritmoGenetico.AGenetico.porcentajeMutacionImg = 0;
            AlgoritmoGenetico.AGenetico.cantidadGeneraciones = 0;
            txtTamañoPoblacion.Text = "0";
            txtMenosAptos.Text = "0";
            txtProbDeMutar.Text = "0";
            txtMutacionImagen.Text = "0";
            txtCantGeneraciones.Text = "0";

            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            return;
        }

        private void txtProbDeMutar_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void txtTamañoPoblacion_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            return;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            return;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtGuardar.Text = folderBrowserDialog1.SelectedPath;
              
            }
        }
    }
}
