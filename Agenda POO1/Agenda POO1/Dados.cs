using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

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
        public int salvarxml()
        {
            TextWriter meuwriter = new StreamWriter(@"C:\Temp\ArquivoAlunos.xml"); // toda vez que tiver um endereçamento de arquivo, o @ quer dizer que não tem caracter de controle;
            Alunos[] listaalunovetor = (Alunos[])cadastro.ToArray(typeof(Alunos)); // Falo o tipo de objeto do Array e o que vou encontrar neste Array;
            XmlSerializer serializacao = new XmlSerializer(listaalunovetor.GetType()); // instânciando a serialização do xml;
            serializacao.Serialize(meuwriter, listaalunovetor);
            meuwriter.Close(); // fecha o arquivo (IPC)
            return cadastro.Count; // .Count conta o número de registros.
        }
        public int abrirxml ()
        {
            int reg;
            FileStream Arquivo = new FileStream(@"C:\Temp\ArquivoAlunos.xml", FileMode.Open);
            Alunos[] listaalunovetor = (Alunos[])cadastro.ToArray(typeof(Alunos));
            XmlSerializer serializacao = new XmlSerializer(listaalunovetor.GetType());
            listaalunovetor = (Alunos[])serializacao.Deserialize(Arquivo);
            Arquivo.Close();
            cadastro.Clear();
            cadastro.AddRange(listaalunovetor);
            reg = cadastro.Count;
            return reg;
        }
    }
}






