using GerenciamentoFuncionario.AcessoDados;
using GerenciamentoFuncionario.Comuns.Modelos;
using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main()
        {
            var funcProvedor = new FuncionarioProvedorDados();
            var cargoProvedor = new CargoProvedorDados();

            var funcionarios = funcProvedor.CarregaFuncionarios();
            var cargos = cargoProvedor.CarregaCargos();

            Console.WriteLine(" ----------------------------------------------- ---- ");
            Console.WriteLine(" -----------Bem vindo a Peperoni's Company----------- ");
            Console.WriteLine(" ----------------------------------------------- ---- ");
            Console.WriteLine(" ------Por favor, siga as instruções a seguir-------- ");
            Console.WriteLine(" ----------------------------------------------- ---- ");
            Console.WriteLine(" \n\n ");

            MenuInicial:
            Console.WriteLine("1) - Deseja ir para área de cargos?");
            Console.WriteLine("2) - Deseka ir para área de funcionários?");
            Console.WriteLine("3) - Deseka sair do programa?");
            string respostaInicial = Console.ReadLine();

            if (respostaInicial == "1")
            {
                MenuCargo:
                Console.WriteLine(" ----------------------------------------------- ---- ");
                Console.WriteLine(" ------------Bem vindo a área de cargos-------------- ");
                Console.WriteLine(" ----------------------------------------------- ---- ");
                Console.WriteLine(" 1) - Deseja criar um cargo ");
                Console.WriteLine(" 2) - Deseja excluir um cargo");
                Console.WriteLine(" 3) - Deseja atualizar um cargo");
                Console.WriteLine(" 4) - Deseja listar os cargos");
                Console.WriteLine(" 5) - Voltar para menu");
                Console.Write("Resposta:");
                string escolhaCargo = Console.ReadLine();

                switch (escolhaCargo)
                {
                    case "1":
                        Console.WriteLine(" \n\n ");
                        Console.Write("Digite o nome do cargo:");
                        string nomeCargo = Console.ReadLine();
                        var cargoCriado = cargoProvedor.SalvaCargo(nomeCargo);

                        Console.Clear();

                        Console.WriteLine(" \n ");
                        Console.WriteLine("Confirmando a criação de cargo");
                        Console.WriteLine("ID do cargo:" + cargoCriado.Id);
                        Console.WriteLine("Nome do cargo criado" + cargoCriado.CargoNome);

                        Console.WriteLine("Confirma a criação? (S/N)");
                        string respostafinalCargo = Console.ReadLine();
                        if (respostafinalCargo.ToUpper() == "N")
                        {
                            Console.WriteLine("Deseja:");
                            Console.WriteLine("1) - Excluir");
                            Console.WriteLine("2) - Alterar/Atualizar");
                            string respostaCARGO = Console.ReadLine();

                            if (respostaCARGO == "1")
                            {
                                //aqui estou listando os cargos para pessoa saber qual cargo ela quer excluir
                                ApresentaCargos(cargos);

                                Console.WriteLine("");
                                Console.Write("Digite o ID do cargo que deseja excluir: ");
                                string idExclui = Console.ReadLine();
                                int IDExcluindo = int.Parse(idExclui);
                                var excluirCargo = cargoProvedor.RecuperaCargoPorId(IDExcluindo);
                                cargoProvedor.ExcluiCargo(excluirCargo);
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("---------Cargo excluido---------");
                                Console.WriteLine("--------------------------------");
                            }
                            else
                            {
                                //aqui estou listando os cargos para pessoa saber qual cargo ela quer atualizar
                                ApresentaCargos(cargos);

                                Console.WriteLine("");
                                Console.Write("Digite o ID do cargo que deseja alterar/atualizar: ");
                                string IDAlterando = Console.ReadLine();
                                int IdAlterando = int.Parse(IDAlterando);

                                var _idSelecionado = cargoProvedor.RecuperaCargoPorId(IdAlterando);
                                Console.WriteLine("Cargo que deseja alterar: " + _idSelecionado.CargoNome);

                                Console.WriteLine(" \n");
                                Console.Write("Digite o nome do novo cargo: ");
                                string NovoNome = Console.ReadLine();

                                _idSelecionado.CargoNome = NovoNome;
                                cargoProvedor.AtualizaCargo(_idSelecionado);

                                Console.WriteLine("\n");
                                Console.WriteLine("--- Dados atualizados ---");
                                Console.WriteLine("Id: " + _idSelecionado.Id);
                                Console.WriteLine("Nome: " + _idSelecionado.CargoNome);
                                Console.WriteLine("-------------------------");

                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("--------Cargo Atualizado--------");
                                Console.WriteLine("--------------------------------");

                                Console.WriteLine("Deseja voltar para o:");
                                Console.WriteLine("1) - Menu inicial");
                                Console.WriteLine("2) - Meno do cargo");
                                string Resposta9= Console.ReadLine();
                                if (Resposta9 == "1")
                                {
                                    goto MenuInicial;
                                    
                                }
                                else
                                {
                                    goto MenuCargo;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("----------Cargo criado----------");
                            Console.WriteLine("--------------------------------");
                        }
                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do cargo");
                        string Resposta = Console.ReadLine();
                        if (Resposta == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuCargo;
                        }

                    //break;
                    case "2":

                        //aqui estou listando os cargos para pessoa saber qual cargo ela quer atualizar
                        ApresentaCargos(cargos);

                        Console.Write("Digite o ID do cargo que deseja excluir: ");

                        string idExclui1 = Console.ReadLine();
                        int IDExcluindo1 = int.Parse(idExclui1);

                        var excluirCargo1 = cargoProvedor.RecuperaCargoPorId(IDExcluindo1);
                        cargoProvedor.ExcluiCargo(excluirCargo1);

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("---------Cargo excluido---------");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do cargo");
                        string Resposta1 = Console.ReadLine();
                        if (Resposta1 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuCargo;
                        }
                    // break;

                    case "3":

                        //aqui estou listando os cargos para pessoa saber qual cargo ela quer atualizar
                        ApresentaCargos(cargos);

                        Console.WriteLine("");
                        Console.Write("Digite o ID do cargo que deseja alterar/atualizar: ");
                        string IDAlterando1 = Console.ReadLine();
                        int IdAlterando1 = int.Parse(IDAlterando1);

                        var _idSelecionado1 = cargoProvedor.RecuperaCargoPorId(IdAlterando1);
                        Console.WriteLine("Cargo que deseja alterar: " + _idSelecionado1.CargoNome);

                        Console.WriteLine(" \n");
                        Console.Write("Digite o nome do novo cargo: ");
                        string NovoNome1 = Console.ReadLine();

                        _idSelecionado1.CargoNome = NovoNome1;
                        cargoProvedor.AtualizaCargo(_idSelecionado1);

                        Console.WriteLine("\n");
                        Console.WriteLine("--- Dados atualizados ---");
                        Console.WriteLine("Id: " + _idSelecionado1.Id);
                        Console.WriteLine("Nome: " + _idSelecionado1.CargoNome);
                        Console.WriteLine("-------------------------");

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("--------Cargo Atualizado--------");
                        Console.WriteLine("--------------------------------");

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do cargo");
                        string Resposta2 = Console.ReadLine();
                        if (Resposta2 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuCargo;
                        }
                    // break;
                    case "4":

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("-------Cargos Cadastrados-------");
                        Console.WriteLine("--------------------------------");

                        //aqui estou listando os cargos 
                        ApresentaCargos(cargos);

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do cargo");
                        string Resposta3 = Console.ReadLine();
                        if (Resposta3 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuCargo;
                        }
                    // break;

                    case "5":

                        Console.Clear();
                        goto MenuInicial;

                       // break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine("Opção inválida, digite uma opção válida:");
                        Console.WriteLine("\n");
                        break;
                }  
            }
            else if (respostaInicial == "2")
            {
                Console.WriteLine(" ---------------------------------------------------- ");
                Console.WriteLine(" ------------Bem vindo a área de funcionários-------------- ");
                Console.WriteLine(" ---------------------------------------------------- ");
                Console.WriteLine("Escolha uma das opções");
                Console.WriteLine("\n");

                MenuFuncionario:
                Console.WriteLine(" 1) - Deseja criar um funcionário ");
                Console.WriteLine(" 2) - Deseja excluir um funcionário");
                Console.WriteLine(" 3) - Deseja atualizar um funcionário");
                Console.WriteLine(" 4) - Deseja listar os funcionários");
                Console.WriteLine(" 5) - Voltar para menu");
                Console.Write("Resposta:");
                string resultado = Console.ReadLine();

                switch (resultado)
                {
                    case "1":
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("  Adicionando funcionário   ");
                        Console.WriteLine("----------------------------");
                        Console.Write("Nome Completo.................:");
                        string nomeCompleto = Console.ReadLine();
                        Console.WriteLine("\n\n");

                        // aqui estou listando os cargos para que ele posso escolher o cargo para o funcionário
                        ApresentaCargos(cargos);
                        Console.Write("Escolha o cargo do funcionário:");
                        string cargoID = Console.ReadLine();
                        int cargoId = int.Parse(cargoID);

                        Console.WriteLine("Vai querer beber café? (S/N)");
                        string BebedorCafe = Console.ReadLine();
                        bool eBebedorCafe;

                        if (BebedorCafe.ToUpper() == "S")
                        {
                            eBebedorCafe = true;
                        }
                        else
                        {
                            eBebedorCafe = false;
                        }

                        var funcionrioAdicionado = funcProvedor.SalvaFuncionario(nomeCompleto, cargoId, eBebedorCafe);

                        Console.WriteLine("\n\n");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("  Confirmação do Funcionário  ");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("Nome do funcionário" + funcionrioAdicionado.NomeCompleto);
                        Console.WriteLine("ID do funcionário" + funcionrioAdicionado.Id);

                        switch (eBebedorCafe)
                        {
                            case true:
                                Console.WriteLine("Funcionário vai beber café");
                                break;
                            case false:
                                Console.WriteLine("Funcionário não vai beber café");
                                break;
                            //default:
                                //break;
                        }
                        Console.WriteLine("As informações estão corretas?");
                        string respostaFunc = Console.ReadLine();

                        if (respostaFunc.ToUpper() == "N")
                        {
                            Console.WriteLine("Deseja:");
                            Console.WriteLine("1) - Excluir");
                            Console.WriteLine("2) - Alterar/Atualizar");
                            string respostaFuncFinal = Console.ReadLine();

                            if (respostaFuncFinal == "1")
                            {
                                Console.WriteLine("\n");
                                Console.Write("Digite o ID do funcionário que deseja excluir: ");
                                string ExcluindoFunc = Console.ReadLine();
                                int IDExcluindo = int.Parse(ExcluindoFunc);
                                var funcionarioExcluir1 = funcProvedor.RecuperaFuncionarioPorId(IDExcluindo);
                                funcProvedor.ExcluiFuncionario(funcionarioExcluir1);
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("---------Funcionário excluido---------");
                                Console.WriteLine("--------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("\n");

                                //aqui estou apresentando os funcionários para o usuário saber qual vai alterar
                                ApresentaFuncionarios(funcionarios);

                                Console.Write("Digite o ID do funcionário que deseja atualizar/alterar: ");
                                string IDFunAlterado1 = Console.ReadLine();
                                int IdSelecionado1 = int.Parse(IDFunAlterado1);
                                var funcionarioAlterado1 = funcProvedor.RecuperaFuncionarioPorId(IdSelecionado1);

                                Console.WriteLine("Funcionario selecionado para ser alterado: " + funcionarioAlterado1.NomeCompleto);

                                Console.WriteLine("\n");
                                Console.WriteLine("Qual informação deseja alterar/atualizar ?");
                                Console.WriteLine("1) - Nome do funcionário");
                                Console.WriteLine("2) - O cargo do funcionário");
                                Console.WriteLine("3) - Se o mesmo bebe ou não café");
                                Console.Write("Resposta");
                                string ItemAlterado1 = Console.ReadLine();

                                if (ItemAlterado1 == "1")
                                {
                                    Console.WriteLine("\n");
                                    Console.Write("Digite o nome completo do funcionário: ");
                                    string nomeAtualizado = Console.ReadLine();

                                    funcionarioAlterado1.NomeCompleto = nomeAtualizado;
                                    funcProvedor.AtualizaFuncionario(funcionarioAlterado1);
                                    break;
                                }
                                else if (ItemAlterado1 == "2")
                                {
                                    //estou mostrando os cargos para ele saber qual ID vai colocar
                                    ApresentaCargos(cargos);

                                    Console.WriteLine("\n");
                                    Console.Write("Digite o ID do novo cargo do funcionário");
                                    string IDatualizado = Console.ReadLine();
                                    int NovoID = int.Parse(IDatualizado);

                                    funcionarioAlterado1.SetCargoId(NovoID);

                                    funcProvedor.AtualizaFuncionario(funcionarioAlterado1);
                                }
                                else
                                {
                                bebedorCafe:

                                    Console.WriteLine("");
                                    Console.Write("Funcionário vai beber café? (S/N): ");
                                    string NovoBebeCafe = Console.ReadLine();

                                    if (NovoBebeCafe.ToUpper() == "S")
                                    {
                                        funcionarioAlterado1.eBebedorDeCafe();
                                        funcProvedor.AtualizaFuncionario(funcionarioAlterado1);
                                    }
                                    else if (NovoBebeCafe.ToUpper() == "N")
                                    {
                                        funcionarioAlterado1.NaoEBebedorDeCafe();
                                        funcProvedor.AtualizaFuncionario(funcionarioAlterado1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("** Opção inválida, tente novamente! **");
                                        goto bebedorCafe;
                                    }
                                }

                                Console.WriteLine("\n");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("--------- Funcionário atualizado----------");
                                Console.WriteLine("------------------------------------------");
                                Console.WriteLine("Id: " + funcionarioAlterado1.Id);
                                Console.WriteLine("Nome completo: " + funcionarioAlterado1.NomeCompleto);
                                Console.WriteLine("Cargo: " + funcionarioAlterado1.CargoId);
                                Console.WriteLine("Bebe café: " + funcionarioAlterado1.EBebedorCafe);
                                Console.WriteLine("-------------------------");
                                Console.WriteLine("\n");
                            }

                            
                        }
                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do funcionário");
                        string Resposta444 = Console.ReadLine();
                        if (Resposta444 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuFuncionario;
                        }
                        //break;

                        case "2":
                        //Função de escluir o funcionario ou mais de um
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("     Excluindo funcionário     ");
                        Console.WriteLine("-------------------------------");
                        Console.WriteLine("\n\n");

                        ApresentaFuncionarios(funcionarios);

                        Console.WriteLine("Digite o ID do funcionário que deseja escluir?");
                        string ExcluirFunc = Console.ReadLine();
                        int FuncExcluido = int.Parse(ExcluirFunc);

                        var funcionarioExcluir = funcProvedor.RecuperaFuncionarioPorId(FuncExcluido);
                        funcProvedor.ExcluiFuncionario(funcionarioExcluir);

                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("-----Funcionário Excluido com sucesso----");
                        Console.WriteLine("-----------------------------------------");

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do funcionário");
                        string Resposta4 = Console.ReadLine();
                        if (Resposta4 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuFuncionario;
                        }
                        //break;

                    case "3":
                        //método para atualizar um funcionario

                        Console.WriteLine("\n");

                        //aqui estou apresentando os funcionários para o usuário saber qual vai alterar
                        ApresentaFuncionarios(funcionarios);

                        Console.Write("Digite o ID do funcionário que deseja atualizar/alterar: ");
                        string IDFunAlterado = Console.ReadLine();
                        int IdSelecionado = int.Parse(IDFunAlterado);
                        var funcionarioAlterado = funcProvedor.RecuperaFuncionarioPorId(IdSelecionado);

                        Console.WriteLine("Funcionario selecionado para ser alterado: " + funcionarioAlterado.NomeCompleto);

                        Console.WriteLine("\n");
                        Console.WriteLine("Qual informação deseja alterar/atualizar ?");
                        Console.WriteLine("1) - Nome do funcionário");
                        Console.WriteLine("2) - O cargo do funcionário");
                        Console.WriteLine("3) - Se o mesmo bebe ou não café");
                        Console.Write("Resposta");
                        string ItemAlterado = Console.ReadLine();

                        if (ItemAlterado == "1")
                        {
                            Console.WriteLine("\n");
                            Console.Write("Digite o nome completo do funcionário: ");
                            string nomeAtualizado = Console.ReadLine();

                            funcionarioAlterado.NomeCompleto = nomeAtualizado;
                            funcProvedor.AtualizaFuncionario(funcionarioAlterado);
                            break;
                        }
                        else if (ItemAlterado == "2")
                        {
                            //estou mostrando os cargos para ele saber qual ID vai colocar
                            ApresentaCargos(cargos);

                            Console.WriteLine("\n");
                            Console.Write("Digite o ID do novo cargo do funcionário");
                            string IDatualizado = Console.ReadLine();
                            int NovoID = int.Parse(IDatualizado);

                            funcionarioAlterado.SetCargoId(NovoID);

                            funcProvedor.AtualizaFuncionario(funcionarioAlterado);
                        }
                        else
                        {
                        bebedorCafe:

                            Console.WriteLine("");
                            Console.Write("Funcionário vai beber café? (S/N): ");
                            string NovoBebeCafe = Console.ReadLine();

                            if (NovoBebeCafe.ToUpper() == "S")
                            {
                                funcionarioAlterado.eBebedorDeCafe();
                                funcProvedor.AtualizaFuncionario(funcionarioAlterado);
                            }
                            else if (NovoBebeCafe.ToUpper() == "N")
                            {
                                funcionarioAlterado.NaoEBebedorDeCafe();
                                funcProvedor.AtualizaFuncionario(funcionarioAlterado);
                            }
                            else
                            {
                                Console.WriteLine("** Opção inválida, tente novamente! **");
                                goto bebedorCafe;
                            }

                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("--------- Funcionário atualizado----------");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("Id: " + funcionarioAlterado.Id);
                        Console.WriteLine("Nome completo: " + funcionarioAlterado.NomeCompleto);
                        Console.WriteLine("Cargo: " + funcionarioAlterado.CargoId);
                        Console.WriteLine("Bebe café: " + funcionarioAlterado.EBebedorCafe);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("\n");

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do funcionário");
                        string Resposta43 = Console.ReadLine();
                        if (Resposta43 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuFuncionario;
                        }
                       // break;

                    case "4":
     
                        //aqui apenas vai mostrar a lista de funcinonários

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("-----Lista de funcionários cadastrados-----");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("\n\n");
                        ApresentaFuncionarios(funcionarios);

                        Console.WriteLine("Deseja voltar para o:");
                        Console.WriteLine("1) - Menu inicial");
                        Console.WriteLine("2) - Meno do funcionário");
                        string Resposta44 = Console.ReadLine();
                        if (Resposta44 == "1")
                        {
                            goto MenuInicial;

                        }
                        else
                        {
                            goto MenuFuncionario;
                        }
                        //break;
                

                    case "5:":
                        Console.Clear();
                        goto MenuInicial;

                        // break;

                    default:
                        //Fazer função para retornar projeto novamente
                        break;

                }

              Console.WriteLine("------------------------------------------------------------");
              Console.WriteLine("     Programa finalizando, muito obrigado pela sua atenção  ");
              Console.WriteLine("------------------------------------------------------------");
                    


                    

            }
        }

        private static void ApresentaCargos(IEnumerable<Cargo> cargos)
        {
            foreach (var cargo in cargos)
            {
                Console.WriteLine("");
                Console.WriteLine("Id: " + cargo.Id);
                Console.WriteLine("Cargo: " + cargo.CargoNome);
                Console.WriteLine("");
            }
        }
        private static void ApresentaFuncionarios(IEnumerable<Funcionario> funcionarios)
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine("");
                Console.WriteLine("Id: " + funcionario.Id);
                Console.WriteLine("Nome: " + funcionario.NomeCompleto);
                Console.WriteLine("");
            }
        }
    }
}
