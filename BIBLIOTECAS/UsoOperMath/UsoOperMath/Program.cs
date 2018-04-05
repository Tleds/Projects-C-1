using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OperMath;
using System.Threading.Tasks;

namespace UsoOperMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = BibMath.CriaVetor(10, true);
            int soma, maior, menor;
            soma = BibMath.somavetor(vetor);
            maior = BibMath.achamaior(vetor);
            menor = BibMath.achamenor(vetor);
            Console.WriteLine("Soma = {0,3}", soma);
            Console.WriteLine("Maior = {0,3}", maior);
            Console.WriteLine("Menor = {0,3}", menor);
            Console.ReadKey();
        }
    }
}
