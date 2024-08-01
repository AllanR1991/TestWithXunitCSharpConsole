using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciamentoLivro.Test
{
    public class GerenciamentoLivroUnitTest
    {
        [Fact]
        public void TestAdicionarLivroMetodh()
        {
            string livro = "Harry Poter";
            string[] Livros = new string[10] ;
            string[] result = ["Harry Poter",null,null,null,null,null, null, null, null, null];

            var adicionaLivro = Livro.AdicionarLivro(livro, Livros);

            Assert.Equal(result, adicionaLivro);
        }
    }
}
