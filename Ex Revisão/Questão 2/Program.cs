using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double somatorio = 1;
            Console.Write("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i  <= n ; i ++)
            {
                somatorio = 100 * i;
            }
            Console.ReadKey();
        }
    }
}
