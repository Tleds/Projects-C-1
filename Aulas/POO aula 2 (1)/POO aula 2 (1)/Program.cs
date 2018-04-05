using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace POO_aula_2__1_
{
    class Program
    {
        class alunos
        {
            public string nome;
            public string telefone;
            public string mail;
            public data aniversario;
        }
        class data
        {
            public int dia;
            public string mes;
        }
        static void Main(string[] args)
        {
            alunos meualuno;
            data aniversario;
            ArrayList cad = new ArrayList();
            do
            {
                meualuno = new alunos();
                meualuno.aniversario = new data();
                Console.Clear();
                Console.Write("Nome: ");
                meualuno.nome = Console.ReadLine();
                Console.Write("Telefone: ");
                meualuno.telefone = Console.ReadLine();
                Console.Write("Mail: ");
                meualuno.mail = Console.ReadLine();
                Console.Write("Dia de nascimento: ");
                meualuno.aniversario.dia=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Mês de nascimento: ");
                meualuno.aniversario.mes = Console.ReadLine();


                cad.Add(meualuno);
                Console.Write("\n\t\t Deseja cadastrar outro aluno ?");


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Clear();
            foreach(alunos x in cad)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", x.nome, x.telefone, x.mail, x.aniversario.dia, x.aniversario.mes);
                Thread.Sleep(500);

            }
            Console.ReadKey();
        }
    }
}
