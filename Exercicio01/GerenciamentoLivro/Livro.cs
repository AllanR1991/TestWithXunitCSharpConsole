using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLivro
{
    public class Livro
    {
        public string Name {  get; set; }
        //  Crie um teste unitário para o método AdicionarLivro que verifica se um livro é adicionado corretamente a uma lista de livros.  
        public static List<Livro> AdicionarLivro(Livro livro, List<Livro> ListaLivros )
        {
            ListaLivros.Add(livro);
            
            return ListaLivros;
        }
    }
}
