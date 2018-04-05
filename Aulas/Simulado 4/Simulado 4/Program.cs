using System;

namespace Simulado_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            ContaMov minhaconta;
            do
            {
                minhaconta = new ContaMov();
                Console.WriteLine("1-Saque\n2-Saldo\n3-Depósito\n\tPressione ESC para sair");
                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        minhaconta.sacar();
                        break;
                    case 2:
                        minhaconta.saldo();
                        break;
                    case 3:
                        minhaconta.depositar();
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

    }
}
