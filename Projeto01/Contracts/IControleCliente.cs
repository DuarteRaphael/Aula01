using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Contracts
{
    public interface IControleCliente
    {
        void ExportarTxt(Cliente c);
        void ExportarCsv(Cliente c);
        void ExportarXml(Cliente c);
    }
}
