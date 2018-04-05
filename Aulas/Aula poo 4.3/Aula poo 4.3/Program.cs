using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] r = new int[10];
            int[] s = new int[10];
            int[] v = new int[20];
            Random x = new Random();
            for (int i = 0; i < 10; i++)
            {
                r[i] = x.Next(1, 20);
                s[i] = x.Next(1, 20);
            }
            int pos = 0;
            bool existe = false;
            for (int i = 0; i < 10; i++) // R
            {
                existe = false;
                for (int j = 0; j < 20; j++) // V
                {
                    if (r[i] == v[j])
                    {
                        existe = true;
                        break;
                    }
                } 
                if (!existe)
                {
                    v[pos++] = r[i];
                }
            }
            for (int i = 0; i < 10; i++) // S
            {
                existe = false;
                for (int j = 0; j < 20; j++) // V
                {
                    if (s[i] == v[j])
                    {
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    v[pos++] = s[i];
                }
            }
            Console.Clear();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,5}", r[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0,5}", s[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", v[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
                
        }
    }
}
