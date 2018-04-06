namespace Interfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTamañoPoblacion = new System.Windows.Forms.TextBox();
            this.txtProbDeMutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAbrir = new System.Windows.Forms.Label();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMenosAptos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMutacionImagen = new System.Windows.Forms.TextBox();
            this.radioManCol = new System.Windows.Forms.RadioButton();
            this.radioBProCol = new System.Windows.Forms.RadioButton();
            this.radioBManPro = new System.Windows.Forms.RadioButton();
            this.radioBProPro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantGeneraciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGuardar = new System.Windows.Forms.TextBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTamañoPoblacion
            // 
            this.txtTamañoPoblacion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtTamañoPoblacion.Location = new System.Drawing.Point(192, 51);
            this.txtTamañoPoblacion.Name = "txtTamañoPoblacion";
            this.txtTamañoPoblacion.Size = new System.Drawing.Size(39, 20);
            this.txtTamañoPoblacion.TabIndex = 1;
            this.txtTamañoPoblacion.Text = "0";
            this.txtTamañoPoblacion.TextChanged += new System.EventHandler(this.txtTamañoPoblacion_TextChanged);
            // 
            // txtProbDeMutar
            // 
            this.txtProbDeMutar.Location = new System.Drawing.Point(232, 123);
            this.txtProbDeMutar.Name = "txtProbDeMutar";
            this.txtProbDeMutar.Size = new System.Drawing.Size(39, 20);
            this.txtProbDeMutar.TabIndex = 3;
            this.txtProbDeMutar.Text = "0";
            this.txtProbDeMutar.TextChanged += new System.EventHandler(this.txtProbDeMutar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamaño de la población inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Probabilidad de mutación de población";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblAbrir
            // 
            this.lblAbrir.AutoSize = true;
            this.lblAbrir.Location = new System.Drawing.Point(371, 337);
            this.lblAbrir.Name = "lblAbrir";
            this.lblAbrir.Size = new System.Drawing.Size(0, 13);
            this.lblAbrir.TabIndex = 7;
            this.lblAbrir.Visible = false;
            this.lblAbrir.Click += new System.EventHandler(this.lblAbrir_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAbrir.Location = new System.Drawing.Point(622, 342);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.Location = new System.Drawing.Point(357, 22);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(312, 512);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(312, 312);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 312);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(622, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(488, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seleccione una imagen";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Porcentaje de individuos menos aptos a mantener";
            // 
            // txtMenosAptos
            // 
            this.txtMenosAptos.Location = new System.Drawing.Point(289, 205);
            this.txtMenosAptos.Name = "txtMenosAptos";
            this.txtMenosAptos.Size = new System.Drawing.Size(39, 20);
            this.txtMenosAptos.TabIndex = 15;
            this.txtMenosAptos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Probaabilidad de mutación de imagen";
            // 
            // txtMutacionImagen
            // 
            this.txtMutacionImagen.Location = new System.Drawing.Point(226, 167);
            this.txtMutacionImagen.Name = "txtMutacionImagen";
            this.txtMutacionImagen.Size = new System.Drawing.Size(43, 20);
            this.txtMutacionImagen.TabIndex = 17;
            this.txtMutacionImagen.Text = "0";
            // 
            // radioManCol
            // 
            this.radioManCol.AutoSize = true;
            this.radioManCol.Location = new System.Drawing.Point(41, 248);
            this.radioManCol.Name = "radioManCol";
            this.radioManCol.Size = new System.Drawing.Size(252, 17);
            this.radioManCol.TabIndex = 18;
            this.radioManCol.TabStop = true;
            this.radioManCol.Text = "Distancia Manhattan con Histograma de colores";
            this.radioManCol.UseVisualStyleBackColor = true;
            // 
            // radioBProCol
            // 
            this.radioBProCol.AutoSize = true;
            this.radioBProCol.Location = new System.Drawing.Point(41, 271);
            this.radioBProCol.Name = "radioBProCol";
            this.radioBProCol.Size = new System.Drawing.Size(230, 17);
            this.radioBProCol.TabIndex = 19;
            this.radioBProCol.TabStop = true;
            this.radioBProCol.Text = "Distancia propia con Histograma de colores";
            this.radioBProCol.UseVisualStyleBackColor = true;
            // 
            // radioBManPro
            // 
            this.radioBManPro.AutoSize = true;
            this.radioBManPro.Location = new System.Drawing.Point(41, 294);
            this.radioBManPro.Name = "radioBManPro";
            this.radioBManPro.Size = new System.Drawing.Size(232, 17);
            this.radioBManPro.TabIndex = 20;
            this.radioBManPro.TabStop = true;
            this.radioBManPro.Text = "Distancia Manhattan con Histograma propio";
            this.radioBManPro.UseVisualStyleBackColor = true;
            this.radioBManPro.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioBProPro
            // 
            this.radioBProPro.AutoSize = true;
            this.radioBProPro.Location = new System.Drawing.Point(41, 317);
            this.radioBProPro.Name = "radioBProPro";
            this.radioBProPro.Size = new System.Drawing.Size(210, 17);
            this.radioBProPro.TabIndex = 21;
            this.radioBProPro.TabStop = true;
            this.radioBProPro.Text = "Distancia propia con Histograma propio";
            this.radioBProPro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Cantidad de generaciones deseadas";
            // 
            // txtCantGeneraciones
            // 
            this.txtCantGeneraciones.Location = new System.Drawing.Point(227, 81);
            this.txtCantGeneraciones.Name = "txtCantGeneraciones";
            this.txtCantGeneraciones.Size = new System.Drawing.Size(42, 20);
            this.txtCantGeneraciones.TabIndex = 23;
            this.txtCantGeneraciones.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccione donde guardar la imagen resultante";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(41, 378);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(287, 20);
            this.txtGuardar.TabIndex = 25;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSeleccionar.Location = new System.Drawing.Point(41, 419);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(72, 22);
            this.BtnSeleccionar.TabIndex = 26;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(709, 461);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantGeneraciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioBProPro);
            this.Controls.Add(this.radioBManPro);
            this.Controls.Add(this.radioBProCol);
            this.Controls.Add(this.radioManCol);
            this.Controls.Add(this.txtMutacionImagen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMenosAptos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.lblAbrir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProbDeMutar);
            this.Controls.Add(this.txtTamañoPoblacion);
            this.Location = new System.Drawing.Point(12, 12);
            this.MaximumSize = new System.Drawing.Size(725, 500);
            this.MinimumSize = new System.Drawing.Size(725, 457);
            this.Name = "Form1";
            this.Text = "Tarea Programada 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTamañoPoblacion;
        private System.Windows.Forms.TextBox txtProbDeMutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAbrir;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMenosAptos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMutacionImagen;
        private System.Windows.Forms.RadioButton radioManCol;
        private System.Windows.Forms.RadioButton radioBProCol;
        private System.Windows.Forms.RadioButton radioBManPro;
        private System.Windows.Forms.RadioButton radioBProPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantGeneraciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGuardar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

