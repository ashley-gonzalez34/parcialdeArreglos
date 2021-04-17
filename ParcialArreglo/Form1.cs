using ParcialArreglo.CLASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialArreglo
{
    public partial class Form1 : Form
    {
        public string[,] matrices;
        ClsArreglos arreglo = new ClsArreglos();
        ClsPromedio promedios = new ClsPromedio();
        public Form1()
        {
            InitializeComponent();
        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            
            ClsArchivo archivo = new ClsArchivo(); 
            this.listBoxContenido.Text = archivo.abrirarchvio; 
            string[] filas = archivo.traerarchivo(); 

            
             
            foreach (string lineas in filas)
            {
                this.listBoxContenido.Items.Add(lineas);
            }

            

            this.matrices = arreglo.Dimensiones(filas, 7);


        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string[] datos = arreglo.MetodoBurbujaCadena(this.matrices, 1);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i]);
            }
     
        
        
        
        }

        private void button1Parcial1_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 2);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i]);
            }
        }

        private void buttonParcial2_Click(object sender, EventArgs e)
        {
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i]);
            }
        }

        private void buttonParcial3_Click(object sender, EventArgs e)
        {

           
            int[] datos = arreglo.MetodoBurbuja(this.matrices, 3);
            for (int i = 0; i < datos.Length; i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i]);
            }
        }

        private void button1Alumnos1_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();

            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                this.listBoxPromedio1.Items.Add(matrices[i, 1] + " - " + matrices[i, 6]);
            }
        }

        private void buttonpromedio1_Click(object sender, EventArgs e)
        {
            
            int datos = promedios.promedios_cada_parcial(this.matrices, 2);
            this.listBoxPromedio1.Items.Add("Promedio por Parcial Uno: " + datos);
        }

        private void button1promedio2_Click(object sender, EventArgs e)
        {
           
            int datos = promedios.promedios_cada_parcial(this.matrices, 3);
            this.listBoxPromedio1.Items.Add("Promedio por Parcial Dos: " + datos);
        }

        private void buttonpromedio3_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            int datos = promedios.promedio_cada_parcial(this.matrices, 4);
            this.listBoxPromedio1.Items.Add("Promedio por Parcial Dos: " + datos);
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string[,] datos = promedios.suma_general_por_alumno(this.matrices);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i, 0] + "- Suma de todo: " + datos[i, 1]);
            }
        }

        private void buttonGeneral_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string seccion = this.textsecciones.Text;
            int datos = promedios.promedio_secciones(this.matrices, 6, seccion);
            this.listBoxPromedio1.Items.Add("Promedio General Por cada Seccion " + seccion + " :" + datos);
        }

        private void buttonpromed1_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string seccion = this.textsecciones.Text;
            int datos = promedios.promedio_secciones(this.matrices, 2, seccion);
            this.listBoxPromedio1.Items.Add("Promedio General Por cada Uno en la Sección " + seccion + " :" + datos);
        }

        private void buttonpromedio2_Click(object sender, EventArgs e)
        {

            this.listBoxPromedio1.Items.Clear();
            string seccion = this.textsecciones.Text;
            int datos = promedios.promedio_secciones(this.matrices, 3, seccion);
            this.listBoxPromedio1.Items.Add("Promedio General Por cada Uno en la Sección " + seccion + " :" + datos);
        }

        private void button1promedio3_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string seccion = this.textsecciones.Text;
            int datos = promedios.promedio_secciones(this.matrices, 3, seccion);
            this.listBoxPromedio1.Items.Add("Promedio General Por cada Uno en la Sección " + seccion + " :" + datos);
        }


        private void buttonClasificacion_Click(object sender, EventArgs e)
        {
            this.listBoxPromedio1.Items.Clear();
            string seccion = this.textsecciones.Text;
            string[,] datos = promedios.Clasificar_Alumnos(this.matrices, seccion);
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                this.listBoxPromedio1.Items.Add(datos[i, 0] + "; " + datos[i, 1] + "; " + datos[i, 2] + "; " + datos[i, 3] + "; " + datos[i, 4] + "; " + datos[i, 5] + "; " + datos[i, 6] + "; ");
            }
        }

       
    }







}






 