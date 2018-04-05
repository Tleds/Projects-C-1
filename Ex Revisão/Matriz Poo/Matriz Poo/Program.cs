using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            Random x = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = x.Next(1, 100);
                }
            }
            analizarmatriz(matriz);
            mostrarmatriz(matriz);
            Console.ReadKey();
        }
        static void analizarmatriz(int [,] matriz)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                        matriz[i, j] = 0;
                }
            }
        }
        static void mostrarmatriz(int [,] matriz)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", matriz[i, j]);
                }
            }
        }
    }
}
