using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcialArreglo.CLASE
{
    class ClsArchivo
    {
        public string abrirarchvio { get; private set; }
        public string[] columna { get; private set; }
        public ClsArchivo()
        {
            this.Cargar();
        }
        private string Cargar()
        {
            OpenFileDialog ar = new OpenFileDialog();
            ar.Title = "Seleccione su Archivo Plano!";
            ar.InitialDirectory = " @ C:/clase/ArchivoPlano.csv";
            ar.Filter = "Archivos CSV|*.csv";
            if (ar.ShowDialog() == DialogResult.OK)
            {
                this.abrirarchvio = ar.FileName;
            }
            return this.abrirarchvio;
        }
        public string[] traerarchivo()
        {
            string[] filas = File.ReadAllLines(this.abrirarchvio, Encoding.ASCII);
            this.columna = filas;
            return filas;


        }
    }
}
