using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_POO
{
    public class Alunos
    {
        private string _codigo;

        public string codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private string _telefone;

        public string telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }
        private string _mail;

        public  string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public Alunos() //Construtor
        {
            _codigo = "";
            _nome = "";
            _telefone = "";
            _mail = "";
        }


    }
}
