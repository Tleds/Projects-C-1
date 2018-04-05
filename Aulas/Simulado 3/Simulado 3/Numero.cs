using System;
using System.Collections.Generic;
using System.Text;

namespace Simulado_3
{
    class Numero
    {
    public int num1 { get; set; }
    public int num2 { get; set; }
    public Numero(int x, int y)
    {
        num1 = x;
        num2 = y;
    }
    public void Operacoes()
    {
        int soma, mul, div, sub;
        soma = num1 + num2;
        mul = num1 * num2;
        string ind;
        if (num2 != 0)
        {
            div = num1 / num2;
            ind = Convert.ToString(div);
        }
        else
        {
            ind = "Não é possível efetuar a Divisão";
        }
        sub = num1 - num2;
        Console.WriteLine("Soma = {0}\nMultiplicação = {1}\n Divisão = {2}\n Subtração = {3}", soma, mul, ind, sub);
        Console.ReadKey();
    }
}
}
