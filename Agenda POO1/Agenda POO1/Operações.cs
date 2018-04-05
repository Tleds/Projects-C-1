using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_POO
{
    class Operações
    {
        Dados meusdados;
        public Operações() // construtor
        {
            meusdados = new Dados();
        }
        public void inserir()
        {
            Alunos meualuno;
            do
            {
                meualuno = new Alunos();
                Console.Clear();
                Console.WriteLine("Cadastramento de Alunos");
                Console.WriteLine("_______________________");
                meualuno.codigo = geracodigo();
                Console.WriteLine("Código do aluno: {0}", meualuno.codigo);
                Console.Write("Nome...........: ");
                meualuno.nome = Console.ReadLine();
                Console.Write("Telefone.......: ");
                meualuno.telefone = Console.ReadLine();
                Console.Write("Email..........: ");
                meualuno.mail = Console.ReadLine();
                Console.WriteLine("Inserir outro registro? (Aperte ESC para cancelar...)");
                meusdados.inseriraluno(meualuno);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        private string geracodigo()// Conhecimento extra currícular
        {
            string result = "";
            DateTime x = new DateTime();// instânciando a data e hora

            x = DateTime.Now; // data e hora de agora PEGAR PARA A BIBLIOTECA;
            result += x.Date.ToString().Substring(0, 2);
            result += x.Date.ToString().Substring(3, 2);
            result += x.Date.ToString().Substring(8, 2);
            result += x.Second.ToString() + x.Minute.ToString() + x.Hour.ToString();
            return result;
        }
        public void listar()
        {
            ArrayList Lista = meusdados.listaraluno();
            Console.Clear();
            Console.WriteLine("Listagem Geral do Cadastro de Alunos");
            Console.WriteLine("_____________________________________");
            foreach (Alunos x in Lista)
            {
                Console.WriteLine("Nome do aluno: {0} ({1})", x.nome, x.codigo);
                Console.WriteLine("Telefone.....: {0} ", x.telefone);
                Console.WriteLine("Email........: {0} \n", x.mail);
            }
            Console.ReadKey();
        }
        public void pesquisar()
        {
            Alunos meualuno;
            string codpesq;
            Console.Clear();
            Console.Write("Pesquisa no cadastro de alunos.");
            Console.Write("-------------------------------\n");
            Console.Write("Código do aluno:");
            codpesq = Console.ReadLine();
            meualuno = meusdados.pesquisaraluno(codpesq);
            if (meualuno != null)
            {

                Console.WriteLine("\n Nome do aluno:{0} \n Telefone: {0} \n Email: {0} ", meualuno.nome, meualuno.telefone, meualuno.mail);
            }
            else
            {
                Console.WriteLine("Aluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void alterar()
        {
            Alunos meualuno;
            Alunos meualunoalt;
            string codpesq;
            Console.Clear();
            Console.Write("Alteração de dados de alunos no cadastro.");
            Console.Write("_________________________________________\n");
            Console.Write("Código do aluno:");
            codpesq = Console.ReadLine();
            meualuno = meusdados.pesquisaraluno(codpesq);
            if (meualuno != null)
            {

                Console.WriteLine("\n Nome do aluno:{0} \n Telefone: {0} \n Email: {0} ", meualuno.nome, meualuno.telefone, meualuno.mail);
                Console.WriteLine("\n Dados de atualização: \n ");
                meualunoalt = new Alunos();
                meualunoalt.codigo = meualuno.codigo;
                Console.Write("Nome...........: ");
                meualunoalt.nome = Console.ReadLine();
                Console.Write("Telefone.......: ");
                meualunoalt.telefone = Console.ReadLine();
                Console.Write("Email..........: ");
                meualunoalt.mail = Console.ReadLine();
                meusdados.alteraraluno(meualuno, meualunoalt);
                Console.WriteLine("Dados atualizados com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void excluir()
        {
            Alunos meualuno;
            string codpesq;
            Console.Clear();
            Console.Write("Exclusão de alunos no cadastro.");
            Console.Write("_________________________________________\n");
            Console.Write("Código do aluno:");
            codpesq = Console.ReadLine();
            meualuno = meusdados.pesquisaraluno(codpesq);
            if (meualuno != null)
            {
                int certeza;
                Console.WriteLine("Excluir aluno? \n 1-Sim\t\t2-Não");
                certeza = Convert.ToInt16(Console.ReadLine());
                if (certeza == 1)
                {
                    meusdados.excluiraluno(meualuno);
                    Console.WriteLine("\n Aluno excluído do cadastro");
                }
            }
            else
            {
                Console.WriteLine("Aluno não encontrado no cadastro!");
            }
            Console.ReadKey();
        }
        public void ordenar()
        {
            int registros;
            Console.Clear();
            Console.WriteLine("Ordenação de Registros do Cadastro ");
            Console.WriteLine("___________________________________");
            registros = meusdados.ordenaralunos();
            Console.WriteLine("Total de Registros: {0} ", registros);
            Console.ReadKey();
        }
        public void salvar ()
        {
            int registros;
            Console.Clear();
            Console.WriteLine("Salvar Registros de Dados em Arquivo ");
            Console.WriteLine("____________________________________\n");
            registros = meusdados.salvarxml();
            Console.WriteLine("Arquivo XML gerado com sucesso!");
            Console.WriteLine("Total de Registros: {0} ", registros);
            Console.ReadKey();
        }
        public void abrir ()
        {
            int registros;
            Console.Clear();
            Console.WriteLine("Carregar Registros de Dados do Arquivo ");
            Console.WriteLine("_____________________________________\n");
            registros = meusdados.abrirxml();
            Console.WriteLine("Arquivo XML carregado com sucesso!");
            Console.WriteLine("Total de Registros: {0} ", registros);
            Console.ReadKey();
        }
    }
}
