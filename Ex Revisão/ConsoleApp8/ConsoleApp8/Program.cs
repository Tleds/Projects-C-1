using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vint = { 1, 2, 3, 4, 5, 6, 7 };
            double[] vdouble = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            char[] vchar = { 'P', 'U', 'C', 'M', 'G' };
            mostravetor(vint);
            mostravetor(vdouble);
            mostravetor(vchar);
        }
        /// <summary>
        /// Mostra o conteúdo de um Vetor de inteiros
        /// </summary>
        /// <param name="v">Vetor de inteiros</param>
        static void mostravetor(int[] v)
        {
            Console.Clear();
            foreach(int x in v)
            {
                Console.Write("{0,5}", x);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Mostra o conteúdo de um vetor double
        /// </summary>
        /// <param name="v">Vetor double</param>
        static void mostravetor(double[] v)
        {
            Console.Clear();
            foreach (int x in v)
            {
                Console.Write("{0,5}", x);
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Mostra o conteúdo de um Vetor de char
        /// </summary>
        /// <param name="v">Vetor de Char</param>
        static void mostravetor(char[] v)
        {
            Console.Clear();
            foreach (int x in v)
            {
                Console.Write("{0,5}", x);
                Console.ReadKey();
            }
        }
    }
}
