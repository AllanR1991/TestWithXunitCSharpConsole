using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventário
{
    public class Iventario
    {
        public static List<Produto> listaProduto = new List<Produto>
        {
            new Produto {  Nome = "PcGamer", Quantidade = 4  },
            new Produto {  Nome = "Mesa", Quantidade = 7  },
            new Produto {  Nome = "Celular", Quantidade = 2  }
        };
        public static List<Produto> AdicionarProduto( Produto newProduct)
        {
            if(newProduct.Nome != null)
            {
                Produto produtoEncontrado = listaProduto.Find(produto => produto.Nome == newProduct.Nome);

                if (produtoEncontrado == null)
                {
                    listaProduto.Add(newProduct);
                    return listaProduto;
                }
                else
                {
                    produtoEncontrado.Quantidade = newProduct.Quantidade;
                    return listaProduto;
                }
            }
            return listaProduto;
        }

        
        public static int? BuscarQuantidadeProduto( string searchProduto)
        {  
            if (searchProduto != null)
            {
                Produto produtoEncontrado = listaProduto.Find(produto => produto.Nome == searchProduto);

                if (produtoEncontrado != null)
                {                    
                    return produtoEncontrado.Quantidade;
                }                
            }
            return null;
        }
    }
}
