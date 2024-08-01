using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        /// <summary>
        ///  AAA : Act, Arrange, Assert
        ///  AAA : Agir , Organizar e Assertir
        /// </summary>
        [Fact] // notation para identifcar que o metodo é um metodo de test
        public void TestSumMetodh()
        {
            // Arrange : Organizar
            var x1 = 4.1;
            var x2 = 5.9;
            var result = 10;

            // Act : Agir
            var soma = Calculo.Somar(x1,x2);

            // Assert : Provar
            Assert.Equal(result, soma);
        }

        [Fact]
        public void TestSubMethod() 
        {
            var x1 = 20;
            var x2 = 7;
            var result = 13;

            var sub = Calculo.Subtracao(x1,x2);

            Assert.Equal(result, sub);

        }

        [Fact]
        public void TestDivMethod()
        {
            var x1 = 20;
            var x2 = 4;
            var result = 5;

            var sub = Calculo.Divisao(x1, x2);

            Assert.Equal(result, sub);

        }

        [Fact]
        public void TestMultMethod()
        {
            var x1 = 4;
            var x2 = 5;
            var result = 20;

            var sub = Calculo.Multiplicacao(x1, x2);

            Assert.Equal(result, sub);

        }
    }
}
