namespace Consectionary
{
    internal class Program
    {
        private static void Main()
        {
            
            Dictionary<string, Car> cars = new Dictionary<string, Car>(StringComparer.OrdinalIgnoreCase)
            {
                {"MFS5B59",
                new Car("MFS5B59", "Chevrolet", "Onix", "Onix Plus", 2020, 80000.00f)},
                {"MFS5B60",
                new Car("MFS5B60", "Chevrolet", "Onix", "Onix Hatch", 2021, 85000.00f)},
                {"MFS5B61",
                new Car("MFS5B61", "Toyota", "Corolla", "Corolla XEI", 2022, 120000.00f)},
                {"MFS5B62",
                new Car("MFS5B62", "Toyota", "Yaris", "Yaris Sedan", 2021, 95000.00f)},
                {"MFS5B63",
                new Car("MFS5B63", "Honda", "Civic", "Civic EX", 2020, 110000.00f)},
                {"MFS5B64",
                new Car("MFS5B64", "Honda", "Fit", "Fit LX", 2021, 90000.00f)},
                {"MFS5B65",
                new Car("MFS5B65", "Ford", "Ka", "Ka SE", 2020, 70000.00f)},
                {"MFS5B66",
                new Car("MFS5B66", "Ford", "EcoSport", "EcoSport XLT", 2021, 100000.00f)}
            };

            bool continuar = true;

            while (continuar)
            {
                ExibirMenu();
                Console.Write("Escolha uma opção: ");

                string? entrada = Console.ReadLine();

                // ReadLine retorna null quando a entrada termina (Ctrl+D / Ctrl+Z)
                if (entrada == null)
                {
                    Sair(ref continuar);
                    break;
                }

                if (!int.TryParse(entrada, out int opcao))
                {
                    Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarAutomovel(cars);
                        break;
                    case 2:
                        BuscarAutomovelPorPlaca(cars);
                        break;
                    case 3:
                        ListarTodosAutomoveis(cars);
                        break;
                    case 4:
                        BuscarAutomoveisPorMarca(cars);
                        break;
                    case 5:
                        RemoverAutomovel(cars);
                        break;
                    case 6:
                        Sair(ref continuar);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                        break;
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("\n=== ESCOLHA A AÇÃO A REALIZAR ===");
            Console.WriteLine("1 - CADASTRAR AUTOMÓVEL");
            Console.WriteLine("2 - BUSCAR AUTOMÓVEL PELA PLACA");
            Console.WriteLine("3 - LISTAR TODOS AUTOMÓVEIS");
            Console.WriteLine("4 - BUSCAR AUTOMÓVEIS POR MARCA");
            Console.WriteLine("5 - REMOVER AUTOMÓVEL");
            Console.WriteLine("6 - SAIR");
        }

        // Lê uma linha e nunca devolve null: trata fim de entrada e remove espaços
        private static string LerTexto(string mensagem)
        {
            Console.Write(mensagem);
            return (Console.ReadLine() ?? string.Empty).Trim();
        }

        private static void ExibirAutomovel(Car car)
        {
            Console.WriteLine($"Placa: {car.Placa}, Marca: {car.Marca}, Modelo: {car.Modelo}, Nome: {car.Nome}, Ano: {car.Ano}, Preço: {car.Valor:C}");
        }

        private static void CadastrarAutomovel(Dictionary<string, Car> cars)
        {
            Console.WriteLine("\n=== CADASTRAR AUTOMÓVEL ===");
            string placa = LerTexto("Digite a placa do automóvel: ").ToUpper();

            if (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Placa inválida.");
                return;
            }

            if (cars.ContainsKey(placa))
            {
                Console.WriteLine("Automóvel já cadastrado.");
                return;
            }

            string marca = LerTexto("Digite a marca do automóvel: ");
            string modelo = LerTexto("Digite o modelo do automóvel: ");
            string nome = LerTexto("Digite o nome do automóvel: ");

            if (!int.TryParse(LerTexto("Digite o ano do automóvel: "), out int ano))
            {
                Console.WriteLine("Ano inválido.");
                return;
            }

            if (!float.TryParse(LerTexto("Digite o preço do automóvel: "), out float preco))
            {
                Console.WriteLine("Preço inválido.");
                return;
            }

            cars[placa] = new Car(placa, marca, modelo, nome, ano, preco);
            Console.WriteLine("Automóvel cadastrado com sucesso.");
        }

        private static void BuscarAutomovelPorPlaca(Dictionary<string, Car> cars)
        {
            Console.WriteLine("\n=== BUSCAR AUTOMÓVEL PELA PLACA ===");
            string placa = LerTexto("Digite a placa do automóvel: ");

            if (cars.TryGetValue(placa, out Car? car))
            {
                Console.WriteLine($"Placa: {car.Placa}");
                Console.WriteLine($"Marca: {car.Marca}");
                Console.WriteLine($"Modelo: {car.Modelo}");
                Console.WriteLine($"Nome: {car.Nome}");
                Console.WriteLine($"Ano: {car.Ano}");
                Console.WriteLine($"Preço: {car.Valor:C}");
            }
            else
            {
                Console.WriteLine("Automóvel não encontrado.");
            }
        }

        private static void ListarTodosAutomoveis(Dictionary<string, Car> cars)
        {
            Console.WriteLine("\n=== LISTAR TODOS AUTOMÓVEIS ===");
            if (cars.Count == 0)
            {
                Console.WriteLine("Nenhum automóvel cadastrado.");
                return;
            }

            foreach (var car in cars.Values)
            {
                ExibirAutomovel(car);
            }
        }

        private static void BuscarAutomoveisPorMarca(Dictionary<string, Car> cars)
        {
            Console.WriteLine("\n=== BUSCAR AUTOMÓVEIS POR MARCA ===");
            string marca = LerTexto("Digite a marca do automóvel: ");

            var automoveisEncontrados = cars.Values
                .Where(car => string.Equals(car.Marca, marca, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (automoveisEncontrados.Count == 0)
            {
                Console.WriteLine("Nenhum automóvel encontrado para a marca informada.");
                return;
            }

            foreach (var car in automoveisEncontrados)
            {
                ExibirAutomovel(car);
            }
        }

        private static void RemoverAutomovel(Dictionary<string, Car> cars)
        {
            Console.WriteLine("\n=== REMOVER AUTOMÓVEL ===");
            string placa = LerTexto("Digite a placa do automóvel a ser removido: ");

            if (cars.Remove(placa))
            {
                Console.WriteLine("Automóvel removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Automóvel não encontrado.");
            }
        }

        private static void Sair(ref bool continuar)
        {
            Console.WriteLine("Saindo do programa...");
            continuar = false;
        }
    }
}
