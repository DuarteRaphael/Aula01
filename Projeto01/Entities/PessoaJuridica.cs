using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class PessoaJuridica : Cliente
    {
        //atributo
        private string cnpj;

        //encapsulamento
        public string Cnpj
        {
            set { cnpj = value; }
            get { return cnpj; }
        }
    }
}
