using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC_MSTest
{
    [TestClass]
    public class ClassificarIMCTest
    {
        [TestMethod]
        public void ClassificarIMC() 
        {
            //Arrange - Preparação
            double imc = 28;
            
            //Act - Ação
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }

        [DataTestMethod]
        [DataRow(28)]
        public void ClassificarIMCTest2(double imc)
        {
            //Act - Ação
            var classificacaoIMC = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.AreEqual("Sobrepeso", classificacaoIMC);
        }
    }


}
