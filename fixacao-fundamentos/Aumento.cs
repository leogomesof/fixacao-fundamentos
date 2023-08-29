using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixacao_fundamentos
{
    public static class Aumento
    {
        public static double Calculo()
        {
            Console.Write("Digite um valor para Salário: R$");
            string salario = Console.ReadLine();
            double valorSalario = double.Parse(salario);

            Console.Write("Digite a porcentagem do Aumento: ");
            string aumento = Console.ReadLine();
            double valorAumento = double.Parse(aumento);

            double porcentagem = valorAumento / 100;
            double reajuste = valorSalario * porcentagem;
            double valorFinal = valorSalario + reajuste;
            return valorFinal;
        }
    }
}
