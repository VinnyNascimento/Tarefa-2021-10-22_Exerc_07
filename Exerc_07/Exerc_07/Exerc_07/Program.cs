using System;

namespace Exerc_07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Faça a cotação do dólar em Reais (R$)");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o valor da cotação do dólar: ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o em dólares, para conversão em Reais (R$): ");
            s.setNum2(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("Com a cotação do dólar {0}, e o valor em dólar de: {1}, o valor em Real (R$) é de: {2}", s.getNum1(), s.getNum2(), s.getResultado());
            #endregion
        }
    }
}
