using CalculadoraIMC;

namespace TestexUnitCalculadora;

public class CalcularIMC
{
    [Fact]
    public void CalculadoraIMC_TestRetornaResultado()
    {
        //Arrange - Preparação
        double peso = 110;
        double altura = 1.79;

        //Act -Ação
        var resultado = Calculadora.CalcularIMC (peso, altura);

        //Assert
        Assert.Equal(34.33, resultado);
    }

    [Theory]
    [InlineData(80, 1.79, 24.97)]
    [InlineData(100, 1.79, 31.21)]
    public void CalcularIMC_RetornaResultadoLista(double peso, double altura, double resultadoIMC)
    {

        //Act -Ação
        var resultadoImc = Calculadora.CalcularIMC(peso, altura);

        //Assert
        Assert.Equal(resultadoIMC, resultadoImc);
    }
}
