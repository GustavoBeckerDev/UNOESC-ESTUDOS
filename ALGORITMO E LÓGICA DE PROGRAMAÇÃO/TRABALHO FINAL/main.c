#include <stdio.h>
#include <string.h>

#define MAX_LIVROS 100

/* ESTRUTURA */

struct Livro
{
    int codigo;
    char titulo[100];
    char categoria[50];
    int quantidade;
};

/* VARIAVEIS GLOBAIS */

struct Livro biblioteca[MAX_LIVROS];
int totalLivros = 0;

/* PROTOTIPOS */

int menu();

void executarMenu();

void cadastrarLivro();
void listarLivros();
void buscarLivro();
void alterarLivro();
void removerLivro();
void alugarLivro();
void devolverLivro();
void estatisticas();

int encontrarLivroPorCodigo(int codigo);

/* MENU */

int menu()
{
    int opcao;

    printf("\n====================================");
    printf("\n       BIBLIOTECA UNOESC");
    printf("\n====================================");
    printf("\n1 - Cadastrar Livro");
    printf("\n2 - Alugar Livro");
    printf("\n3 - Devolver Livro");
    printf("\n4 - Listar Acervo");
    printf("\n5 - Buscar Livro");
    printf("\n6 - Alterar Livro");
    printf("\n7 - Remover Livro");
    printf("\n8 - Estatisticas");
    printf("\n9 - Sair");
    printf("\n\nEscolha uma opcao: ");

    scanf("%d", &opcao);

    return opcao;
}

void executarMenu()
{
    int opcao;

    do
    {
        opcao = menu();

        switch(opcao)
        {
            case 1:
                cadastrarLivro();
                break;

            case 2:
                alugarLivro();
                break;

            case 3:
                devolverLivro();
                break;

            case 4:
                listarLivros();
                break;

            case 5:
                buscarLivro();
                break;

            case 6:
                alterarLivro();
                break;

            case 7:
                removerLivro();
                break;

            case 8:
                estatisticas();
                break;
            case 9:
                printf("\nEncerrando sistema...\n");
                break;

            default:
                printf("\nOpcao invalida!\n");
                break;
        }

    } while(opcao != 8);
}

/* FUNCOES AUXILIARES */

int encontrarLivroPorCodigo(int codigo)
{
    int i;

    for(i = 0; i < totalLivros; i++)
    {
        if(biblioteca[i].codigo == codigo)
        {
            return i;
        }
    }

    return -1;
}

/* CADASTRAR LIVRO */

void cadastrarLivro()
{
    if(totalLivros >= MAX_LIVROS)
    {
        printf("\nBiblioteca cheia!\n");
        return;
    }

    printf("\n=== CADASTRO DE LIVRO ===\n");

    printf("Codigo: ");
    scanf("%d", &biblioteca[totalLivros].codigo);

    getchar();

    printf("Titulo: ");
    fgets(biblioteca[totalLivros].titulo,
          sizeof(biblioteca[totalLivros].titulo),
          stdin);

    biblioteca[totalLivros].titulo[
        strcspn(biblioteca[totalLivros].titulo, "\n")
    ] = '\0';

    printf("Categoria: ");
    fgets(biblioteca[totalLivros].categoria,
          sizeof(biblioteca[totalLivros].categoria),
          stdin);

    biblioteca[totalLivros].categoria[
        strcspn(biblioteca[totalLivros].categoria, "\n")
    ] = '\0';

    printf("Quantidade: ");
    scanf("%d", &biblioteca[totalLivros].quantidade);

    totalLivros++;

    printf("\nLivro cadastrado com sucesso!\n");
}

/* LISTAR LIVROS */

void listarLivros()
{
    int i;

    if(totalLivros == 0)
    {
        printf("\nNenhum livro cadastrado.\n");
        return;
    }

    printf("\n=== ACERVO DA BIBLIOTECA ===\n");

    for(i = 0; i < totalLivros; i++)
    {
        printf("\nCodigo: %d", biblioteca[i].codigo);
        printf("\nTitulo: %s", biblioteca[i].titulo);
        printf("\nCategoria: %s", biblioteca[i].categoria);
        printf("\nQuantidade: %d", biblioteca[i].quantidade);
        printf("\n-----------------------------\n");
    }
}

/* BUSCAR LIVRO */

void buscarLivro()
{
    int codigo;
    int indice;

    printf("\nDigite o codigo do livro: ");
    scanf("%d", &codigo);

    indice = encontrarLivroPorCodigo(codigo);

    if(indice == -1)
    {
        printf("\nLivro nao encontrado.\n");
        return;
    }

    printf("\n=== LIVRO ENCONTRADO ===\n");
    printf("Codigo: %d\n", biblioteca[indice].codigo);
    printf("Titulo: %s\n", biblioteca[indice].titulo);
    printf("Categoria: %s\n", biblioteca[indice].categoria);
    printf("Quantidade: %d\n", biblioteca[indice].quantidade);
}

/* ALTERAR LIVRO */

void alterarLivro()
{
    int codigo;
    int indice;

    printf("\nCodigo do livro: ");
    scanf("%d", &codigo);

    indice = encontrarLivroPorCodigo(codigo);

    if(indice == -1)
    {
        printf("\nLivro nao encontrado.\n");
        return;
    }

    getchar();

    printf("Novo titulo: ");
    fgets(biblioteca[indice].titulo,
          sizeof(biblioteca[indice].titulo),
          stdin);

    biblioteca[indice].titulo[
        strcspn(biblioteca[indice].titulo, "\n")
    ] = '\0';

    printf("Nova categoria: ");
    fgets(biblioteca[indice].categoria,
          sizeof(biblioteca[indice].categoria),
          stdin);

    biblioteca[indice].categoria[
        strcspn(biblioteca[indice].categoria, "\n")
    ] = '\0';

    printf("Nova quantidade: ");
    scanf("%d", &biblioteca[indice].quantidade);

    printf("\nLivro alterado com sucesso!\n");
}

/* REMOVER LIVRO */

void removerLivro()
{
    int codigo;
    int indice;
    int i;

    printf("\nCodigo do livro a remover: ");
    scanf("%d", &codigo);

    indice = encontrarLivroPorCodigo(codigo);

    if(indice == -1)
    {
        printf("\nLivro nao encontrado.\n");
        return;
    }

    for(i = indice; i < totalLivros - 1; i++)
    {
        biblioteca[i] = biblioteca[i + 1];
    }

    totalLivros--;

    printf("\nLivro removido com sucesso!\n");
}

/* ALUGAR LIVRO */

void alugarLivro()
{
    int codigo;
    int indice;

    printf("\nCodigo do livro para aluguel: ");
    scanf("%d", &codigo);

    indice = encontrarLivroPorCodigo(codigo);

    if(indice == -1)
    {
        printf("\nLivro nao encontrado.\n");
        return;
    }

    if(biblioteca[indice].quantidade <= 0)
    {
        printf("\nNao existem exemplares disponiveis.\n");
        return;
    }

    biblioteca[indice].quantidade--;

    printf("\nLivro alugado com sucesso!\n");
}

void devolverLivro()
{
    int codigo;
    int indice;

    printf("\nCodigo do livro devolvido: ");
    scanf("%d", &codigo);

    indice = encontrarLivroPorCodigo(codigo);

    if(indice == -1)
    {
        printf("\nLivro nao encontrado.\n");
        return;
    }

    biblioteca[indice].quantidade++;

    printf("\nLivro devolvido com sucesso!\n");
}


void estatisticas()
{
    int i;
    int totalExemplares = 0;
    int maiorIndice = 0;

    if(totalLivros == 0)
    {
        printf("\nNao existem livros cadastrados.\n");
        return;
    }

    for(i = 0; i < totalLivros; i++)
    {
        totalExemplares += biblioteca[i].quantidade;

        if(biblioteca[i].quantidade >
           biblioteca[maiorIndice].quantidade)
        {
            maiorIndice = i;
        }
    }

    printf("\n=== ESTATISTICAS ===\n");
    printf("Total de titulos cadastrados: %d\n", totalLivros);
    printf("Total de exemplares: %d\n", totalExemplares);

    printf("Livro com maior estoque: %s\n",
           biblioteca[maiorIndice].titulo);

    printf("Categoria: %s\n",
           biblioteca[maiorIndice].categoria);

    printf("Quantidade em estoque: %d\n",
           biblioteca[maiorIndice].quantidade);
}

/* MAIN */

int main()
{
    executarMenu();

    return 0;
}