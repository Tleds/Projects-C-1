using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_aula_2
{
    class Program
    {
        struct complexo
        {
            public int PReal;
            public int PImag;
        }
        static void Main(string[] args)
        {
            complexo N1, N2;
            complexo soma, sub;
            Console.WriteLine("1º Número Real:");
            N1.PReal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1º Número Imaginário: ");
            N2.PReal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º Número Real:");
            N1.PImag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2º Número Imaginário: ");
            N2.PImag = Convert.ToInt32(Console.ReadLine());

            soma = calcsoma(N1, N2);
            sub = calcsub(N1, N2);
            Console.Clear();
            Console.WriteLine("Soma: \n");
            mostra(soma);
            Console.WriteLine("Subtração: ");
            mostra(sub);
            Console.ReadKey();

        }
        static complexo calcsub (complexo n1, complexo n2)
            {
            complexo resultado;
            resultado.PReal = n1.PReal - n2.PReal;
            resultado.PImag = n1.PImag - n2.PReal;
            return resultado;
        }
        static void mostra(complexo x)
        {
            Console.WriteLine("{0} \t", x.PReal);
            if (x.PImag >= 0)
                Console.Write("+");
            Console.WriteLine(x.PImag + "i\n");
        }
        static complexo calcsoma(complexo n1, complexo n2)
        {
            complexo resultado;
            resultado.PReal = n1.PReal + n2.PReal;
            resultado.PImag = n1.PImag + n2.PReal;
            return resultado;

        }
    }
}
