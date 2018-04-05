using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Random x = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat[i, j] = x.Next(1, 100);
                }
            }
            Console.Write(" O vetor resultante é: {0,3}", vetor(mat));
        }
        public static int vetor (int [,] mat)
        {
            int[] vet = new int[6];
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; i++)
                {
                    if (i != j)
                    {
                        vet[count] = mat[i, j];
                        count++;
                    }
                }
            }
            return vet [];
        }
    }
}
