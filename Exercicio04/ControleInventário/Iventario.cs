using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventário
{
    public class Iventario
    {

        public static List<Produto> AdicionarProduto(List<Produto> produtos, Produto newProduct)
        {
            
            if (produtos.Count == 0) produtos =  new List<Produto>();

            if(newProduct.Nome != null)
            {
                Produto produtoEncontrado = produtos.Find(produto => produto.Nome == newProduct.Nome);

                if (produtoEncontrado == null)
                {
                    produtos.Add(newProduct);
                    return produtos;
                }
                else
                {
                    produtoEncontrado.Quantidade = newProduct.Quantidade;
                    return produtos;
                }
            }
            return produtos;
        }

        public static int BuscarQuantidadeProduto(List<Produto> produtos, string searchProduto)
        {
            if (produtos.Count == 0) produtos = new List<Produto>();

            if (searchProduto != null)
            {
                Produto produtoEncontrado = produtos.Find(produto => produto.Nome == searchProduto);

                if (produtoEncontrado != null)
                {                    
                    return produtoEncontrado.Quantidade;
                }                
            }
            return 0;
        }
    }
}
