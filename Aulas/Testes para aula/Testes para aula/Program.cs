using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_para_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vetor = new int[10];
            int[] VetorPares = new int[10];
            int[] VetorImpar = new int[10];
            Random x = new Random();
            int QtdePares = 0;
            int QtdeImpares = 0;
            for (int i = 0; i < 10; i++)
            {
                Vetor[i] = x.Next(1, 100);
                if (Vetor[i] % 2 == 0)
                {
                    VetorPares[QtdePares] = Vetor[i];
                    QtdePares++;
                }
                else
                {
                    VetorImpar[QtdePares] = Vetor[i];
                    QtdeImpares++;
                }
            }
            Console.WriteLine("Pares: {0}", QtdePares);
            for (int i = 0; i < QtdePares; i++)
            {
                Console.WriteLine("\t {1}", VetorPares[i]);
            }
            Console.WriteLine("Impares: {0}", QtdeImpares);
            for (int i = 0; i < QtdeImpares; i++)
            {
                Console.WriteLine("{1}", VetorImpar[1]);
            }

            Console.ReadKey();
        }
    }
}
