// See https://aka.ms/new-console-template for more information
//imprimir mensagem no prompt do DOS
using Projeto01.Entities;
using Projeto01.Controls;

Console.WriteLine("Aula de C# - COTI Informática");

//Classe -> Objeto
Cliente c = new Cliente();
c.Nome = "Raphael Santos Duarte";


//imprimindo
Console.WriteLine($"Seja bem vindo: {c.Nome}");


c.idCliente = Guid.NewGuid();
c.Nome = "Raphael Santos Duarte";
c.Email = "raphael-duarte@outlook.com";

//imprimindo
Console.WriteLine("\nDados do Cliente:");
Console.WriteLine($"\tId do Cliente........: { c.idCliente}");
Console.WriteLine($"\tNome do Cliente......: {c.Nome}");
Console.WriteLine($"\tEmail do Cliente.....: {c.Email}");

try
{
    ControleCliente cc = new();
    cc.ExportarTxt(c);
    cc.ExportarCsv(c);
    cc.ExportarXml(c);
}
catch (Exception e)
{
    Console.WriteLine($"Erro: {e.Message}");
}

PessoaFisica pf = new PessoaFisica();
pf.idCliente = Guid.NewGuid();
pf.Nome = "João Silva";
pf.Email = "joao.silva@gmail.com";
pf.Cpf = "1234567890";

PessoaJuridica pj = new PessoaJuridica();
pj.idCliente = Guid.NewGuid();
pj.Nome = "Fulano de Tal";
pj.Email = "fulano.detal@gmail.com";
pj.Cnpj = "0987654321";

//imprimindo
Console.WriteLine("\nDados de Pessoa Física:");
Console.WriteLine($"{pf.idCliente}, {pf.Nome}, {pf.Email}, {pf.Cpf}");

Console.WriteLine("\nDados de Pessoa Jurídica:");
Console.WriteLine($"{pj.idCliente}, {pj.Nome}, {pj.Email}, {pj.Cnpj}");

//pause
Console.ReadKey(true);