using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double somatorio = 1, x;
            Console.Write("Digite um número inteiro: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (double i = 1.00; i <= n; i++)
            {
                x = i / (i + 1);
                somatorio = x * somatorio;
            }
            Console.Write("O resultado é: {0} ", somatorio);
            Console.ReadKey();
        }

    }
}
