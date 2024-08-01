using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventário
{
    internal class Produto
    {
        public string? Nome {  get; set; }
        public int? Quantidade { get; set; }

        public static List<Iventario> AdicionarProduto(Produto newProduct)
        {
            List<Iventario> iventario = new List<Iventario>();

            if(newProduct != null)
            {
                Produto? produtoFind = iventario.Find(iventario => iventario.P.Nome == newProduct.Nome);

                if(produtoFind != null)
                {
                    produtoFind.Quantidade = newProduct.Quantidade;
                    return produtos;
                }
                else
                {
                    produtos.Add(newProduct);
                    return produtos;
                }
            }
                return produtos;
        }
    }
}
