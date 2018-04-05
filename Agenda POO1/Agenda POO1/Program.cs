using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agenda_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Operações minhasoperacoes = new Operações();
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Cadastro de Alunos ");
                Console.WriteLine("______________________________");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("5 - Listar");
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Salvar dados em Arquivo");
                Console.WriteLine("8 - Carregar Dados do Arquivo");
                Console.WriteLine("9 - Sair");

                Console.Write("\nOpção: ");
                opcao = Convert.ToInt16(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        minhasoperacoes.inserir();
                        break;
                    case 2:
                        minhasoperacoes.alterar();
                        break;
                    case 3:
                        minhasoperacoes.excluir();
                        break;
                    case 4:
                        minhasoperacoes.pesquisar();
                        break;
                    case 5:
                        minhasoperacoes.listar();
                        break;
                    case 6:
                        minhasoperacoes.ordenar();
                        break;
                    case 7:
                        minhasoperacoes.salvar();// XML - Xtended Markup Language.
                        break;
                    case 8:
                        minhasoperacoes.abrir();
                        break;
                    case 9:
                        //Sair
                        Console.Write("Saindo do sistema...");
                        Thread.Sleep(5000);
                        break;
                    default:
                        Console.Write("\nOpção inválida!");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcao != 9);
        }
    }
}
