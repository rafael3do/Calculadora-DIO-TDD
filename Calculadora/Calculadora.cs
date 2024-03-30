using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraDIO
{
    public class Calculadora
    {
        private List<string> historico = new List<string>();

        public int Soma(int a, int b)
        {
            int resultado = a + b;
            AdicionarAoHistorico($"{a} + {b} = {resultado}");
            return resultado;
        }

        public int Subtracao(int a, int b)
        {
            var resultado = a - b;
            AdicionarAoHistorico($"{a} - {b} = {resultado}");
            return resultado;
        }

        public int Multiplicacao(int a, int b)
        {
            var resultado = a * b;
            AdicionarAoHistorico($"{a} * {b} = {resultado}");
            return resultado;
        }

        public int Divisao(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Divisão por zero não é permitida.");
            }
            var resultado = a / b;
            AdicionarAoHistorico($"{a} / {b} = {resultado}");
            return resultado;
        }

        public List<string> Historico()
        {
            return historico.TakeLast(3).ToList();
        }

        private void AdicionarAoHistorico(string operacao)
        {
            historico.Add(operacao);
        }
    }
}
