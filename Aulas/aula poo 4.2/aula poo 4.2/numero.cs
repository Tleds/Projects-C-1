using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_poo_4._2
{
    class numero
    {
        public bool testapalindromo(int num)
        {
            int p1, p2, p3, p4;
            int resto;
            p1 = num / 1000;
            resto = num % 10;
            p2 = resto / 100;
            resto = resto % 10;
            p3 = resto / 10;
            resto = resto % 10;
            p4 = resto;
            if ((p1 == p4) && (p2 == p3))
                return true;
            else
                return false;
        }

    }
}
