using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, R1, R2;

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            R1 = 0;
            R2 = 0;
            delta = calcdelta(a, b, c);
            if (delta < 0)
                Console.WriteLine("Não existem raízes reais");
            calcraizes(a, b, delta, ref R1, ref  R2);
            Console.WriteLine("\n Raíz 1 = {0}", R1);
            Console.WriteLine("\n Raíz 2 = {0}", R2);
            Console.ReadKey();
        }

#region "funções"
        /// <summary>
        /// Calcula o Delta de uma equação de 2º grau
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static double calcdelta (double a, double b, double c)
        {
            return Math.Pow(b, 2) - (4 * a * c);
        }
        static void calcraizes (double a, double b, double delta, ref double R1, ref double R2)
        {
            R1 = (-b + Math.Sqrt(delta) / (2 * a));
            R2 = (-b - Math.Sqrt(delta) / (2 * a));
        }
        #endregion
    }
}
