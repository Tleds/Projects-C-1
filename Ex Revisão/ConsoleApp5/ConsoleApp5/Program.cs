using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            
            fator(ref a);
            Console.Write("\n O fatorial é: {0}", a);
            Console.ReadKey();
        }


        static void fator(ref int x)
        {
            int fatorial, fat = 1;
            for (int i = 0; i < x; i++)
            {
                fatorial = x - i;
                fat *= fatorial;
            }
            x = fat;
        }
    }
}
