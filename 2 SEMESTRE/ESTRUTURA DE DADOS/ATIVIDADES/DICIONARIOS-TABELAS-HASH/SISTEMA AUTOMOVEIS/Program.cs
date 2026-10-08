namespace Consectionary
{
    internal class Program
    {
        private static void Main()
        {

            Dictionary<string, Car> cars = new Dictionary<string, Car>()
            {
                {"MFS5B59", new Car("")}    
            };

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

                // 1 - Cadastrar automóvel
                // 2 - Buscar automóvel pela placa
                // 3 - Listar todos os automóveis
                // 4 - Buscar automóveis por marca
                // 5 - Sair

                switch (opcao)
                {
                    
                }
            }
        }

        private static void ExibirMenu()
        {
            Console.WriteLine("\n=== ESCOLHA A AÇÃO A REALIZAR ===");
            Console.WriteLine("1 - CADASTRAR AUTOMÓVEL");
            Console.WriteLine("2 - Atender cliente");
            Console.WriteLine("3 - Consultar próximo cliente");
            Console.WriteLine("4 - Listar clientes");
            Console.WriteLine("5 - Sair");
        }
            
    }
}
