using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Program
    {
        // Códigos de cores ANSI (ASCII ESC)
        const string RESET = "\u001b[0m";
        const string NEGRITO = "\u001b[1m";
        const string VERMELHO = "\u001b[31m";
        const string VERDE = "\u001b[32m";
        const string AMARELO = "\u001b[33m";
        const string AZUL = "\u001b[34m";
        const string ROXO = "\u001b[35m";
        const string CIANO = "\u001b[36m";
        const string CINZA = "\u001b[90m";

        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            TaskManager manager = new TaskManager();
            bool continuar = true;

            while (continuar)
            {
                ExibirMenu();
                Console.Write($"{CIANO}Escolha uma opção: {RESET}");

                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    Sair(ref continuar);
                    break;
                }

                if (!int.TryParse(entrada, out int opcao))
                {
                    Console.WriteLine($"{VERMELHO}Opção inválida. Digite um número de 0 a 8.{RESET}");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        CriarTarefa(manager);
                        break;
                    case 2:
                        ListarTarefas(manager);
                        break;
                    case 3:
                        ListarPorPrioridade(manager);
                        break;
                    case 4:
                        FiltrarPorStatus(manager);
                        break;
                    case 5:
                        ConcluirTarefa(manager);
                        break;
                    case 6:
                        EditarTarefa(manager);
                        break;
                    case 7:
                        RemoverTarefa(manager);
                        break;
                    case 8:
                        DesfazerRemocao(manager);
                        break;
                    case 0:
                        Sair(ref continuar);
                        break;
                    default:
                        Console.WriteLine($"{VERMELHO}Opção inválida. Digite um número de 0 a 8.{RESET}");
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine($"\n{NEGRITO}{CIANO}========================================{RESET}");
            Console.WriteLine($"{NEGRITO}{ROXO}          GERENCIADOR DE TAREFAS        {RESET}");
            Console.WriteLine($"{NEGRITO}{CIANO}========================================{RESET}");
            Console.WriteLine($"{VERDE}1{RESET} - Criar tarefa");
            Console.WriteLine($"{CIANO}2{RESET} - Listar todas as tarefas");
            Console.WriteLine($"{AZUL}3{RESET} - Listar por prioridade");
            Console.WriteLine($"{AMARELO}4{RESET} - Filtrar por status");
            Console.WriteLine($"{VERDE}5{RESET} - Concluir tarefa");
            Console.WriteLine($"{AZUL}6{RESET} - Editar tarefa");
            Console.WriteLine($"{VERMELHO}7{RESET} - Remover tarefa");
            Console.WriteLine($"{ROXO}8{RESET} - Desfazer última remoção");
            Console.WriteLine($"{CINZA}0 - Sair{RESET}");
            Console.WriteLine($"{CIANO}----------------------------------------{RESET}");
        }

        private static string LerTexto(string mensagem)
        {
            Console.Write(mensagem);
            return (Console.ReadLine() ?? string.Empty).Trim();
        }

        private static Enumeradores.Priority? LerPrioridade()
        {
            Console.WriteLine("Prioridade:");
            Console.WriteLine($"{VERDE}1{RESET} - Baixa");
            Console.WriteLine($"{AMARELO}2{RESET} - Média");
            Console.WriteLine($"{VERMELHO}3{RESET} - Alta");

            string entrada = LerTexto("Escolha a prioridade (1 a 3): ");

            switch (entrada)
            {
                case "1":
                    return Enumeradores.Priority.LOW;
                case "2":
                    return Enumeradores.Priority.MEDIUM;
                case "3":
                    return Enumeradores.Priority.HIGH;
                default:
                    Console.WriteLine($"{VERMELHO}Prioridade inválida.{RESET}");
                    return null;
            }
        }

        private static void ExibirTarefa(Task task)
        {
            string corStatus = task.Status == Enumeradores.Status.COMPLETED ? VERDE : AMARELO;
            string textoStatus = task.Status == Enumeradores.Status.COMPLETED ? "CONCLUÍDA" : "PENDENTE";

            string corPrioridade = VERDE;
            string textoPrioridade = "BAIXA";

            if (task.Priority == Enumeradores.Priority.HIGH)
            {
                corPrioridade = VERMELHO;
                textoPrioridade = "ALTA";
            }
            else if (task.Priority == Enumeradores.Priority.MEDIUM)
            {
                corPrioridade = AMARELO;
                textoPrioridade = "MÉDIA";
            }

            Console.WriteLine(
                $"{NEGRITO}#{task.Id}{RESET} | " +
                $"Status: {corStatus}{textoStatus}{RESET} | " +
                $"Prioridade: {corPrioridade}{textoPrioridade}{RESET} | " +
                $"Descrição: {task.Description} | " +
                $"{CINZA}Criada em: {task.CreationDate:dd/MM/yyyy HH:mm}{RESET}"
            );
        }

        private static void CriarTarefa(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{VERDE}=== CRIAR TAREFA ==={RESET}");
            string descricao = LerTexto("Digite a descrição da tarefa: ");

            if (string.IsNullOrEmpty(descricao))
            {
                Console.WriteLine($"{VERMELHO}Descrição inválida.{RESET}");
                return;
            }

            Enumeradores.Priority? prioridade = LerPrioridade();
            if (prioridade == null)
            {
                return;
            }

            int id = manager.GerarId();
            Task novaTarefa = new Task(id, descricao, prioridade.Value);
            manager.Create(novaTarefa);

            Console.WriteLine($"{VERDE}Tarefa #{id} criada com sucesso!{RESET}");
        }

        private static void ListarTarefas(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{CIANO}=== TODAS AS TAREFAS ==={RESET}");
            List<Task> tarefas = manager.GetAll();

            if (tarefas.Count == 0)
            {
                Console.WriteLine($"{AMARELO}Nenhuma tarefa cadastrada.{RESET}");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void ListarPorPrioridade(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{AZUL}=== TAREFAS POR PRIORIDADE ==={RESET}");
            List<Task> tarefas = manager.GetByPriority();

            if (tarefas.Count == 0)
            {
                Console.WriteLine($"{AMARELO}Nenhuma tarefa cadastrada.{RESET}");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void FiltrarPorStatus(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{AMARELO}=== FILTRAR POR STATUS ==={RESET}");
            Console.WriteLine($"{AMARELO}1{RESET} - Pendentes");
            Console.WriteLine($"{VERDE}2{RESET} - Concluídas");

            string entrada = LerTexto("Escolha o status: ");
            List<Task> tarefas;

            if (entrada == "1")
            {
                tarefas = manager.FilterByStatus(Enumeradores.Status.PENDING);
            }
            else if (entrada == "2")
            {
                tarefas = manager.FilterByStatus(Enumeradores.Status.COMPLETED);
            }
            else
            {
                Console.WriteLine($"{VERMELHO}Opção inválida.{RESET}");
                return;
            }

            if (tarefas.Count == 0)
            {
                Console.WriteLine($"{AMARELO}Nenhuma tarefa encontrada com esse status.{RESET}");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void ConcluirTarefa(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{VERDE}=== CONCLUIR TAREFA ==={RESET}");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa: "), out int id))
            {
                Console.WriteLine($"{VERMELHO}ID inválido.{RESET}");
                return;
            }

            if (manager.Complete(id))
            {
                Console.WriteLine($"{VERDE}Tarefa #{id} marcada como concluída!{RESET}");
            }
            else
            {
                Console.WriteLine($"{VERMELHO}Tarefa não encontrada.{RESET}");
            }
        }

        private static void EditarTarefa(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{AZUL}=== EDITAR TAREFA ==={RESET}");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa: "), out int id))
            {
                Console.WriteLine($"{VERMELHO}ID inválido.{RESET}");
                return;
            }

            Task? task = manager.FindById(id);
            if (task == null)
            {
                Console.WriteLine($"{VERMELHO}Tarefa não encontrada.{RESET}");
                return;
            }

            string novaDescricao = LerTexto("Digite a nova descrição: ");
            if (string.IsNullOrEmpty(novaDescricao))
            {
                Console.WriteLine($"{VERMELHO}Descrição inválida.{RESET}");
                return;
            }

            Enumeradores.Priority? novaPrioridade = LerPrioridade();
            if (novaPrioridade == null)
            {
                return;
            }

            manager.Update(id, novaDescricao, novaPrioridade.Value);
            Console.WriteLine($"{VERDE}Tarefa #{id} atualizada com sucesso!{RESET}");
        }

        private static void RemoverTarefa(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{VERMELHO}=== REMOVER TAREFA ==={RESET}");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa a ser removida: "), out int id))
            {
                Console.WriteLine($"{VERMELHO}ID inválido.{RESET}");
                return;
            }

            if (manager.Remove(id))
            {
                Console.WriteLine($"{VERDE}Tarefa #{id} removida com sucesso!{RESET}");
            }
            else
            {
                Console.WriteLine($"{VERMELHO}Tarefa não encontrada.{RESET}");
            }
        }

        private static void DesfazerRemocao(TaskManager manager)
        {
            Console.WriteLine($"\n{NEGRITO}{ROXO}=== DESFAZER ÚLTIMA REMOÇÃO ==={RESET}");
            Task? restaurada = manager.UndoRemove();

            if (restaurada == null)
            {
                Console.WriteLine($"{AMARELO}Nenhuma tarefa removida para restaurar.{RESET}");
                return;
            }

            Console.WriteLine($"{VERDE}Tarefa #{restaurada.Id} ({restaurada.Description}) restaurada com sucesso!{RESET}");
        }

        private static void Sair(ref bool continuar)
        {
            Console.WriteLine($"{CIANO}Saindo do programa...{RESET}");
            continuar = false;
        }
    }
}
