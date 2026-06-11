#include <stdio.h>
#include <string.h>
#include <conio.h>

// AQUI IREI DEFINIR A ESTRUTURA DO MEU LIVRO (CODIGO, TITULO, CATEGORIA, QUANTIDADE)

struct Livro
{
    int codigo;
    char titulo[100];
    char categoria[50];
    int quantidade;
};

#define LIMITE_LIVROS 100

struct Livro biblioteca[LIMITE_LIVROS] = 
{
    {1, "PHP", "Programacao", 10},
    {2, "MYSQL MARIA DB", "Banco de Dados", 5},
    {3, "HTML5", "Desenvolvimento Web", 10},
    {4, "CSS3", "Desenvolvimento Web", 5},
    {5, "JAVASCIRPT", "Desenvolvimento Web", 10},
    {6, "JAVA POO", "Programacao", 5},
    {7, "DATA SCIENCE", "Ciencia de Dados", 10},
    {8, "UI UX", "Desenvolvimento Web", 10},
    {9, "PYTHON", "Programacao", 10},
    {10, "IA DATA SCIENCE", "Ciencia de Dados", 5}
};


int totalLivros = 10;


int cadastrarLivro();
void alugarLivro();
void devolverLivro();
void listarLivro();
void buscarLivro();
void alterarLivro();
void removerLivro();
void executarMenu();

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
    printf("8- SAIR DA BIBLIOTECA \n");

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
                printf("\n ATE A PROXIMA GARFANHOTO !!!\n");
                break;
            default:
                printf("OPCAO INVALIDA, TENTE NOVAMENTE !!!\n");
                break;
                
        }

    } while(op != 8);


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
}

// INICIANDO AS FUNÇÕES REAIS DO SWITCH CASE, UMA POR UMA.

//FUNÇÃO DE CRIAR/CADASTRAR UM LIVRO: 

int cadastrarLivro()
{
    int codigo;
    char titulo[100];
    char categoria[50];
    int quantidade;

    printf("\n");

    if (totalLivros >= LIMITE_LIVROS)
    {
        printf("\nA BIBLIOTECA ESTA CHEIA NO MOMENTO, TENTE NOVAMENTE MAIS TARDE !!!\n");
        return -1;
    }

    

    printf("DIGITE O TITULO DO LIVRO: \n");
    scanf("%s", titulo);
    strcpy(biblioteca[totalLivros].titulo, titulo);

    printf("DIGITE A CATEGORIA DO LIVRO: \n");
    scanf("%s", categoria);
    strcpy(biblioteca[totalLivros].categoria, categoria);

    printf("DIGITE QUANTOS LIVROS SERÃO ADICIONADOS: \n");
    scanf("%d", &quantidade);
    biblioteca[totalLivros].quantidade = quantidade;

    printf("\n OBRIGADO GARFANHOTO, LIVRO CADASTRADO, TMJ !!! \n");
    
    codigo = totalLivros + 1;
    totalLivros++;

    return 0;

}

void listarLivro()
{
    printf("\n\nLISTA COMPLETA DE LIVROS GARFANHOTO !!!\n\n");
    printf("========================================\n");


    for (int i = 0; i < totalLivros; i++)
    {
        printf("|| CODIGO: %d\n", biblioteca[i].codigo);
        printf("|| TITULO: %s\n", biblioteca[i].titulo);
        printf("|| CATEGORIA: %s\n", biblioteca[i].categoria);
        printf("|| QUANTIDADE: %d\n", biblioteca[i].quantidade);
        printf("========================================\n\n");

    }

};


void alugarLivro()
{
    printf("BOA");
};
void devolverLivro()
{
    printf("BOA");
};
void buscarLivro()
{
    printf("BOA");
};
void alterarLivro()
{
    printf("BOA");
};
void removerLivro()
{
    printf("BOA");
};