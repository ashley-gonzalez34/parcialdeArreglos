using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialArreglo.CLASE
{
    class ClsArreglos
    {




        public string[,] Dimensiones(string[] datoss, int numerodelosdatos)
        {
            string[,] arreglodosdimensiones = new string[datoss.Length - 1, numerodelosdatos];
            int contador = 0;
            foreach (string fila in datoss)
            {
                if (contador > 0)
                {
                    string[] datos = fila.Split(',');

                    arreglodosdimensiones[contador - 1, 0] = datoss[0]; //Correlativo
                    arreglodosdimensiones[contador - 1, 1] = datoss[1]; //Nombre de los alumnos
                    arreglodosdimensiones[contador - 1, 2] = datoss[2]; //Parcial1
                    arreglodosdimensiones[contador - 1, 3] = datoss[3]; //Parcial2
                    arreglodosdimensiones[contador - 1, 4] = datoss[4]; //ExamenFinal
                    arreglodosdimensiones[contador - 1, 5] = datoss[5]; //Seccion

                    int suma = Convert.ToInt32(datoss[2]) + Convert.ToInt32(datoss[3]) + Convert.ToInt32(datoss[4]);
                   int promedios = suma / 3;

                    arreglodosdimensiones[contador - 1, 6] = Convert.ToString(promedios);
                }
                contador++;
            }
            return arreglodosdimensiones;
        }




        public ClsArreglos()
        {
        }

        /// <summary>
        ///  Burbuja
        ///  intercambiar cada pareja consecutiva
        /// </summary>
        /// <returns></return

        public int[] MetodoBurbuja(string[,] matrices, int columna)
        {


            int[] arreglo = new int[matrices.GetLength(0) - 1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(matrices[i, columna]);
            }


            int[] ArregloTemporal = arreglo;
            int datosTemporal;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = i + 1; j < arreglo.GetLength(0); j++)
                {

                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;

        }



            public string[] MetodoBurbujaCadena(string[,] matrices, int dato)
            {
                string[] arreglo = new string[matrices.GetLength(0) - 1];

                for (int i = 0; i < arreglo.Length; i++)
                {
                    arreglo[i] = matrices[i, dato];
                }

                string[] ArregloTemporal = arreglo;
                string datosTemporal;

                for (int i = 0; i < arreglo.Length; i++)
                {
                    for (int j = i + 1; j < arreglo.Length; j++)
                    {

                        if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                        {
                            datosTemporal = ArregloTemporal[i];
                            ArregloTemporal[i] = ArregloTemporal[j];
                            ArregloTemporal[j] = datosTemporal;
                        }
                    }
                }
                return arreglo;
            }
        

    }
}




