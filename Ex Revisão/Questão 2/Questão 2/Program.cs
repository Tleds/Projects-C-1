using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, z = 0;
            double[] altura = new double[15];
            double media = 0, y = 0;
            string [] sexo = new string [15];
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite a altura: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite o sexo: ");
                sexo[i] = (Console.ReadLine());
                if ((sexo[i] == "m")||(sexo[i] == "M"))
                {
                    x++;
                }
                Console.Clear();
            }
            Console.WriteLine("O número de homens cadastrados são: {0}", x);
            for (int i = 0; i < 15; i++)
            {
                if ((sexo [i] == "f")||(sexo[i] == "F"))
                {
                    z++;
                    media += altura[i];
                    media = media / z;
                }
            }
            Console.Write("A média da altura das mulheres é: {0}", media);
            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    if (altura[j] < altura[j + 1])
                        y = altura[j];
                    altura[j] = altura[j + 1];
                    altura[j + 1] = y;
                }
            }
            Console.WriteLine("A maior altura é:{0} ", altura[1]);
            Console.WriteLine("A menor altura é:{0} ", altura[14]);
            Console.ReadKey();
        }
    }
}
