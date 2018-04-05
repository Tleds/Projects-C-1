using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3_revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int soma = 0;
            for (n = 1; n <= 1000; n++)
            {
                soma = 0;
                for (int div = 1; div < n; div++)
                {
                    if (n % div == 0)
                        soma += div;
                }
                if (soma == n)
                    Console.WriteLine("Número perfeitos: {0,5} ", n);
            }
            Console.ReadKey();
            
        }
    }
}
