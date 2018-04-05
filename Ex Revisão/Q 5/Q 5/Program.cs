using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int [3, 3];
            int[,] mat2 = new int [3, 3];
            int[,] mat3 = new int[3, 3];
            int[,] mat4 = new int[3, 3];
            Random x = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat1[i, j] = x.Next(1, 100);
                    mat2[i, j] = x.Next(1, 100);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat3 [i,j] = mat1[i, j] + mat2[i, j];
                    mat4[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            Console.WriteLine("A soma das matrizes resulta na seguinte matriz: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}  ",mat3[i, j]);
                }
            }
            Console.WriteLine("\nA diferença das matrizes resulta na seguinte matriz: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,5}  ", mat4[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
