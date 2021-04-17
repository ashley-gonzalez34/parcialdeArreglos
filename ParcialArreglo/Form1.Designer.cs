
namespace ParcialArreglo
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
            this.Cargar = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.listBoxContenido = new System.Windows.Forms.ListBox();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.listBoxPromedio1 = new System.Windows.Forms.ListBox();
            this.button1Parcial1 = new System.Windows.Forms.Button();
            this.buttonParcial2 = new System.Windows.Forms.Button();
            this.buttonParcial3 = new System.Windows.Forms.Button();
            this.label1p1 = new System.Windows.Forms.Label();
            this.button1Alumnos1 = new System.Windows.Forms.Button();
            this.buttonpromedio1 = new System.Windows.Forms.Button();
            this.button1promedio2 = new System.Windows.Forms.Button();
            this.buttonpromedio3 = new System.Windows.Forms.Button();
            this.buttonSuma = new System.Windows.Forms.Button();
            this.textsecciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGeneral = new System.Windows.Forms.Button();
            this.buttonpromed1 = new System.Windows.Forms.Button();
            this.buttonpromedio2 = new System.Windows.Forms.Button();
            this.button1promedio3 = new System.Windows.Forms.Button();
            this.buttonClasificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(22, 29);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(86, 26);
            this.Cargar.TabIndex = 0;
            this.Cargar.Text = "Cargar";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.Location = new System.Drawing.Point(352, 29);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(220, 160);
            this.listBoxResultado.TabIndex = 1;
            // 
            // listBoxContenido
            // 
            this.listBoxContenido.FormattingEnabled = true;
            this.listBoxContenido.Location = new System.Drawing.Point(127, 29);
            this.listBoxContenido.Name = "listBoxContenido";
            this.listBoxContenido.Size = new System.Drawing.Size(219, 160);
            this.listBoxContenido.TabIndex = 2;
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(22, 74);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(86, 27);
            this.buttonNombres.TabIndex = 3;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // listBoxPromedio1
            // 
            this.listBoxPromedio1.FormattingEnabled = true;
            this.listBoxPromedio1.Location = new System.Drawing.Point(127, 195);
            this.listBoxPromedio1.Name = "listBoxPromedio1";
            this.listBoxPromedio1.Size = new System.Drawing.Size(445, 173);
            this.listBoxPromedio1.TabIndex = 4;
            // 
            // button1Parcial1
            // 
            this.button1Parcial1.Location = new System.Drawing.Point(22, 122);
            this.button1Parcial1.Name = "button1Parcial1";
            this.button1Parcial1.Size = new System.Drawing.Size(86, 26);
            this.button1Parcial1.TabIndex = 5;
            this.button1Parcial1.Text = "parcial1";
            this.button1Parcial1.UseVisualStyleBackColor = true;
            this.button1Parcial1.Click += new System.EventHandler(this.button1Parcial1_Click);
            // 
            // buttonParcial2
            // 
            this.buttonParcial2.Location = new System.Drawing.Point(22, 166);
            this.buttonParcial2.Name = "buttonParcial2";
            this.buttonParcial2.Size = new System.Drawing.Size(86, 23);
            this.buttonParcial2.TabIndex = 6;
            this.buttonParcial2.Text = "Parcial2";
            this.buttonParcial2.UseVisualStyleBackColor = true;
            this.buttonParcial2.Click += new System.EventHandler(this.buttonParcial2_Click);
            // 
            // buttonParcial3
            // 
            this.buttonParcial3.Location = new System.Drawing.Point(22, 204);
            this.buttonParcial3.Name = "buttonParcial3";
            this.buttonParcial3.Size = new System.Drawing.Size(86, 27);
            this.buttonParcial3.TabIndex = 7;
            this.buttonParcial3.Text = "Parcial3";
            this.buttonParcial3.UseVisualStyleBackColor = true;
            this.buttonParcial3.Click += new System.EventHandler(this.buttonParcial3_Click);
            // 
            // label1p1
            // 
            this.label1p1.AutoSize = true;
            this.label1p1.Location = new System.Drawing.Point(29, 411);
            this.label1p1.Name = "label1p1";
            this.label1p1.Size = new System.Drawing.Size(94, 13);
            this.label1p1.TabIndex = 8;
            this.label1p1.Text = "ordenar promedios";
            // 
            // button1Alumnos1
            // 
            this.button1Alumnos1.Location = new System.Drawing.Point(127, 411);
            this.button1Alumnos1.Name = "button1Alumnos1";
            this.button1Alumnos1.Size = new System.Drawing.Size(83, 23);
            this.button1Alumnos1.TabIndex = 9;
            this.button1Alumnos1.Text = "alumnos";
            this.button1Alumnos1.UseVisualStyleBackColor = true;
            this.button1Alumnos1.Click += new System.EventHandler(this.button1Alumnos1_Click);
            // 
            // buttonpromedio1
            // 
            this.buttonpromedio1.Location = new System.Drawing.Point(216, 411);
            this.buttonpromedio1.Name = "buttonpromedio1";
            this.buttonpromedio1.Size = new System.Drawing.Size(78, 23);
            this.buttonpromedio1.TabIndex = 10;
            this.buttonpromedio1.Text = "promedio1";
            this.buttonpromedio1.UseVisualStyleBackColor = true;
            this.buttonpromedio1.Click += new System.EventHandler(this.buttonpromedio1_Click);
            // 
            // button1promedio2
            // 
            this.button1promedio2.Location = new System.Drawing.Point(311, 411);
            this.button1promedio2.Name = "button1promedio2";
            this.button1promedio2.Size = new System.Drawing.Size(80, 23);
            this.button1promedio2.TabIndex = 11;
            this.button1promedio2.Text = "promedio2";
            this.button1promedio2.UseVisualStyleBackColor = true;
            this.button1promedio2.Click += new System.EventHandler(this.button1promedio2_Click);
            // 
            // buttonpromedio3
            // 
            this.buttonpromedio3.Location = new System.Drawing.Point(412, 411);
            this.buttonpromedio3.Name = "buttonpromedio3";
            this.buttonpromedio3.Size = new System.Drawing.Size(85, 23);
            this.buttonpromedio3.TabIndex = 12;
            this.buttonpromedio3.Text = "promedio3";
            this.buttonpromedio3.UseVisualStyleBackColor = true;
            this.buttonpromedio3.Click += new System.EventHandler(this.buttonpromedio3_Click);
            // 
            // buttonSuma
            // 
            this.buttonSuma.Location = new System.Drawing.Point(516, 411);
            this.buttonSuma.Name = "buttonSuma";
            this.buttonSuma.Size = new System.Drawing.Size(75, 23);
            this.buttonSuma.TabIndex = 13;
            this.buttonSuma.Text = "Suma";
            this.buttonSuma.UseVisualStyleBackColor = true;
            this.buttonSuma.Click += new System.EventHandler(this.buttonSuma_Click);
            // 
            // textsecciones
            // 
            this.textsecciones.Location = new System.Drawing.Point(129, 385);
            this.textsecciones.Name = "textsecciones";
            this.textsecciones.Size = new System.Drawing.Size(466, 20);
            this.textsecciones.TabIndex = 14;
            this.textsecciones.Text = "ingrese ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "coloque seccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "promedio por secciones";
            // 
            // buttonGeneral
            // 
            this.buttonGeneral.Location = new System.Drawing.Point(578, 29);
            this.buttonGeneral.Name = "buttonGeneral";
            this.buttonGeneral.Size = new System.Drawing.Size(92, 27);
            this.buttonGeneral.TabIndex = 17;
            this.buttonGeneral.Text = "General promed";
            this.buttonGeneral.UseVisualStyleBackColor = true;
            this.buttonGeneral.Click += new System.EventHandler(this.buttonGeneral_Click);
            // 
            // buttonpromed1
            // 
            this.buttonpromed1.Location = new System.Drawing.Point(676, 29);
            this.buttonpromed1.Name = "buttonpromed1";
            this.buttonpromed1.Size = new System.Drawing.Size(77, 30);
            this.buttonpromed1.TabIndex = 18;
            this.buttonpromed1.Text = "promedio1";
            this.buttonpromed1.UseVisualStyleBackColor = true;
            this.buttonpromed1.Click += new System.EventHandler(this.buttonpromed1_Click);
            // 
            // buttonpromedio2
            // 
            this.buttonpromedio2.Location = new System.Drawing.Point(759, 29);
            this.buttonpromedio2.Name = "buttonpromedio2";
            this.buttonpromedio2.Size = new System.Drawing.Size(73, 30);
            this.buttonpromedio2.TabIndex = 19;
            this.buttonpromedio2.Text = "promedio2";
            this.buttonpromedio2.UseVisualStyleBackColor = true;
            this.buttonpromedio2.Click += new System.EventHandler(this.buttonpromedio2_Click);
            // 
            // button1promedio3
            // 
            this.button1promedio3.Location = new System.Drawing.Point(838, 28);
            this.button1promedio3.Name = "button1promedio3";
            this.button1promedio3.Size = new System.Drawing.Size(66, 27);
            this.button1promedio3.TabIndex = 20;
            this.button1promedio3.Text = "promedio3";
            this.button1promedio3.UseVisualStyleBackColor = true;
            this.button1promedio3.Click += new System.EventHandler(this.button1promedio3_Click);
            // 
            // buttonClasificacion
            // 
            this.buttonClasificacion.Location = new System.Drawing.Point(654, 132);
            this.buttonClasificacion.Name = "buttonClasificacion";
            this.buttonClasificacion.Size = new System.Drawing.Size(204, 91);
            this.buttonClasificacion.TabIndex = 21;
            this.buttonClasificacion.Text = "Clasificacion de alumnos";
            this.buttonClasificacion.UseVisualStyleBackColor = true;
            this.buttonClasificacion.Click += new System.EventHandler(this.buttonClasificacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 558);
            this.Controls.Add(this.buttonClasificacion);
            this.Controls.Add(this.button1promedio3);
            this.Controls.Add(this.buttonpromedio2);
            this.Controls.Add(this.buttonpromed1);
            this.Controls.Add(this.buttonGeneral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textsecciones);
            this.Controls.Add(this.buttonSuma);
            this.Controls.Add(this.buttonpromedio3);
            this.Controls.Add(this.button1promedio2);
            this.Controls.Add(this.buttonpromedio1);
            this.Controls.Add(this.button1Alumnos1);
            this.Controls.Add(this.label1p1);
            this.Controls.Add(this.buttonParcial3);
            this.Controls.Add(this.buttonParcial2);
            this.Controls.Add(this.button1Parcial1);
            this.Controls.Add(this.listBoxPromedio1);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.listBoxContenido);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.Cargar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.ListBox listBoxContenido;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.ListBox listBoxPromedio1;
        private System.Windows.Forms.Button button1Parcial1;
        private System.Windows.Forms.Button buttonParcial2;
        private System.Windows.Forms.Button buttonParcial3;
        private System.Windows.Forms.Label label1p1;
        private System.Windows.Forms.Button button1Alumnos1;
        private System.Windows.Forms.Button buttonpromedio1;
        private System.Windows.Forms.Button button1promedio2;
        private System.Windows.Forms.Button buttonpromedio3;
        private System.Windows.Forms.Button buttonSuma;
        private System.Windows.Forms.TextBox textsecciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGeneral;
        private System.Windows.Forms.Button buttonpromed1;
        private System.Windows.Forms.Button buttonpromedio2;
        private System.Windows.Forms.Button button1promedio3;
        private System.Windows.Forms.Button buttonClasificacion;
    }
}

