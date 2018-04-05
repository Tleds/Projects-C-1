using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_4_exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, d, j;
            int m = 0;
            int k = 0;
            int l = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            do
            {
                Console.WriteLine("Digite o saldo de gols do ORLANDO CITY: ");
                string a = Console.ReadLine();
                if (int.TryParse(a, out b))
                {
                    Console.WriteLine("O número digitado é um inteiro" + b);
                }
                else
                {
                    Console.WriteLine("O número digitado não é um inteiro: ");
                }
                Console.WriteLine("Digite o número de gols do CHICAGO FIRE: ");
                string c = Console.ReadLine();
                if (int.TryParse(c, out d))
                {
                    Console.WriteLine("O número digitado é um inteiro" + d);
                }
                else
                {
                    Console.WriteLine("O número digitado não é um inteiro: ");
                }
                if (b > d)
                {
                    Console.WriteLine("ORLANDO CITY É O TIME VENCEDOR!");
                    e++;
                    g++;
                }
                if (b == d)
                {
                    Console.WriteLine("HOUVE UM EMPATE!");
                    g++;
                    h++;
                }
                else
                {
                    Console.WriteLine("CHICAGOR FIRE É O TIME VENCEDOR!");
                    f++;
                    g++;
                }
                Console.WriteLine("Novo DUELO? \n 1-Sim \n 2-Não");
                string i = Console.ReadLine();
                if (int.TryParse(i, out j))
                {
                    Console.WriteLine("O número digitado é um inteiro" + b);
                }
                else
                {
                    Console.WriteLine("O número digitado não é um inteiro: ");
                }
            } while (j == 2);
            Console.WriteLine(g + "jogo(s) \n " + e + "Vitória de ORLANDO CITY \n " + f + "Vitórias de CHICAGO FIRE \n Com " + h + "empates");
            if (e > f)
            {
                Console.WriteLine("ORLANDO CITY VENCEU O MAIOR NÚMERO DE DUELOS!");
            }
            if (e == f)
            {
                Console.WriteLine("CHICAGO FIRE VENCEU O MAIOR NÚMERO DE DUELOS!");
            }
            else
            {
                Console.WriteLine("NÃO HOUVE UM MAIOR VENCEDOR DE DUELOS");
            }

            Console.ReadKey();
        }
    }
}
