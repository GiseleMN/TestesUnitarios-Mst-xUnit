using System;
using CalculadoraIMC;

namespace TestexUnitCalculadora
{
	public class ClassificarIMC
	{
        [Fact]
        public void ClassificartestImc_RetornaResultado()
        {
            //Arrange
            double imc = 28;

            //Act
            var resultado = Calculadora.ClassificarIMC(imc);

            //Assert
            Assert.Equal("SobrePeso", resultado);
        }

        [Theory]
        [InlineData(28, "SobrePeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarImc_RetornaResultado(double imc, string resultadoEsperado)
        {
            //Act
            var resultado = Calculadora.ClassificarIMC(imc);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}

