using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidacaoEmail
{
    public class Email
    {
        public static bool EmailValid(string email)
        {
            //@"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            //@"/^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$/"
            
            //  Definimos a variavel regex do tipo string e inicializamos ela com um regex.
            string regex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Criamos um objeto do tipo regex onde passamos para o construtor a string criada acima.
            Regex r = new Regex(regex);

            // Acessamos a class Match onde representa os resultados de uma única correspondência de expressão regular.
            Match match = r.Match(email);
                        
            return match.Success; // Retornamos caso a correspondêcia seja true
        }
    }
}
