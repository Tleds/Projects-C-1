using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_poo_21_02_2018
{
    class Program
    {
        class aluno
        {
            public string nome;
            public data aniversário;
            
        }
        class data
        {
            public int dia;
            public string mes;
        }
        
        static void Main(string[] args)
        {
            aluno [] meualuno = new aluno[3];
            aluno xaluno;
            for (int i = 0; i < 3; i++)
            {
                xaluno = new aluno();
                xaluno.aniversário = new data();
                Console.WriteLine("Nome: ");
                xaluno.nome = Console.ReadLine();
                Console.WriteLine("Dia de aniversário: ");
                xaluno.aniversário.dia = int.Parse(Console.ReadLine());
                Console.WriteLine("\t\t Mês: ");
                xaluno.aniversário.mes = Console.ReadLine();
                meualuno[i] = xaluno;
            }
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0} - {1}/{2}", meualuno[i].nome, meualuno[i].aniversário.dia, meualuno[i].aniversário.mes);
            }
            Console.ReadKey();

        }
        
    }
}
