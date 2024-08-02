using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail.Test
{
    public class ValidacaoEmailTeste
    {        
        [Theory] // representa um pacote de testes que executa o mesmo código, mas têm diferentes argumentos de entrada.
        [InlineData("allan@allan.com")] // especifica valores para essas entradas
        [InlineData("allan")] // especifica valores para essas entradas
        [InlineData("allan@gmailcom")] // especifica valores para essas entradas
        [InlineData("allangmail.com")] // especifica valores para essas entradas
        [InlineData("allan.ar@gmail.com")] // especifica valores para essas entradas
        public void TestEmailValid(string email)
        {
            var validEmail = Email.EmailValid(email);

            Assert.True(validEmail);
        }
    }
}
