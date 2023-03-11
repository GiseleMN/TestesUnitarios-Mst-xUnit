using System;
using CalculadoraIMC;

namespace TesteMstCalculadora
{
    [TestClass]
	public class CalcularIMC
	{		
            [TestMethod]
            public void CalcularImcTest()
            {
                //Arrange - Preparação
                double peso = 110;
                double altura = 1.79;

                //Act -Ação
                var resultadoImc = Calculadora.CalcularIMC(peso, altura);

                //Assert - 
                Assert.AreEqual(34, 33, resultadoImc);
            }
     }
 }
	
