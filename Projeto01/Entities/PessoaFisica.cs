using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class PessoaFisica : Cliente
    {
        //atributo
        private string cpf;

        //encapsulamento
        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
    }
}
