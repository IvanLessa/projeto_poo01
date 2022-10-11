using Projeto02.Entities;
using Projeto02.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Controllers
{
    public class FuncionarioController
    {
        public void CadastarFuncionario()
        {
            try
            {
                Console.WriteLine("\n CADASTRO DE FUNCIONÁRIOS \n");

                #region Capturar dados do funcionário
                var funcionario = new Funcionario();
                funcionario.Id = Guid.NewGuid();

                Console.Write("\tNome..................: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("\tData de nascimento ...: ");
                funcionario.DataNascimento = DateTime.Parse(Console.ReadLine());

                Console.Write("\tCpf...................: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("\tMatrícula.............: ");
                funcionario.Matricula = Console.ReadLine();

                Console.Write("\tData de Admissão......: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
                #endregion

                #region Capturar dados do setor do funcionário
                Console.WriteLine("\n INFORMAÇÕES DO SETOR ");

                funcionario.Setor = new Setor();
                funcionario.Setor.Id = new Guid();

                Console.Write("\n\tSigla do setor........: ");
                funcionario.Setor.Sigla = Console.ReadLine();

                Console.Write("\tDescrição do setor....: ");
                funcionario.Setor.Descricao = Console.ReadLine();
                #endregion

                #region Exportar os dados do arquivo

                Console.Write("\n INFORME (1)CSV ou (2)TXT -----> ");
                var opcao = int.Parse(Console.ReadLine());

                FuncionarioRepository funcionarioRepository = null;

                switch (opcao)
                {
                    case 1:
                        funcionarioRepository = new FuncionarioRepositoryCsv();
                        break;

                    case 2:
                        funcionarioRepository = new FuncionarioRepositoryTxt();
                        break;

                    default:
                        Console.Write("\nOPÇÃO INVÁLIDA! DIGITE (1) OU (2)-------> ");
                        break;
                }

                if (funcionarioRepository != null)
                {
                    funcionarioRepository.ExportarDados(funcionario);
                    Console.WriteLine("\nDados gravados com sucesso!");
                }

                #endregion

            }
            catch (Exception e)
            {
                Console.WriteLine($"\nFalha ao cadastrar funcionário: {e.Message}");
            }
            


        }
    }
}
