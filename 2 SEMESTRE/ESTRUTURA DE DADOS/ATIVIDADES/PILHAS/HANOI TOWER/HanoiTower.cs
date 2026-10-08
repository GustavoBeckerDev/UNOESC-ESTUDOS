// O namespace agrupa as classes do projeto. Como Program.cs usa o mesmo
// namespace, as duas classes se enxergam sem precisar de "using".
namespace TorreHanoi
{

    // ESTA CLASSE CONTÉM APENAS A LÓGICA DO JOGO.
    // Ela não escreve nada na tela. Quem desenha é o Program.cs.
    // Essa separação permite trocar a visualização sem mexer no algoritmo.
    public class HanoiTower
    {
        // Quantidade total de discos do jogo.
        // "private set" significa: qualquer um pode LER, mas só esta
        // classe pode ALTERAR. Isso protege o valor contra mudanças externas.
        public int DiscsCount { get; private set; }

        // Contador de movimentos já realizados.
        // Começa em 0 automaticamente, pois int não inicializado vale 0.
        public int MovesCount { get; private set; }

        // AS TRÊS HASTES DO JOGO. Cada haste é uma pilha (Stack).
        // A pilha foi escolhida porque obedece a mesma regra do jogo:
        // só é possível mexer no disco que está no TOPO.
        // O "int" guardado é o TAMANHO do disco (1 = menor disco).

        // Haste de origem: onde todos os discos começam.
        public Stack<int> From { get; private set; }

        // Haste de destino: onde todos os discos devem terminar.
        public Stack<int> To { get; private set; }

        // Haste auxiliar: usada como apoio temporário durante o processo.
        public Stack<int> Auxiliary { get; private set; }

        // EVENTO disparado toda vez que um disco é movido.
        // Funciona como um "aviso": a classe avisa que algo aconteceu,
        // sem saber quem está ouvindo. O Program.cs se inscreve nesse
        // evento para redesenhar a tela a cada movimento.
        public event EventHandler<EventArgs> MoveCompleted;

        // CONSTRUTOR: executado uma única vez, no "new HanoiTower(...)".
        // Recebe a quantidade de discos e prepara o estado inicial do jogo.
        public HanoiTower (int discs)
        {
            // Guarda a quantidade de discos para consulta posterior.
            DiscsCount = discs;

            // Cria as três pilhas vazias. Sem o "new", elas seriam null
            // e qualquer Push ou Pop causaria erro.
            From = new Stack<int> ();
            To = new Stack<int> ();
            Auxiliary = new Stack<int> ();

            // FAZ A CARGA DA PILHA FROM COM OS DISCOS

            // O laço repete uma vez para cada disco: i vai de 1 até discs.
            for(int i = 1; i <= discs; i++)
            {
                // Converte o contador crescente em tamanho decrescente.
                // Exemplo com 3 discos:
                //   i = 1  ->  size = 3 - 1 + 1 = 3  (maior disco)
                //   i = 2  ->  size = 3 - 2 + 1 = 2
                //   i = 3  ->  size = 3 - 3 + 1 = 1  (menor disco)
                int size = discs - i + 1;

                // Empilha o disco. Como o maior entra primeiro, ele fica
                // na BASE. O menor entra por último e fica no TOPO.
                From.Push(size);
            }
        }

        // Ponto de partida do algoritmo. Existe para que quem usa a classe
        // não precise conhecer os parâmetros do método Move.
        public void Start()
        {
            // Pede para mover TODOS os discos, de From para To,
            // usando Auxiliary como apoio.
            Move(DiscsCount, From, To, Auxiliary);
            // AQUI UTILIZA PASCAL CASE POIS UTILIZAMOS
            // NO PARAMETRO DO METODO
            // Ou seja: From, To e Auxiliary (maiúsculo) são as pilhas
            // reais da classe. Já from, to e auxiliary (minúsculo) são
            // os parâmetros do método Move, que mudam a cada chamada.
        }

        // O ALGORITMO EM SI. É um método RECURSIVO: ele chama a si mesmo.
        //
        // Parâmetros:
        //   discs     = quantos discos esta chamada precisa mover
        //   from      = de onde os discos saem NESTA chamada
        //   to        = para onde os discos vão NESTA chamada
        //   auxiliary = haste de apoio NESTA chamada
        //

        public void Move(
            int discs,
            Stack<int> from,
            Stack<int> to,
            Stack<int> auxiliary
            )
        {
            // CASO BASE da recursão. Se não há disco para mover (discs = 0),
            // o método não faz nada e retorna. Sem esse "if", as chamadas
            // nunca parariam e o programa quebraria.
            if (discs > 0)
            {
                // PASSO 1: tirar do caminho os discos que estão em cima.
                // Move os (discs - 1) discos menores de "from" para
                // "auxiliary". Repare na troca de papéis: nesta chamada
                // o destino é a auxiliar, e o apoio passa a ser o "to".
                Move(discs - 1, from, auxiliary, to);

                // PASSO 2: mover o maior disco desta chamada.
                // Pop() remove e devolve o disco do topo de "from".
                // Push() coloca esse disco no topo de "to".
                // Neste momento o disco está livre, pois o passo 1
                // retirou tudo que estava sobre ele.
                to.Push (from.Pop());

                // Registra que mais um movimento foi feito.
                MovesCount++;

                // Dispara o evento para avisar que houve movimento.
                // O "?." evita erro caso ninguém esteja inscrito no evento.
                // "this" informa QUEM disparou (este objeto HanoiTower).
                // "EventArgs.Empty" indica que não há dados extras.
                MoveCompleted?.Invoke(this, EventArgs.Empty);

                // PASSO 3: trazer de volta os discos menores.
                // Move os (discs - 1) discos que ficaram em "auxiliary"
                // para "to", em cima do disco maior. Agora a origem é a
                // auxiliar, e o apoio passa a ser o "from", que está livre.
                Move(discs - 1, auxiliary, to, from);
            }
        }
    }
}
