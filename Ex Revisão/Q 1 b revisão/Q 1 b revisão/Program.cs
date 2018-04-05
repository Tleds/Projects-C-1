using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_b_revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double somatorio = 100;
            Console.Write("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                somatorio *= i;
            }
            Console.Write("O somatório é : {0}", somatorio);
            Console.ReadKey();
        }
    }
}
