// Importa as coleções genéricas, como a Stack<T> usada neste arquivo.
using System.Collections.Generic;

// Mesmo namespace do HanoiTower.cs, para as classes se enxergarem.
namespace TorreHanoi
{
        // ESTA CLASSE CUIDA APENAS DA TELA.
        // Ela cria o jogo, escuta os movimentos e desenha as hastes.
        public class Program
        {
<<<<<<< HEAD
        private const int DISCS_COUNT = 10;
        private const int DELAY_MS = 25;
=======
        // Quantidade de discos do jogo. É "const" porque não muda
        // durante a execução. Altere aqui para testar com 3, 4, etc.
        private const int DISCS_COUNT = 3;

        // Tempo de espera entre movimentos, em milissegundos.
        // Não é mais usado, pois a pausa agora é feita por tecla.
        private const int DELAY_MS = 250;

        // Largura, em casas, reservada para cada haste na tela.
        // Não é "const" porque é recalculada no Main conforme os discos.
        // É "static" porque pertence à classe, e não a um objeto.
>>>>>>> 70d422395014372d48831463d647e7dbc1ab2de8
        private static int _columnSize = 30;

        // Ponto de entrada: é o primeiro método executado pelo programa.
        public static void Main(string[] args)
        {
            // Calcula a largura de cada coluna com base no maior disco.
            // GetDiscWidth(DISCS_COUNT) dá a largura do maior disco.
            // Multiplica por 2 para sobrar espaço entre as hastes.
            // Math.Max garante no mínimo 6 casas, para caber o título.
            _columnSize = Math.Max(6, GetDiscWidth(DISCS_COUNT) * 2);

            // Cria o jogo. O construtor já empilha os discos em From.
            HanoiTower algorithm = new HanoiTower(DISCS_COUNT);

            // Inscreve o método Algorithm_Visualize no evento.
            // A partir daqui, toda vez que um disco for movido,
            // o método Algorithm_Visualize será chamado automaticamente.
            // O "+=" significa "adicionar mais um ouvinte ao evento".
            algorithm.MoveCompleted += Algorithm_Visualize; //DELEGATE

            // Chama o desenho uma vez manualmente, para mostrar o estado
            // inicial do jogo antes de qualquer movimento acontecer.
            Algorithm_Visualize(algorithm, EventArgs.Empty);

            // Inicia o algoritmo. Todos os movimentos acontecem aqui dentro.
            algorithm.Start();
        }

        // Desenha a tela inteira. É chamado a cada movimento pelo evento.
        // "sender" é quem disparou o evento (o objeto HanoiTower).
        // "e" traria dados extras do evento, mas aqui vem vazio.
        private static void Algorithm_Visualize(object sender, EventArgs e)
        {
            // Apaga a tela para desenhar o novo estado por cima.
            Console.Clear();

            // O evento entrega o sender como "object" genérico.
            // A conversão (cast) devolve o tipo real, para podermos
            // acessar From, To, Auxiliary, MovesCount, etc.
            HanoiTower algorithm = (HanoiTower) sender;

            // Proteção: sem discos não há o que desenhar.
            // O "return" encerra o método imediatamente.
            if (algorithm.DiscsCount <= 0)
            {
                return;
            }

            // Cria a "folha em branco": uma matriz preenchida com espaços,
            // onde os discos serão desenhados antes de irem para a tela.
            string[][] visualization = InitializeVisualization(algorithm);

            // Desenha cada pilha na sua coluna da matriz.
            // O segundo parâmetro é a posição na tela: 1, 2 ou 3.
            // A ordem segue a do título: FROM, TO, AUXILIARY.
            PrepareColumn(visualization, 1, algorithm.DiscsCount, algorithm.From);
            PrepareColumn(visualization, 2, algorithm.DiscsCount, algorithm.To);
            PrepareColumn(visualization, 3, algorithm.DiscsCount, algorithm.Auxiliary);

            // Escreve o título das três colunas, cada um centralizado
            // dentro da largura da sua coluna.
            Console.WriteLine(
                Center("FROM") + Center ("TO") + Center ("AUXILIARY"));

            // Envia a matriz pronta para a tela, linha por linha.
            DrawVisualization(visualization);

            // Linha em branco para separar o desenho das informações.
            Console.WriteLine();

            // Interpolação de string
            // O "$" permite colocar variáveis dentro do texto, entre chaves.
            Console.WriteLine($"Nro de movimentos: {algorithm.MovesCount}");

            // Write não pula linha no final, diferente do WriteLine.
            Console.Write($"Nro de discos: {algorithm.DiscsCount}");

            // Este WriteLine vazio termina a linha deixada pelo Write acima.
            Console.WriteLine();
            Console.WriteLine("Pressione uma tecla para o próximo movimento...");

            // Pausa o programa até uma tecla ser pressionada.
            // O "true" impede que a tecla digitada apareça na tela.
            // Como este método roda DENTRO do Move (via evento), a pausa
            // aqui congela o algoritmo inteiro até você apertar a tecla.
            Console.ReadKey(true);

        }

        // Desenha UMA pilha dentro da matriz.
        //   visualization = a matriz onde desenhar
        //   column        = posição da haste na tela (1, 2 ou 3)
        //   discsCount    = total de discos do jogo (define a altura)
        //   stack         = a pilha que será desenhada
        private static void PrepareColumn(
            string[][] visualization,
            int column,
            int discsCount,
            Stack<int> stack
        )
        {
            // Casa onde esta coluna começa na horizontal.
            // Coluna 1 -> margem 0. Coluna 2 -> pula uma largura.
            // Coluna 3 -> pula duas larguras.
            int margin = _columnSize * (column - 1);

            // Percorre cada disco da pilha. y = 0 é o disco do TOPO.
            // Este laço apenas LÊ a pilha, sem remover nenhum disco.
            for (int y = 0; y < stack.Count; y++)
            {
                // Lê o tamanho do disco na posição y, sem tirá-lo da pilha.
                // ElementAt(0) é o topo, ElementAt(1) é o de baixo, etc.
                int size = stack.ElementAt(y);

                // Calcula em qual LINHA da tela o disco aparece.
                // A pilha precisa ficar apoiada no chão (última linha).
                // Exemplo: 5 discos no jogo e 3 discos nesta pilha:
                //   y = 0 (topo)  ->  5 - (3 - 0) = linha 2
                //   y = 1         ->  5 - (3 - 1) = linha 3
                //   y = 2 (base)  ->  5 - (3 - 2) = linha 4 (chão)
                int row = discsCount - (stack.Count - y);

                // Casa onde o disco COMEÇA na horizontal.
                // Quanto maior o disco, mais à esquerda ele começa.
                // É isso que centraliza os discos e forma a pirâmide.
                int columnStart = margin + discsCount - size;

                // Casa onde o disco TERMINA na horizontal.
                int columnEnd = columnStart + GetDiscWidth(size);

                // Preenche as casas do disco, do início ao fim.
                // Como o laço usa "<=", são preenchidas 2 * size casas.
                for (int x = columnStart; x <= columnEnd; x++)
                {
                    // Verifica se a posição DENTRO do disco é par.
                    // O "%" devolve o resto da divisão. Resto 0 = par.
                    bool even = (x - columnStart) % 2 == 0;

                    // O emoji ocupa DUAS casas de largura na tela.
                    // Por isso: casa par recebe o emoji, e casa ímpar
                    // recebe texto vazio, já que o emoji invadiu o espaço.
                    // Resultado: disco de tamanho N mostra N emojis.
                    // O "? :" é o operador ternário, um if/else resumido.
                    // Usamos string e não char porque o emoji não cabe
                    // em um único char.
                    visualization[row][x] = even ? "🍺": "";
                }
            }
        }

        // Envia a matriz para a tela.
        private static void DrawVisualization(string[][] visualization)
        {
            // Percorre as linhas de cima para baixo.
            // visualization.Length é a quantidade de linhas.
            for (int y = 0; y < visualization.Length; y++)
            {
                // string.Concat junta todas as casas da linha em um
                // texto só. Sem ele, seria impresso "System.String[]".
                Console.WriteLine(string.Concat(visualization[y]));
            }
        }

        // Centraliza um texto dentro da largura de uma coluna.
        private static string Center(string text)
        {
            // Espaço que sobra na coluna, dividido por 2.
            // Esse é o tamanho do espaço à esquerda do texto.
            int margin = (_columnSize - text.Length) / 2;

            // PadLeft coloca espaços à ESQUERDA até atingir o tamanho.
            // PadRight completa com espaços à DIREITA até a largura
            // total da coluna, para o próximo título começar alinhado.
            return text.PadLeft(margin + text.Length)
                       .PadRight(_columnSize);
        }

        // Cria a matriz em branco usada como área de desenho.
        // É um "jagged array": um vetor onde cada posição é outro vetor.
        // O primeiro índice é a linha, o segundo é a casa na horizontal.
        private static string[][] InitializeVisualization(HanoiTower algorithm)
        {
            // Cria as linhas. A altura é igual ao número de discos,
            // pois no pior caso todos estão empilhados na mesma haste.
            // Neste ponto cada linha ainda está vazia (null).
            string[][] visualization = new string[algorithm.DiscsCount][];

            // Percorre cada linha para criá-la e preenchê-la.
            for (int y = 0; y < visualization.Length; y++)
            {
                // Cria a linha com largura para as 3 colunas da tela.
                visualization[y] = new string[_columnSize * 3];

                // Preenche cada casa com um espaço em branco.
                // Sem isso as casas seriam null e nada apareceria alinhado.
                for (int x = 0; x < _columnSize * 3; x++)
                {
                    visualization[y][x] = " ";
                }

            }

            // Devolve a matriz pronta para receber os discos.
            return visualization;
        }

        // Calcula a largura de um disco a partir do seu tamanho.
        // A fórmula 2 * size - 1 gera sempre números ímpares:
        //   tamanho 1 -> 1,  tamanho 2 -> 3,  tamanho 3 -> 5
        // Assim cada disco cresce uma casa para cada lado.
        private static int GetDiscWidth(int size)
        {
            return 2 * size - 1;
        }
    }
}
