using System;
using CalculadoraIMC;

namespace TesteMstCalculadora
{
    [TestClass]
    public class ClassificarIMC
    {
        [TestMethod]
        public void ClassificarIMC_RetornaResultado()
        {
            //Arrange -
            double imc = 28;

            //Act
            var classificarImc = Calculadora.ClassificarIMC(imc);

            //Assert
            Assert.AreEqual("SobrePeso", classificarImc);
        }
    }
}

