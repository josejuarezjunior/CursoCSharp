using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode_E_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        

        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            /*
             * Downcastig (obj as Client) é necessário pois deve 
             * respeitar a assinatura do método!
             * O método Equals possui o parâmetro tipo object na assinatura. 
             * Para que sua implementação do Equals seja considerada pela linguagem, 
             * tem que respeitar essa assinatura.
            */
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
