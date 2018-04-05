using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Agenda_POO
{
    class Dados
    {
        private ArrayList cadastro;
        public Dados()
        {
            cadastro = new ArrayList();
        }
        public void inseriraluno(Alunos x)
        {
            cadastro.Add(x);
        }
        public ArrayList listaraluno()
        {
            return cadastro;
        }
        public Alunos pesquisaraluno(string codpesq)
        {
            foreach (Alunos x in cadastro)
            {
                if (x.codigo == codpesq)
                    return x;
            }
            return null;
        }
        public void alteraraluno(Alunos x, Alunos y)
        {
            int posicao;
            posicao = cadastro.IndexOf(x); // IndexOf() fala a posição que o objeto esta no array list;
            cadastro.Remove(x);
            cadastro.Insert(posicao, y); // insere na mesma posição que o objeto foi retirado;
        }
        public void excluiraluno(Alunos x)
        {
            cadastro.Remove(x); // Método para remover um objeto do ArrayList;
        }
        public int ordenaralunos()
        {
            cadastro.Sort(new minhaordenacao());
            return cadastro.Count;
        }
        public class minhaordenacao : IComparer // ordena os registros.
        {
            int IComparer.Compare(object x, object y)
            {
                return ((Alunos)x).nome.CompareTo(((Alunos)y).nome);
            }
        }
    }
}

        

    


