namespace SimpleQueue
{
    internal class Program
    {
        private static void Main()
        {
            SimpleQueue<Cliente> fila = new();
            bool continuar = true;

            while (continuar)
            {
                ExibirMenu();
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarCliente(fila);
                        break;
                    case 2:
                        AtenderCliente(fila);
                        break;
                    case 3:
                        ExibirProximoCliente(fila);
                        break;
                    case 4:
                        ListarClientes(fila);
                        break;
                    case 5:
                        continuar = false;
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 5.");
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("\n=== GERENCIAMENTO DA FILA ===");
            Console.WriteLine("1 - Adicionar cliente");
            Console.WriteLine("2 - Atender cliente");
            Console.WriteLine("3 - Consultar próximo cliente");
            Console.WriteLine("4 - Listar clientes");
            Console.WriteLine("5 - Sair");
        }

        private static void AdicionarCliente(SimpleQueue<Cliente> fila)
        {
            string nome = LerTexto("Nome: ");
            string formaPagamento = LerTexto("Forma de pagamento: ");
            float valorTotal = LerValorTotal();

            fila.Enqueue(new Cliente(nome, formaPagamento, valorTotal));
            Console.WriteLine("Cliente adicionado à fila.");
        }

        private static void AtenderCliente(SimpleQueue<Cliente> fila)
        {
            try
            {
                Cliente cliente = fila.Dequeue();
                Console.WriteLine("Cliente atendido:");
                ExibirCliente(cliente);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ExibirProximoCliente(SimpleQueue<Cliente> fila)
        {
            try
            {
                Console.WriteLine("Próximo cliente:");
                ExibirCliente(fila.Peek());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListarClientes(SimpleQueue<Cliente> fila)
        {
            if (fila.EstaVazia)
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("\n=== CLIENTES NA FILA ===");
            foreach (Cliente cliente in fila.Listar())
            {
                ExibirCliente(cliente);
            }
        }

        private static void ExibirCliente(Cliente cliente)
        {
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Forma de pagamento: {cliente.FormaPagamento}");
            Console.WriteLine($"Valor total: R$ {cliente.ValorTotal:F2}\n");
        }

        private static string LerTexto(string mensagem)
        {
            while (true)
            {
                Console.Write(mensagem);
                string? valor = Console.ReadLine()?.Trim();

                if (!string.IsNullOrWhiteSpace(valor))
                {
                    return valor;
                }

                Console.WriteLine("Este campo não pode ficar vazio.");
            }
        }

        private static float LerValorTotal()
        {
            while (true)
            {
                Console.Write("Valor total: R$ ");

                if (float.TryParse(Console.ReadLine(), out float valorTotal) && valorTotal >= 0)
                {
                    return valorTotal;
                }

                Console.WriteLine("Digite um valor numérico igual ou maior que zero.");
            }
        }
    }
}