using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_poo_4._2
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            numero meunum = new numero();
            Console.WriteLine("Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (meunum.testapalindromo(n))
                Console.WriteLine("Esse número é Palíndromo.");
            else
                Console.WriteLine("Esse número não é Palíndromo");
            Console.ReadKey();

        }
    }
}
