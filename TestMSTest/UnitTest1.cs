global using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto_teste_operacoes;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {

            // Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            // Act - Ação
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(5, 10, 15)]
        [DataRow(20, 2, 22)]
        [DataRow(2, 3, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            // Act - Ação
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert - Verificação
            Assert.AreEqual(rNum, resultado);
        }
       
    }
}