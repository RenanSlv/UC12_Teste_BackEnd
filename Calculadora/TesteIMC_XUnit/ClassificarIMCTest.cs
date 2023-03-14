using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteIMC_XUnit
{
    public class ClassificarIMCTest
    {
        [Fact]
        public void ClassificarIMC_RetornaResultado() 
        {
            //Arrange - Preparação
            double imc = 28;

            //Act - Ação 
            var classificarResultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.Equal("Sobrepeso", classificarResultado);
        }

        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void ClassificarIMC_RetornaResultado2(double imc, string resultadoEsperado)
        {
            //Act - Ação
            var resultado = Operacoes.ClassificarIMC(imc);

            //Assert - Verificação
            Assert.Equal(resultadoEsperado, resultado);

        }
    }
}
