using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunos = new string[4];
            int[,] Notas = new int[4, 3];
            int soma;
            double media;
            for (int i = 0; i<4; i++)
            {
                Console.Write("\n Nome do aluno {0}:", i + 1);
                alunos[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("   => Nota:  {0}", j + 1);
                    Notas[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();

            for (int i = 0; i < 4; i++)
            {
                soma = 0;
                for(int j = 0; j < 3; j++)
                {
                    soma += Notas[i, j];
                }
                Console.Write("{0} - Nota {1}", alunos[i], soma);
            }
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                soma = 0;
                for (int j = 0; j < 4; j++)
                {
                    soma += Notas[j, i];
                }
                media = (double)soma / 4;
                Console.WriteLine("\n Média da prova {0} = {1:F2}", i + 1, media);
            }


            Console.ReadKey();
        }
    }
}
