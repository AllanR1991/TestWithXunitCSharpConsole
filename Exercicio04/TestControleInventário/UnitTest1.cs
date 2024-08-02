using ControleInventário;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace TestControleInventário
{
    public class UnitTest1
    {
        //  Arrange
        public static Produto produto01 = new Produto{ Nome = "Quadro" , Quantidade = 4};
        public static Produto produto02 = new Produto{ Nome = "Celular" , Quantidade = 6};
        
        List<Produto> resultList = new List<Produto>
        {
            new Produto {  Nome = "PcGamer", Quantidade = 4  },
            new Produto {  Nome = "Mesa", Quantidade = 7  },
            new Produto {  Nome = "Celular", Quantidade = 3  },
            new Produto{ Nome = "Quadro" , Quantidade = 4}
        };

        List<Produto> resultList2 = new List<Produto>
        {
            new Produto {  Nome = "PcGamer", Quantidade = 4  },
            new Produto {  Nome = "Mesa", Quantidade = 7  },
            new Produto {  Nome = "Celular", Quantidade = 6  },            
        };

        [Fact]     
        public void AdicionarProduto_ProdutoNovo_DeveAdicionarNaLista()
        {
            // ACT
            var adicionarProduto = Iventario.AdicionarProduto(produto01);

            Assert.Contains(resultList, produto => produto.Nome == produto01.Nome && produto.Quantidade == produto01.Quantidade);
        }

        [Fact]
        public void AdicionarProduto_ProdutoExistente_DeveAtualizarQuantidade()
        {
            // ACT           
            var adicionarProduto = Iventario.AdicionarProduto(produto02);

            Assert.Contains(resultList2, produto => produto.Nome == produto02.Nome && produto.Quantidade == produto02.Quantidade);
        }

        [Theory] // representa um pacote de testes que executa o mesmo código, mas têm diferentes argumentos de entrada.
        [InlineData("PcGamer")] // especifica valores para essas entradas
        [InlineData("Mesa")] // especifica valores para essas entradas
        [InlineData("xxx")] // especifica valores para essas entradas
        public void BuscaProduto_ProdutoExistente_DeveExibirQuantidade(string nomeProduto)
        {
            // ACT           
            var buscaProduto = Iventario.BuscarQuantidadeProduto( nomeProduto );

            Assert.NotNull(buscaProduto);
        }
    }
}