using System;
using System.Collections;

namespace Simulado
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1 a - Contato X = new Contato(); = Criando o objeto X e instânciando
             * b - public string Nome
             * {
             * get{return _Nome;}  = Encapsulando o método;
             * set{_Nome = value;}
             * }
             * c - protected string Nome = método protegido o que significa que ele só pode ser acessado pela
             *                             classe que vai herdar dessa.
             * d - class Circulo = Fazendo uma sobrecarga no construtor
             * {
             * private double _ Raio {get; set;}  = Encapsulando o método _Raio
             * public Circulo()  =  Construtor da classe Circulo sem parâmetro
             * {
             * _Raio = 0; 
             * }
             * public Circulo (double RaioInicial) = Construtor da classe Circulo com parâmetro;
             * {
             * _Raio = Raioinicial; = _Raio pega o valor do parâmetro
             * }
             * e - public sealed class A = classe sealed(selada) não permite a herança
             * 2-
              */
            int opcao;
            do
            {
                Console.WriteLine("O que deseja fazer ? \n 1 - Cadastrar Veículos\n 2 - Consultar Veículos \n Aperte ESC para sair...");
                opcao = Convert.ToInt16(Console.ReadLine());
                veiculo meuveiculo = new veiculo();
                Dados meusdados = new Dados();
                switch (opcao)
                {
                    case 1:
                        meuveiculo.cadastrar();
                        break;
                    case 2:
                        string x, y;
                        Console.WriteLine("Digite as letras da Placa: ");
                        x = Console.ReadLine();
                        Console.WriteLine("Digite os números da Placa: ");
                        y = Console.ReadLine();
                        meusdados.consultar(y, x);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
        
      
    }
    class Dados
    {
        public ArrayList cad;
        public void cadast(veiculo x)
        {
            cad = new ArrayList();
            cad.Add(x);
        }
        public void consultar(string numero, string letra)
        {
            foreach (veiculo x in cad)
            {
                if (numero == x.conjunto.numeros && letra == x.conjunto.letra)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", x.nome, x.fabricante, x.ano, x.conjunto);
                    break;
                }

            }
        }
    }
    struct veiculo
    {
        public string fabricante;
        public string nome;
        public string ano;
        public Placa conjunto;
        public void cadastrar()
        {
            veiculo meuveiculo;
            Dados y = new Dados();
            do
            {
                meuveiculo = new veiculo();
                meuveiculo.conjunto = new Placa();
                Console.WriteLine("Nome:");
                meuveiculo.nome = Console.ReadLine();
                Console.WriteLine("Fabricante:");
                meuveiculo.fabricante = Console.ReadLine();
                Console.WriteLine("Ano:");
                meuveiculo.ano = Console.ReadLine();
                Console.WriteLine("Letras da Placa:");
                meuveiculo.conjunto.letra = Console.ReadLine();
                Console.WriteLine("Números da Placa: ");
                meuveiculo.conjunto.numeros = Console.ReadLine();
                y.cadast(meuveiculo);
                Console.Write("Pressione ESC para sair...");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
    struct Placa
    {
        public string letra;
        public string numeros;
    }
}
