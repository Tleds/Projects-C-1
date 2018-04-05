using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            Random x = new Random();
            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = x.Next(1, 100);
            }
            mul3(vet);
        }
        public static void mul3(int [] vet)
        {
            int count = 0;
            int[] vet1 = new int[10];
            for (int i = 0; i < vet.Length; i++)
            {
                if ((vet[i]%3 == 0)&&(vet[i] != 0))
                {
                    vet1[count] = vet[i];
                    count++;
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0,3}", vet1[i]); 
            }
            Console.WriteLine(" \n Estes são os elementos que são múltiplos de 3 que totalizaram {0,3} elementos", count);
            Console.ReadKey();
        }
    }
}
