using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        [Trait("Categoria", "Teste")]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2, 2);

            //Assert
            Assert.Equal(4, resultado);
            resultado.Should().Be(4);

        }


        [Theory]
        [Trait("Categoria", "Teste")]
        [InlineData(1, 1, 2)]
        [InlineData(3, 2, 5)]
        [InlineData(9, 8, 17)]
        public void Calculadora_Somar_RetornarValoresSomaCorretos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, resultado);
        }

        [Fact]
        [Trait("Categoria", "Teste")]
        public void Calculadora_Somar_DeveChamarFuncaoSomarUmaVez()
        {
            //Arrange
            var calculadoraRepo = new Mock<ICalculadora>();

            var teste = new Teste(calculadoraRepo.Object);
            var v1 = 1;
            var v2 = 2;

            //Act
            teste.callSomar(v1, v2);



            calculadoraRepo.Verify(c => c.Somar(v1, v2), Times.Once);
            calculadoraRepo.Verify(c => c.Somar(It.IsAny<double>(), It.IsAny<double>()), Times.Once);
            //Assert
            //Assert.Equal(4, resultado);
        }

    }

    public class Teste
    {
        private ICalculadora calc;

        public Teste(ICalculadora lastName)
        {
            calc = lastName;
        }

        public void callSomar(double v1, double v2)
        {
            calc.Somar(v1, v2);
        }

        // Remaining implementation of Person class.
    }


}
