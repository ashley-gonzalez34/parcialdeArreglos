using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialArreglo.CLASE
{
    class ClsPromedio : Interfacepromedios
    {
        string[,] Interfacepromedios.Clasificacion_Alumnos(string[,] matrices, string secciones)
        {
            int alumnosEnSeccion = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)
                {
                    alumnosEnSeccion++;
                }
            }
            string[,] datos = new string[alumnosEnSeccion, matrices.GetLength(1)];
            int NuevaMatriz = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)
                {
                    datos[NuevaMatriz, 0] = matrices[i, 0];
                    datos[NuevaMatriz, 1] = matrices[i, 1];
                    datos[NuevaMatriz, 2] = matrices[i, 2];
                    datos[NuevaMatriz, 3] = matrices[i, 3];
                    datos[NuevaMatriz, 4] = matrices[i, 4];
                    datos[NuevaMatriz, 5] = matrices[i, 5];
                    datos[NuevaMatriz, 6] = matrices[i, 6];
                    NuevaMatriz++;
                }
            }
            return datos;

        }

        

        int Interfacepromedios.promedio_general_secciones(string[,] matrices, int columna_parcial, string secciones)
        {
            int suma = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)
                {
                    suma = suma + Convert.ToInt32(matrices[i, columna_parcial]);
                }
            }
            int promedio = suma / matrices.GetLength(0);
            return promedio;
        }

        int Interfacepromedios.promedio_secciones(string[,] matrices, int columna_parcial, string secciones)
        {
            int acumulador = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                if (matrices[i, 5] == secciones)
                {
                    acumulador = acumulador + Convert.ToInt32(matrices[i, columna_parcial]);
                }
            }

            int promedio = acumulador / matrices.GetLength(0);

            return promedio;
        }

        string[,] Interfacepromedios.suma_general_por_alumno(string[,] matrices)
        {
            string[,] datos = new string[matrices.GetLength(0), 2];
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                datos[i, 0] = matrices[i, 1];
                int suma = Convert.ToInt16(matrices[i, 2]) + Convert.ToInt16(matrices[i, 3]) + Convert.ToInt16(matrices[i, 4]);
                datos[i, 1] = Convert.ToString(suma);
            }
            return datos;
        }

        internal int promedios_cada_parcial(string[,] matrices,  int columna_parcial)
        {
            
            int acumulador = 0;
            for (int i = 0; i < matrices.GetLength(0); i++)
            {
                acumulador = acumulador + Convert.ToInt32(matrices[i, columna_parcial]);
            }

            int promedio = acumulador / matrices.GetLength(0);

            return promedio;
        }

        internal int promedio_secciones(string[,] matrices, int v, string seccion)
        {
            throw new NotImplementedException();
        }

        internal int promedio_cada_parcial(string[,] matrices, int v)
        {
            throw new NotImplementedException();
        }

        internal string[,] Clasificar_Alumnos(string[,] matrices, string seccion)
        {
            throw new NotImplementedException();
        }

        internal string[,] suma_general_por_alumno(string[,] matrices)
        {
            throw new NotImplementedException();
        }

        public int promedios_cada_parcial(string[,] matrices, int columna_parcial, string secciones)
        {
            throw new NotImplementedException();
        }
    }
}
