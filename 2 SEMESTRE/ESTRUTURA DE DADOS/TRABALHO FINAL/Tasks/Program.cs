using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    internal class Program
    {
        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            TaskManager manager = new TaskManager();
            bool continuar = true;

            while (continuar)
            {
                ExibirMenu();
                Console.Write("Escolha uma opção: ");

                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    Sair(ref continuar);
                    break;
                }

                int? opcao = int.TryParse(entrada, out int numero) ? numero : null;
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
                        Console.WriteLine("Opção inválida. Digite um número de 0 a 8.");
                        break;
                }

                if (!continuar)
                {
                    break;
                }

                if (!Console.IsInputRedirected)
                {
                    Console.WriteLine("\nPressione Enter para voltar ao menu.");
                    if (Console.ReadLine() == null)
                    {
                        Sair(ref continuar);
                        break;
                    }
                }

                if (!Console.IsOutputRedirected)
                {
                    Console.Clear();
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("          GERENCIADOR DE TAREFAS        ");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Criar tarefa");
            Console.WriteLine("2 - Listar todas as tarefas");
            Console.WriteLine("3 - Listar por prioridade");
            Console.WriteLine("4 - Filtrar por status");
            Console.WriteLine("5 - Concluir tarefa");
            Console.WriteLine("6 - Editar tarefa");
            Console.WriteLine("7 - Remover tarefa");
            Console.WriteLine("8 - Desfazer última remoção");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("----------------------------------------");
        }

        private static string LerTexto(string mensagem)
        {
            Console.Write(mensagem);
            return (Console.ReadLine() ?? string.Empty).Trim();
        }

        private static Enumeradores.Priority? LerPrioridade()
        {
            Console.WriteLine("Prioridade:");
            Console.WriteLine("1 - Baixa");
            Console.WriteLine("2 - Média");
            Console.WriteLine("3 - Alta");

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
                    Console.WriteLine("Prioridade inválida.");
                    return null;
            }
        }

        private static void ExibirTarefa(Task task)
        {
            string textoStatus = task.Status == Enumeradores.Status.COMPLETED ? "CONCLUÍDA" : "PENDENTE";

            string textoPrioridade = "BAIXA";

            if (task.Priority == Enumeradores.Priority.HIGH)
            {
                textoPrioridade = "ALTA";
            }
            else if (task.Priority == Enumeradores.Priority.MEDIUM)
            {
                textoPrioridade = "MÉDIA";
            }

            Console.WriteLine(
                $"#{task.Id} | " +
                $"Status: {textoStatus} | " +
                $"Prioridade: {textoPrioridade} | " +
                $"Descrição: {task.Description} | " +
                $"Criada em: {task.CreationDate:dd/MM/yyyy HH:mm}"
            );
        }

        private static void CriarTarefa(TaskManager manager)
        {
            Console.WriteLine("\n=== CRIAR TAREFA ===");
            string descricao = LerTexto("Digite a descrição da tarefa: ");

            if (string.IsNullOrEmpty(descricao))
            {
                Console.WriteLine("Descrição inválida.");
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

            Console.WriteLine($"Tarefa #{id} criada com sucesso!");
        }

        private static void ListarTarefas(TaskManager manager)
        {
            Console.WriteLine("\n=== TODAS AS TAREFAS ===");
            List<Task> tarefas = manager.GetAll();

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void ListarPorPrioridade(TaskManager manager)
        {
            Console.WriteLine("\n=== TAREFAS POR PRIORIDADE ===");
            List<Task> tarefas = manager.GetByPriority();

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa cadastrada.");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void FiltrarPorStatus(TaskManager manager)
        {
            Console.WriteLine("\n=== FILTRAR POR STATUS ===");
            Console.WriteLine("1 - Pendentes");
            Console.WriteLine("2 - Concluídas");

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
                Console.WriteLine("Opção inválida.");
                return;
            }

            if (tarefas.Count == 0)
            {
                Console.WriteLine("Nenhuma tarefa encontrada com esse status.");
                return;
            }

            foreach (Task task in tarefas)
            {
                ExibirTarefa(task);
            }
        }

        private static void ConcluirTarefa(TaskManager manager)
        {
            Console.WriteLine("\n=== CONCLUIR TAREFA ===");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa: "), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            if (manager.Complete(id))
            {
                Console.WriteLine($"Tarefa #{id} marcada como concluída!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        private static void EditarTarefa(TaskManager manager)
        {
            Console.WriteLine("\n=== EDITAR TAREFA ===");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa: "), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            Task? task = manager.FindById(id);
            if (task == null)
            {
                Console.WriteLine("Tarefa não encontrada.");
                return;
            }

            string novaDescricao = LerTexto("Digite a nova descrição: ");
            if (string.IsNullOrEmpty(novaDescricao))
            {
                Console.WriteLine("Descrição inválida.");
                return;
            }

            Enumeradores.Priority? novaPrioridade = LerPrioridade();
            if (novaPrioridade == null)
            {
                return;
            }

            manager.Update(id, novaDescricao, novaPrioridade.Value);
            Console.WriteLine($"Tarefa #{id} atualizada com sucesso!");
        }

        private static void RemoverTarefa(TaskManager manager)
        {
            Console.WriteLine("\n=== REMOVER TAREFA ===");

            if (!int.TryParse(LerTexto("Digite o ID da tarefa a ser removida: "), out int id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            if (manager.Remove(id))
            {
                Console.WriteLine($"Tarefa #{id} removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Tarefa não encontrada.");
            }
        }

        private static void DesfazerRemocao(TaskManager manager)
        {
            Console.WriteLine("\n=== DESFAZER ÚLTIMA REMOÇÃO ===");
            Task? restaurada = manager.UndoRemove();

            if (restaurada == null)
            {
                Console.WriteLine("Nenhuma tarefa removida para restaurar.");
                return;
            }

            Console.WriteLine($"Tarefa #{restaurada.Id} ({restaurada.Description}) restaurada com sucesso!");
        }

        private static void Sair(ref bool continuar)
        {
            Console.WriteLine("Saindo do programa...");
            continuar = false;
        }
    }
}
