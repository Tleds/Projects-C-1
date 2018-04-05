using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            int[] a = new int[10];
            int[] b = new int[10];
            int[] c = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = x.Next(1, 100);
                b[i] = x.Next(1, 120);
            }
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = a[i] + b[i];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("{0,5}", c[i]);
            }
            Console.ReadKey();
        }
    }
}
