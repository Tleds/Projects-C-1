using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sexo = new char[15];
            double[] altura = new double[15];
            double[] pos = new double[1];
            double [] maior = new double [1];

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite seu sexo: ");
                sexo[i] = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Digite sua altura: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 15; i++)
            {
                if (altura[i] < altura[i + 1])
                {
                    pos[1] = altura[i];
                    altura[i] = altura[i + 1];
                    altura[i + 1] = pos[1];
                }
            }
            for (int i = 0; i < 15; i++)
            {
                Console.Write(altura[i]);
            }
            maior [1] = altura[1];
            Console.ReadKey();
        }
    }
}
