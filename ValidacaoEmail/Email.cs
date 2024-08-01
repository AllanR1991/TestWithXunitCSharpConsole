using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoEmail
{
    public class Email
    {
        public bool EmailValid(string email)
        {
            if ( email.Contains("@") && email.Contains(".") )
            {
                return true;
            }
            return false;
        }
    }
}
