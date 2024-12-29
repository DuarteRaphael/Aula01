using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Entities
{
    public class Cliente
    {
        //Atributos
        public Guid idCliente;
        private string nome;
        private string email;

        //método de encapsulamento
        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }
    }
}
