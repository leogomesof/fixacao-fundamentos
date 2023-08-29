using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace fixacao_fundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O salário final é R$: " + Aumento.Calculo());
            Console.Write("Aperte enter para sair");
            Console.Read();
        }
    }
}
