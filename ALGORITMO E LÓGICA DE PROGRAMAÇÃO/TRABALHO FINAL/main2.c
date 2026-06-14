#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// AQUI IREI DEFINIR A ESTRUTURA DO MEU LIVRO (CODIGO, TITULO, CATEGORIA, QUANTIDADE)

struct Livro
{
    int codigo;
    char titulo[100];
    char categoria[50];
    int quantidade;
};

#define LIMITE_LIVROS 100
#define LIMITE_ALUGADOS 100

struct Livro biblioteca[LIMITE_LIVROS] = 
{
    {187, "PHP", "Programacao", 10},
    {254, "MYSQL MARIA DB", "Banco de Dados", 5},
    {344, "HTML5", "Desenvolvimento Web", 10},
    {447, "CSS3", "Desenvolvimento Web", 5},
    {569, "JAVASCIRPT", "Desenvolvimento Web", 10},
    {656, "JAVA POO", "Programacao", 5},
    {778, "DATA SCIENCE", "Ciencia de Dados", 10},
    {878, "UI UX", "Desenvolvimento Web", 10},
    {978, "PYTHON", "Programacao", 10},
    {1014, "IA DATA SCIENCE", "Ciencia de Dados", 5}
};

// STRUCT DE ALUGADOS PARA GUARDAR OS LIVROS QUE FORAM ALUGADOS, 
// PARA DEPOIS CONSEGUIR CONTROLAR MELHOR A QUANTIDADE DE LIVROS DISPONIVEIS NA BIBLIOTECA, 
// E TAMBEM PARA TER UM REGISTRO DE QUAIS LIVROS FORAM ALUGADOS

struct Livro alugados[LIMITE_ALUGADOS];

int totalLivros = 10;
int totalAlugados = 0;

int menu();
void cadastrarLivro();
void alugarLivro();
void devolverLivro();
void listarLivro();
void buscarLivro();
void alterarLivro();
void removerLivro();
void executarMenu();
void estatisticas();
int helperBuscaPorCod(int codigo);
int helperBuscaPorCodAlugados(int codigo);

// DECLARANDO VARIAVEIS DE ESTATISTICAS DO SISTEMA

int livrosCadastrados = 0;
int livrosRemovidos = 0;
int livrosAlterados = 0;
int livrosAlugados = 0;
int livrosDevolvidos = 0;

int main()
{
    executarMenu();
    return 0;
}

// MENU PRINCIPAL PARA O USUARIO ESCOLHER A OPÇÃO CORRESPONDENTE A AÇÃO DESEJADA

int menu()
{

    int op;

    printf("\n~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~--~-~- \n");
    printf("\n~-~-~-~-~-~- BIBLIOTECA TI ~-~-~-~-~-~- \n");
    printf("\n~-~-~-~-~-~-~-~-~-~-~-~-~-~-~-~--~-~-~- \n");
    printf("\n\n");
    printf("1- CADASTRAR LIVRO \n");
    printf("2- ALUGAR LIVRO \n");
    printf("3- DEVOLVER LIVRO \n");
    printf("4- LISTAR LIVROS \n");
    printf("5- BUSCAR LIVRO POR CODIGO \n");
    printf("6- ALTERAR LIVRO  (MODIFICAR TITULO, CATEGORIA E QUANTIDADE) \n");
    printf("7- REMOVER LIVRO DA BIBLIOTECA \n");
    printf("8- ESTATÍSTICAS GERAIS DO SISTEMA \n");
    printf("9- SAIR DA BIBLIOTECA \n");

    printf("\n O QUE DESEJA FAZER HOJE? \n");
    scanf("%d", &op);

    return op;
}

void executarMenu()
{

    int op;

    do
    {
        op = menu();

        switch(op)
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
                listarLivro();
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
            case 9:
                printf("\n ATE A PROXIMA GARFANHOTO !!!\n");
                break;
            default:
                printf("OPCAO INVALIDA, TENTE NOVAMENTE !!!\n");
                break;
                
        }

    } while(op != 9);


}

// ESSA FUNÇÃO É UM HELPER PARA UTILIZAR NAS DEMAIS FUNCOES, ONDE EU COMPARO O CODIGO DIGITADO PELA PESSOA
// COM O CODIGO REAL DE CADA LIVRO, PARA ENCONTRAR O INDICE EXATO DO LIVRO NO VETOR BIBLIOTACA

int helperBuscaPorCod(int codigo)
{
    for(int i = 0; i < totalLivros; i++)
    {

        if (biblioteca[i].codigo == codigo)
        {
            return i;
        }

    }
    return -1; // RETORNA -1 SE O CODIGO NAO FOR ENCONTRADO, PARA TRATAR O ERRO NAS FUNCOES QUE USAM ESSE HELPER
}

// O MESMO PARA BUSCAR O CODIGO NA TABELA DE ALUGADOS, PARA UTILZIAR NA HORA DE DEVOLVER

int helperBuscarPorCodAlugados(int codigo)
{
    for (int i = 0; i < totalAlugados; i++)
    {
        if (alugados[i].codigo == codigo)
        {
            return i;
        }
    }
    return -1;
}

// INICIANDO AS FUNÇÕES REAIS DO SWITCH CASE, UMA POR UMA.

//FUNÇÃO DE CRIAR/CADASTRAR UM LIVRO: 

void cadastrarLivro()
{
    int codigo;
    char titulo[100];
    char categoria[50];
    int quantidade;

    printf("\n");

    if (totalLivros >= LIMITE_LIVROS)
    {
        printf("\nA BIBLIOTECA ESTA CHEIA NO MOMENTO, TENTE NOVAMENTE MAIS TARDE !!!\n");
        return;
    }

    printf("\n========================================\n\n");
    printf("CADASTRO GERAL DE LIVROS DA BIBLIOTECA: ");
    printf("\n========================================\n\n");
    
    printf("DIGITE O CODIGO DO LIVRO: \n");
    scanf("%d", &codigo);
    
    if(helperBuscaPorCod(codigo) != -1)
    {
        printf("CODIGO JA CADASTRADO!\n");
        return;
    }
    biblioteca[totalLivros].codigo = codigo;

    printf("DIGITE O TITULO DO LIVRO: \n");
    scanf(" %[^\n]", titulo);
    strcpy(biblioteca[totalLivros].titulo, titulo);

    printf("DIGITE A CATEGORIA DO LIVRO: \n");
    scanf(" %[^\n]", categoria);
    strcpy(biblioteca[totalLivros].categoria, categoria);

    printf("DIGITE QUANTOS LIVROS SERÃO ADICIONADOS: \n");
    scanf("%d", &quantidade);

    if (quantidade <= 0)
    {
        printf("QUANTIDADE INVALIDA, TENTE NOVAMENTE !!!\n");
        return;
    }
    biblioteca[totalLivros].quantidade = quantidade;

    printf("\n OBRIGADO GARFANHOTO, LIVRO CADASTRADO, TMJ !!! \n");
    
    totalLivros++;
    livrosCadastrados++;

}

void listarLivro()
{
    printf("\n\nLISTA COMPLETA DE LIVROS GARFANHOTO !!!\n\n");
    printf("========================================\n");

    printf("TOTAL DE TITULOS CADASTRADOS: %d", totalLivros);
    printf("\n========================================\n\n");

    for (int i = 0; i < totalLivros; i++)
    {
        printf("|| CODIGO: %d\n", biblioteca[i].codigo);
        printf("|| TITULO: %s\n", biblioteca[i].titulo);
        printf("|| CATEGORIA: %s\n", biblioteca[i].categoria);
        printf("|| QUANTIDADE: %d\n", biblioteca[i].quantidade);
        printf("\n\n====================================================\n\n");
    }
};

 
void alugarLivro()
{
    int codigo;
    listarLivro();

    printf("\n=========================================================\n\n");
    printf("SEJA BEM VINDO A SEÇÃO DE LOCAÇÃO DE LIVROS GARFANHOTO !!!");
    printf("\n=========================================================\n\n");

    printf("\nDIGITE O CODIGO DO LIVRO QUE DESEJA ALUGAR: ");
    scanf("%d", &codigo);

    int indice = helperBuscaPorCod(codigo);

    if (indice == -1) // NÃO EXISTE INDICE -1 NUM VETOR, ENTAO ISSO É UM RETORNO NEGATIVO/NAO ENCONTRADO DA BUSCA DA FUNCAO
    {
        printf("CODIGO NAO ENCONTRADO, TENTE NOVAMENTE !!!\n");
        return;
    }

    if (biblioteca[indice].quantidade <= 0)
    {
        printf("LIVRO INDISPONIVEL NO MOMENTO, VOLTE DEPOIS GARFANHOTO !!!\n");
        return;
    }

    biblioteca[indice].quantidade--;
    
    alugados[totalAlugados] = biblioteca[indice];
    alugados[totalAlugados].quantidade = 1;
    totalAlugados++;
    livrosAlugados++;

    printf("\n\nTÍTULO %s ALUGADO COM SUCESSO !!! \n\n", biblioteca[indice].titulo);
    printf("\n\nRESTARAM %d LIVROS DO TITULO %s DISPONÍVELS.\n\n", biblioteca[indice].quantidade, biblioteca[indice].titulo);
}

void devolverLivro()
{
    int codigo;

    printf("\n\n DEVOLUÇÃO DE LIVROS ALUGADOS !!!\n\n");

    printf("\nDIGITE O CODIGO DO LIVRO QUE DESEJA DEVOLVER: ");
    scanf("%d", &codigo);

    int indiceAlugado = helperBuscarPorCodAlugados(codigo);

    if(indiceAlugado == -1)
    {
        printf("\nLIVRO NAO ENCONTRADO NOS ALUGADOS!\n");
        return;
    }

    int indiceBiblioteca = helperBuscaPorCod(codigo);

    if(indiceBiblioteca == -1)
    {
        printf("\nERRO INTERNO: LIVRO NAO EXISTE NA BIBLIOTECA.\n");
        return;
    }

    biblioteca[indiceBiblioteca].quantidade++;

    alugados[indiceAlugado].quantidade--;

    if(alugados[indiceAlugado].quantidade == 0)
    {
        for(int i = indiceAlugado; i < totalAlugados - 1; i++)
        {
            alugados[i] = alugados[i + 1];
        }

        totalAlugados--;
    }

    livrosDevolvidos++;

    printf("\nLIVRO \"%s\" DEVOLVIDO COM SUCESSO!\n", biblioteca[indiceBiblioteca].titulo);
}

void buscarLivro()
{
    int indice;
    int codigo;

    printf("\n\nDIGITE O CODIGO DO LIVRO QUE DESEJA BUSCAR: ");
    scanf("%d", &codigo);

    indice = helperBuscaPorCod(codigo);

    if (indice == -1)
    {
        printf("\n\n CODIGO NAO ENCONTRADO !!!\n\n");
    }

    printf("\n\n LIVRO ENCONTRADO, SEGUE DADOS DO LIVRO: \n\n");

    printf("\n\n========================================");
    printf("\n\nCODIGO: %d", codigo);
    printf("\n\nTITULO: %s", biblioteca[indice].titulo);
    printf("\n\nCATEGORIA: %s", biblioteca[indice].categoria);
    printf("\n\nQUANTIDADE: %d", biblioteca[indice].quantidade);
    printf("\n\n========================================\n\n");

}


void alterarLivro()
{
    int codigo;
    int indice;
    int houveAlteracao = 0;

    char opcao;

    printf("\nDIGITE O CODIGO DO LIVRO QUE DESEJA ALTERAR: ");
    scanf("%d", &codigo);

    indice = helperBuscaPorCod(codigo);

    if(indice == -1)
    {
        printf("\nCODIGO NAO ENCONTRADO!\n");
        return;
    }

    printf("\n===========================================\n");
    printf("============ LIVRO ENCONTRADO =============\n");
    printf("===========================================\n");

    printf("CODIGO: %d\n", biblioteca[indice].codigo);
    printf("TITULO: %s\n", biblioteca[indice].titulo);
    printf("CATEGORIA: %s\n", biblioteca[indice].categoria);
    printf("QUANTIDADE: %d\n", biblioteca[indice].quantidade);

    printf("\nDESEJA ALTERAR O CODIGO? (S/N): ");
    scanf(" %c", &opcao);

    if(opcao == 'S' || opcao == 's')
    {
        int novoCodigo;

        printf("DIGITE O NOVO CODIGO: ");
        scanf("%d", &novoCodigo);

        if(helperBuscaPorCod(novoCodigo) != -1)
        {
            printf("CODIGO JA EXISTE! ALTERACAO CANCELADA.\n");
        }
        else
        {
            biblioteca[indice].codigo = novoCodigo;
            houveAlteracao = 1;
            printf("CODIGO ALTERADO COM SUCESSO!\n");
        }
    }

    printf("\nDESEJA ALTERAR O TITULO? (S/N): ");
    scanf(" %c", &opcao);

    if(opcao == 'S' || opcao == 's')
    {
        char novoTitulo[100];

        printf("DIGITE O NOVO TITULO: ");
        scanf(" %[^\n]", novoTitulo);

        strcpy(biblioteca[indice].titulo, novoTitulo);

        houveAlteracao = 1;

        printf("TITULO ALTERADO COM SUCESSO!\n");
    }

    printf("\nDESEJA ALTERAR A CATEGORIA? (S/N): ");
    scanf(" %c", &opcao);

    if(opcao == 'S' || opcao == 's')
    {
        char novaCategoria[50];

        printf("DIGITE A NOVA CATEGORIA: ");
        scanf(" %[^\n]", novaCategoria);

        strcpy(biblioteca[indice].categoria, novaCategoria);

        houveAlteracao = 1;

        printf("CATEGORIA ALTERADA COM SUCESSO!\n");
    }

    printf("\nDESEJA ALTERAR A QUANTIDADE? (S/N): ");
    scanf(" %c", &opcao);

    if(opcao == 'S' || opcao == 's')
    {
        int novaQuantidade;

        printf("DIGITE A NOVA QUANTIDADE: ");
        scanf("%d", &novaQuantidade);

        if(novaQuantidade < 0)
        {
            printf("QUANTIDADE INVALIDA!\n");
        }
        else
        {
            biblioteca[indice].quantidade = novaQuantidade;

            houveAlteracao = 1;

            printf("QUANTIDADE ALTERADA COM SUCESSO!\n");
        }
    }

    if(houveAlteracao)
    {
        livrosAlterados++;
    }

    printf("\n===========================================\n");
    printf("DADOS FINAIS DO LIVRO\n");
    printf("===========================================\n");

    printf("CODIGO: %d\n", biblioteca[indice].codigo);
    printf("TITULO: %s\n", biblioteca[indice].titulo);
    printf("CATEGORIA: %s\n", biblioteca[indice].categoria);
    printf("QUANTIDADE: %d\n", biblioteca[indice].quantidade);

    printf("\nALTERACAO CONCLUIDA!\n");
}

void removerLivro()
{
    int codigo;
    int indiceBiblioteca;
    int indiceAlugado;
    char confirmar;

    printf("\nDIGITE O CODIGO DO LIVRO QUE DESEJA REMOVER: ");
    scanf("%d", &codigo);

    indiceBiblioteca = helperBuscaPorCod(codigo);

    if(indiceBiblioteca == -1)
    {
        printf("\nCODIGO NAO ENCONTRADO!\n");
        return;
    }

    indiceAlugado = helperBuscarPorCodAlugados(codigo);

    if(indiceAlugado != -1)
    {
        printf("\n=================================================\n");
        printf("NAO E POSSIVEL REMOVER ESTE LIVRO!\n");
        printf("EXISTEM EXEMPLARES ALUGADOS DESTE TITULO.\n");
        printf("AGUARDE A DEVOLUCAO DE TODOS OS EXEMPLARES.\n");
        printf("=================================================\n");
        return;
    }

    printf("\nLIVRO ENCONTRADO:\n");
    printf("CODIGO: %d\n", biblioteca[indiceBiblioteca].codigo);
    printf("TITULO: %s\n", biblioteca[indiceBiblioteca].titulo);
    printf("CATEGORIA: %s\n", biblioteca[indiceBiblioteca].categoria);
    printf("QUANTIDADE: %d\n", biblioteca[indiceBiblioteca].quantidade);

    printf("\nTEM CERTEZA QUE DESEJA REMOVER? (S/N): ");
    scanf(" %c", &confirmar);

    if(confirmar != 'S' && confirmar != 's')
    {
        printf("\nOPERACAO CANCELADA!\n");
        return;
    }

    for(int i = indiceBiblioteca; i < totalLivros - 1; i++)
    {
        biblioteca[i] = biblioteca[i + 1];
    }

    totalLivros--;
    livrosRemovidos++;

    printf("\nLIVRO REMOVIDO COM SUCESSO !!!\n");
}

void estatisticas()
{
    int totalExemplares = 0;

    for(int i = 0; i < totalLivros; i++)
    {
        totalExemplares += biblioteca[i].quantidade;
    }

    printf("\n");
    printf("=========================================\n");
    printf("      ESTATISTICAS DO SISTEMA\n");
    printf("=========================================\n");

    printf("TOTAL DE TITULOS CADASTRADOS: %d\n", totalLivros);

    printf("TOTAL DE EXEMPLARES DISPONIVEIS: %d\n", totalExemplares);

    printf("LIVROS ATUALMENTE ALUGADOS: %d\n", totalAlugados);

    printf("LIVROS CADASTRADOS DURANTE A EXECUCAO: %d\n", livrosCadastrados);

    printf("LIVROS REMOVIDOS DURANTE A EXECUCAO: %d\n", livrosRemovidos);

    printf("ALTERACOES REALIZADAS: %d\n", livrosAlterados);

    printf("TOTAL DE ALUGUEIS REALIZADOS: %d\n", livrosAlugados);

    printf("TOTAL DE DEVOLUCOES REALIZADAS: %d\n", livrosDevolvidos);

    printf("=========================================\n");
}