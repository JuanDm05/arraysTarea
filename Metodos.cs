using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysTarea
{
    internal class Metodos
    {
        public void Matriz()
        {
            int[,] t = new int[2, 3];

            int filas = t.GetLength(0);
            Console.WriteLine("El arreglo t tiene " + filas + " filas");
            int columnas = t.GetLength(1);
            Console.WriteLine("El arreglo t tiene "+ columnas + "columnas");
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.WriteLine($"Los elementos del arreglo en t[{i},{j}] es " + t[i,j]);
                }
            }
            for (int j = 0; j < t.GetLength(0); j++)
            {
                int elemento = t[0, j];
                Console.WriteLine("Elemento en la fila  " + j + ": " + elemento);
            }
            for(int i = 0;i < t.GetLength(1); i++)
            {

                int elemento = t[0, i];
                Console.WriteLine("Elemento en la columna 2  " + i + ": " + elemento);
            }

            t[0, 0] = 1;
            t[0, 1] = 2;
            t[0, 2] = 3;
            t[1, 0] = 4;
            t[1, 1] = 5;
            t[1, 2] = 6;

            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    t[i, j] = 0;
                }
            }
            for (int i = 0; i < t.GetLength(0); i++)
            {
                for (int j = 0; j < t.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese valores en la fila y columna [{i+1},{j+1}]");
                    t[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }
            int minimoT = t[0, 0];
            for (int i = 0;i < t.GetLength(0); i++)
            {
                for(int j = 0;j < t.GetLength(1); j++)
                {
                    if (t[i,j]< minimoT)
                    {
                        minimoT = t[i,j];
                    }
                }
            }
            Console.WriteLine("El valor minimo de t es "+ minimoT);

            Console.WriteLine("Elementos de la primera fila de t");
            Console.WriteLine(t[0,0]+" "+t[0,1]+" "+t[0,2]);
            int sumaDe3Column = t[0, 2] + t[1, 2];
            Console.WriteLine($"Ttotalizar los elementos de la tercera columna de t {sumaDe3Column}");

            Console.Write("\t");
            for (int j = 0; j < t.GetLength(1); j++)
            {
                Console.Write("Columna " + j + "\t ");
            }
            Console.WriteLine();

            for (int j = 0; j < t.GetLength(0); j++)
            {
                Console.Write("Fila " + j + ":\t");
                for (int k = 0; k < t.GetLength(1); k++)
                {
                    Console.Write(t[j, k] + "\t\t");
                }

                Console.WriteLine();
            }
        }
        
    }
}
