using CalculadoraDIO;
using System;
using Xunit;

namespace TestCalculadora
{
    public class CalculadoraTest
    {
        [Fact]
        public void Soma_DeveRetornarSomaCorreta()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Soma(5, 3);

            // Assert
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Subtracao_DeveRetornarSubtracaoCorreta()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Subtracao(10, 4);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void Multiplicacao_DeveRetornarMultiplicacaoCorreta()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Multiplicacao(6, 7);

            // Assert
            Assert.Equal(42, resultado);
        }

        [Fact]
        public void Divisao_DeveRetornarDivisaoCorreta()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            var resultado = calculadora.Divisao(15, 3);

            // Assert
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void Divisao_PorZero_DeveLancarExcecao()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculadora.Divisao(8, 0));
        }

        [Fact]
        public void Historico_DeveRetornarUltimasTresOperacoes()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act
            calculadora.Soma(5, 3);
            calculadora.Subtracao(10, 4);
            calculadora.Multiplicacao(6, 7);


            // Assert
            var ultimasOperacoes = calculadora.Historico();
            Assert.Equal(3, ultimasOperacoes.Count);
            Assert.Contains("5 + 3 = 8", ultimasOperacoes);
            Assert.Contains("10 - 4 = 6", ultimasOperacoes);
            Assert.Contains("6 * 7 = 42", ultimasOperacoes);
        }
    }
}
