using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperMath
{
    public static class BibMath
    {
        public static int[] CriaVetor(int tam, bool randomize)
        {
            int[] v = new int[tam];
            Random x = new Random();
            if (randomize)
            {
                for (int i = 0; i < tam; i++)
                {
                    v[i] = x.Next(1, 99);
                }
            }
            return v;
        }
        public static int somavetor(int [] v)
        {
            int soma = 0;
            foreach(int x in v)
            {
                soma += x;
            }
            return soma;
        }
        public static int achamaior(int [] v)
        {
            int maior = v[0];
            foreach(int x in v)
            {
                if (x > maior)
                {
                    maior = x;
                }
            }
            return maior;
        }
        public static int achamenor(int[] v)
        {
            int menor = v[0];
            foreach (int x in v)
            {
                if (x < menor)
                {
                    menor = x;
                }
            }
            return menor;
        }

    }
}
