using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoLivro
{
    public class Livro
    {
        //  Crie um teste unitário para o método AdicionarLivro que verifica se um livro é adicionado corretamente a uma lista de livros.  
        public static string[] AdicionarLivro(string livro, string[] ListaLivros )
        {
            for (int i = 0; i < ListaLivros.Length-1; i++)

            if (ListaLivros[i]==null) 
            {
                ListaLivros[i] = livro;
                break;
            }

            return ListaLivros;
        }
    }
}
