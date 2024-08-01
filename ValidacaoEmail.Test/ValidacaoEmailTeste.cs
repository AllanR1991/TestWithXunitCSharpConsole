using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail.Test
{
    public class ValidacaoEmailTeste
    {        
        [Theory]
        [InlineData("allan@allan.com")]
        [InlineData("allan")]
        [InlineData("allan@gmailcom")]
        [InlineData("allangmail.com")]
        [InlineData("allan.ar@gmail.com")]
        public void TestEmailValid(string email)
        {
            bool result = true;

            var validEmail = 
        }
    }
}
