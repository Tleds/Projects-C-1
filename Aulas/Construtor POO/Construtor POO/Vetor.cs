using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor_POO
{
    class Vetor
    {
        private int[] V;
        public Vetor()
        {
            int tam;
            Console.Write("Tamanho do vetor: ");
            tam = int.Parse(Console.ReadLine());
            V = new int[tam];
        }
        public Vetor(int tam)
        {
            V = new int[tam];
        }
        public void geravetor()
        {
            Random x = new Random();
            for (int i = 0; i < V.Length; i++)
            {
                V[i] = x.Next(1, 100);
            }
        }
        public void mostravetor()
        {
            for (int i = 0; i < V.Length; i++)
            {
                Console.Write("{0,6}", V[i]);
            }
            Console.ReadKey();
        }

    }
}
