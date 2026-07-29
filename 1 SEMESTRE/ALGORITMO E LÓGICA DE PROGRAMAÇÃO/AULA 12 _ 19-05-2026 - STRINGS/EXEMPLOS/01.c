// AULA DE STRINGS (VETORES DE CARACTERES)

// \0 PARA SABER QUE É O FIM DA PALAVRA

#include <stdio.h>
#include <string.h>

int main()
{

    char nome[50];
    printf("Digite o seu nome: ");
    // scanf("%f", nome);
    fgets(nome, 50, stdin);

    printf("Seu nome e: %s", nome);
    
    return 0;

}