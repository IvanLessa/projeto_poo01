using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryCsv : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            var path = "c:\\temp\\funcionarios.csv";

            using (var streamWriter = new StreamWriter(path, true))
            {
                var texto = $"{funcionario.Setor.Id};"
                          + $"{funcionario.Nome};"
                          + $"{funcionario.DataNascimento.ToString("dd/MM/yyyy")};"
                          + $"{funcionario.Cpf};"
                          + $"{funcionario.Matricula};"
                          + $"{funcionario.DataAdmissao.ToString("dd/MM/yyyy")};"
                          + $"{funcionario.Setor.Sigla};"
                          + $"{funcionario.Setor.Descricao};";
                
                streamWriter.WriteLine(texto);

            }
        }
    }
}
