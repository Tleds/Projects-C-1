using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_de_poo_3
{
    class veiculo
    {
        private string _nome;

        public  string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _marca;

        public  string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        private double _preco;

        public double preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        public veiculo lerdados()
        {
            Console.Clear();
            veiculo meuveiculo = new veiculo();
            Console.Write("Nome do veículo: ");
            meuveiculo._nome = (Console.ReadLine());
            Console.Write("Marca: ");
            meuveiculo._marca = (Console.ReadLine());
            Console.Write("Preço ($): ");
            meuveiculo._preco = Convert.ToDouble(Console.ReadLine());
            return meuveiculo ;
        }
    }
    class cadastro
    {
        public ArrayList cadveiculo = new ArrayList();
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            cadastro meucadastro = new cadastro();
            veiculo meuveiculo = new veiculo();
            for (int i = 0; i  <= 3; i ++)
            {
                meucadastro.cadveiculo.Add(meuveiculo.lerdados());
            }
            foreach(veiculo x in meucadastro.cadveiculo)
            {
                Console.WriteLine("{0} - {1} - {2:F2}", x.nome, x.marca, x.preco);
            }
            Console.ReadKey();
        }
    }
}


