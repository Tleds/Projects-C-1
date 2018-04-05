using System;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
namespace LinqCTG
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement raiz = XElement.Load(@"C:\Temp\ArquivoAlunos.xml");
            var consultanomes = from n in raiz.Descendants("Alunos") 
                                orderby (string)n.Element("nome")
                                select new
                                {
                                    nome = (string)n.Element("nome"),
                                    codigo = (string)n.Element("codigo")

                                };
            foreach (var x in consultanomes)
            {
                Console.WriteLine("{0} - {1}", x.nome, x.codigo);
            }
            Console.WriteLine("{0}", DateTime.Now);
            Console.ReadKey();

        }
    }
}
