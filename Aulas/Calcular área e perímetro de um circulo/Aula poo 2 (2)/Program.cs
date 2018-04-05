using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo_2__2_
{
    class circulo
    {
        private double _raio;
        public double raio 
        {
            get { return _raio; }
            set { _raio = value; }
        }

        private double _per;
            public double per
        {
            get { return _per; }
        }
        private double _area;

        public double areaeq
        {
            get { return _area; }
        }
        public void calc ()  
        {
            _area = Math.PI * Math.Pow(_raio, 2);
            _per = 2 * Math.PI * _raio;
            Console.Write("Área: {0} \nPerímetro: {1}", _area, _per);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            circulo meucirculo = new circulo();
            Console.Write("Raio do Circulo: ");
            meucirculo.raio = Convert.ToDouble(Console.ReadLine());
            meucirculo.calc();
            Console.ReadKey();
        }
    }
}


