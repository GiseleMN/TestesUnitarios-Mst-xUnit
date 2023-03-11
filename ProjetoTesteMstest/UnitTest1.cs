using ProjetoTeste;

namespace ProjetoTesteMstest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void SomarDoisNumeros()
    {
        //Arrange - Preparação
        double x = 1;
        double y = 2;
        double R = 2;

        //Act - Ação
        var resultado = Operacoes.Somar( x , y );

        //Assert - Verficação
        Assert.AreEqual(R, resultado);
    }

    [DataTestMethod]
    [DataRow(1, 1, 2)]
    [DataRow(2,1,2)]
    [DataRow(2,2,4)]
    public void SomarDoisNumerosLista(double x, double y, double R)
    {
        // Act - Ação
        var resultado = Operacoes.Somar(x, y);

        //Assert - Verficação
        Assert.AreEqual(R, resultado);
    }
}
