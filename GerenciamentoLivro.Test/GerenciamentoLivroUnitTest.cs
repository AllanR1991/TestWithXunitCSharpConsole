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
        //  Crie um teste unitário para o método AdicionarLivro que verifica se um livro é adicionado corretamente a uma lista de livros.  
        [Fact]
        public void TestAdicionarLivroMetodh()
        {
            List<Livro> listaLivros = new List<Livro>();
            Livro livro = new Livro();
            livro.Name = "Harry Poter";                      
            string result = "Harry Poter";

            var adicionaLivro = Livro.AdicionarLivro(livro, listaLivros);

            Assert.Equal(result, adicionaLivro[0].Name);
        }
    }
}
