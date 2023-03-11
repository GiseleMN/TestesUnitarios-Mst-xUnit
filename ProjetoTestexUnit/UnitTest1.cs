using ProjetoTeste;

namespace ProjetoTestexUnit;

public class UnitTest1
{
    [Fact]
    public void SomarDoisNumeros()
    {
        //Arrange - Preparação
        double x = 1;
        double y = 1;
        double R = 2;

        //Act - Ação
        var resultado = Operacoes.Somar(x, y);

        //Assert
        Assert.Equal(R, resultado);
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(2,2,4)]
    [InlineData(2,1,2)]
    public void SomarDoisNumerosLista(double x, double y, double R)
    {
        //Act - Ação
        var resultado = Operacoes.Somar(x, y);

        //Assert
        Assert.Equal(R, resultado);
    }
}
