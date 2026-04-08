// SWITCH PARA INTEIROS E CARACTERES
// COMPARAR IGUALDADE
// NÃO TEM EXPRESSÃO LÓGICA
// MELHOR LEGIBILIDADE

#include <stdio.h>

int main()
{

    int op = 0;

    printf("Escolha uma opcao: (1, 2 ou qualquer outro): ");
    scanf("%d", &op);

    switch (op)
    {
        case 1:
            printf("OPCAO 1\n");
            break;
        case 2:
            printf("OPCAO 2\n");
            break;
        default:
            printf("A OPCAO ESCOLHIDA FOI DIFERENTE DAS ESPERADAS.\n");
    }



}