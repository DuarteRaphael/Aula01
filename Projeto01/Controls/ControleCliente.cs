using Projeto01.Contracts;
using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Projeto01.Controls
{
    public class ControleCliente : IControleCliente
    {
        //Atributo
        private readonly string pasta = "c:\\tmp\\";
        public void ExportarTxt(Cliente c)
        {
            //abrir um arquivo
            StreamWriter arq = new StreamWriter(pasta + "cliente.txt", true);

            //escrevendo no arquivo
            arq.WriteLine($"Id do cliente....: {c.idCliente}");
            arq.WriteLine($"Email do cliente.: {c.Email}");
            arq.WriteLine($"Nome do cliente..: {c.Nome}");

            //fechando o arquivo
            arq.Close();
        }

        public void ExportarCsv(Cliente c)
        {
            StreamWriter arq = new StreamWriter(pasta + "cliente.csv", true);
            arq.WriteLine($"{c.idCliente};{c.Email};{c.Nome}");
            arq.Close();
        }

        public void ExportarXml(Cliente c)
        {
            XmlWriter arq = XmlWriter.Create(pasta + "cliente.xml");
            arq.WriteStartDocument(); //cabeçalho do XML

            //escrever tag raiz XML
            arq.WriteStartElement("dados");

            //gravar os dados do cliente
            arq.WriteStartElement("cliente");
            arq.WriteElementString("Idcliente", c.idCliente.ToString());
            arq.WriteElementString("Email", c.Email);
            arq.WriteElementString("Nome", c.Nome);
            arq.WriteEndElement();
            arq.WriteEndElement();
            arq.Close();
        }
    }
}
