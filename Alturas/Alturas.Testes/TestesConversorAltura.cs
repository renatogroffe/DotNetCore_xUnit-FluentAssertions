using System;
using Xunit;
using FluentAssertions;

namespace Alturas.Testes
{
    public class TestesConversorAltura
    {
        [Theory]
        [InlineData(1, 0.3048)]
        [InlineData(10, 3.048)]
        [InlineData(55.5555, 16.9333)]
        [InlineData(100, 30.48)]
        public void TesteConversorAltura(double pes, double metros)
        {
            double resultado = ConversorAltura.PesParaMetros(pes);
            resultado.Should().Be(metros,
                $"Altura em metros não corresponde ao valor esperado ({metros})");
        }
    }
}