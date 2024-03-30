using System;

namespace CalculadoraDIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            // Teste das operações
            Console.WriteLine("Soma: " + calculadora.Soma(5, 3));
            Console.WriteLine("Subtração: " + calculadora.Subtracao(10, 4));
            Console.WriteLine("Multiplicação: " + calculadora.Multiplicacao(6, 7));
            try
            {
                Console.WriteLine("Divisão: " + calculadora.Divisao(15, 3));
                Console.WriteLine("Divisão por zero: " + calculadora.Divisao(8, 0)); // Isso deve lançar uma exceção
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            // Exibir histórico
            Console.WriteLine("\nÚltimas operações:");
            foreach (var operacao in calculadora.Historico())
            {
                Console.WriteLine(operacao);
            }
        }
    }
}
