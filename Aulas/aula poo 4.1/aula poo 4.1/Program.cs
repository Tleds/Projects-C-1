using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace aula_poo_4._1
{
    class circulo // classes seladas não permitem herança ( sealed );
    {
        public double raio { get; set; }
        public double area { get; set; } // só aparece na classe herdada (protected);
        public void calcarea()
        {
            area = Math.PI * Math.Pow(raio, 2);
        }
    }
    class cilindro:circulo // Ex: Herança, a classe cilindro herdou o atributo area da classe circulo;
    {
        public double altura { get; set; }
        public double volume { get; set; }
        public void calcvolume()
        {
            volume = area * altura;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cilindro meucilindro = new cilindro();
            meucilindro.raio = 2.5;
            meucilindro.altura = 7;
            meucilindro.calcarea();
            meucilindro.calcvolume();
            Console.WriteLine("Área da Base: {0,6:###.##}", meucilindro.area); // forma de representação, esta no sga;
            Console.WriteLine("Volume......: {0,6:###.##}", meucilindro.volume);
            Console.ReadKey();
        }
    }
}
