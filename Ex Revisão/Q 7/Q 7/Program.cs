using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.80, b = 1.30;
            int ano =0;
            do
            {
                a += 0.12;
                b += 0.08;
                ano++;
            } while (a < b);
            Console.Write("A árvore A passou a altura da árvore B em: {0,3} anos.", ano);
            Console.ReadKey();
        }
       
    }
}
