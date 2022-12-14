using Projeto02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Repositories
{
    public class FuncionarioRepositoryTxt : FuncionarioRepository
    {
        public override void ExportarDados(Funcionario funcionario)
        {
            var path = "c:\\temp\\funcionarios.txt";

            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine($"ID DO FUNCIONARIO...: {funcionario.Id}");
                streamWriter.WriteLine($"NOME................: {funcionario.Nome}");
                streamWriter.WriteLine($"DATA DE NASCIMENTO..: {funcionario.DataNascimento.ToString("dd/MM/yyyy")}");
                streamWriter.WriteLine($"CPF.................: {funcionario.Cpf}");
                streamWriter.WriteLine($"MATRÍCULA...........: {funcionario.Matricula}");
                streamWriter.WriteLine($"DATA DE ADMISSÃO....: {funcionario.DataAdmissao.ToString("dd/MM/yyyy")}");
                streamWriter.WriteLine($"ID DO SETOR.........: {funcionario.Setor.Id}");
                streamWriter.WriteLine($"SIGLA...............: {funcionario.Setor.Sigla}");
                streamWriter.WriteLine($"DESCRIÇÃO DO SETOR..: {funcionario.Setor.Descricao}");
                streamWriter.WriteLine("\n");

            }

        }
    }
}
