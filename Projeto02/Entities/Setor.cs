using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02
{
    public class Setor
    {
        public Guid Id { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
    }
}
