using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo_4
{
    class filme
    {
        private string _nomefilme;

        public string nomefilme
        {
            get { return _nomefilme; }
            set { _nomefilme = value; }
        }
        private string _categoriafilmes;

        public  string categoria
        {
            get { return _categoriafilmes; }
            set { _categoriafilmes = value; }
        }
        private string _diretor;

        public  string diretor
        {
            get { return _diretor; }
            set { _diretor = value; }
        }

        public filme lerfilme()
        {
            filme meufilme = new filme();
            Console.Clear();
            Console.Write("Nome do filme: ");
            meufilme._nomefilme = (Console.ReadLine());
            Console.Write("Categoria: ");
            meufilme._categoriafilmes = (Console.ReadLine());
            Console.Write("Diretor: ");
            meufilme._diretor =(Console.ReadLine());
            return meufilme;
        }

    }
    class cadastro
    {
        private ArrayList cad = new ArrayList();
        public void salvar(filme x)
        {
            cad.Add(x);
        }
        public void listar()
        {
            Console.Clear();
            foreach(filme x in cad)
            {
                Console.WriteLine("{0} - {1} - Diretor {2}", x.nomefilme, x.categoria, x.diretor);
            }
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cadastro meucadastro = new cadastro();
            filme meufilme = new filme();
            for (int i = 0; i < 3; i++)
            {
                meucadastro.salvar(meufilme.lerfilme());
            }
            meucadastro.listar();
            Console.ReadKey();
        }
    }
}
