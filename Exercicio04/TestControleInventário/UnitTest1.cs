using ControleInventário;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace TestControleInventário
{
    public class UnitTest1
    {
        [Fact]     
        public void Test1()
        {
            List<Produto> listaProduto = new List<Produto>
            {
                new Produto {  Nome = "PcGamer", Quantidade = 4  },
                new Produto {  Nome = "Mesa", Quantidade = 7  },                
                new Produto {  Nome = "Celular", Quantidade = 2  }
            };

            List<Produto> resultList = new List<Produto>
            {
                new Produto {  Nome = "PcGamer", Quantidade = 4  },
                new Produto {  Nome = "Mesa", Quantidade = 7  },
                new Produto {  Nome = "Celular", Quantidade = 3  }
            };

            //Produto produto = new Produto();
            //produto.Nome = "Celular";
            //produto.Quantidade = 2;

            //var adicionarProduto = Iventario.AdicionarProduto(listaProduto, produto);

            //Console.WriteLine(adicionarProduto);
            //Console.WriteLine(resultList);

            Assert.Equal(JsonSerializer.Serialize(resultList), JsonSerializer.Serialize(listaProduto));
            //int count = 0;

            //for (int i = 0; i < resultList.Count - 1; i++)
            //{
            //    Assert.Equal(resultList[i], listaProduto[i]);
            //}

            //foreach (var x in resultList)
            //{
            //    Assert.Equal(x, (Produto)listaProduto[count]);
            //    //Assert.Equal(x.Nome, listaProduto[count].Nome);
            //    //Assert.Equal(x.Quantidade, listaProduto[count].Quantidade);
            //    count++;
            //}
        }
    }
}