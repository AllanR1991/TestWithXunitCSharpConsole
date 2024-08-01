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
    }
}
