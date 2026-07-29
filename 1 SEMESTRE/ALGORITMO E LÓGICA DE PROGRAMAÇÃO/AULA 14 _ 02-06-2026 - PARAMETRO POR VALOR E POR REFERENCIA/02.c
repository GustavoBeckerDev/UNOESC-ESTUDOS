// PONTEIROS EM C

#include <stdio.h>

void alterar(int *x, int *y, int *z)
{

    printf("VALORES RECEBIDOS NA FUNCAO: %d, %d, %d\n", *x, *y, *z);
    printf("\n");

    (*x)++; (*y)++; (*z)++;

    printf("VALORES ALTERADOS APOS A FUNCAO: %d, %d, %d\n", *x, *y, *z);
    printf("\n");

}


int main()
{

    int a = 1, b = 2, c = 3;

    printf("\nVALORES INICIAS ANTES DA CHAMADA DA FUNCAO: %d, %d, %d\n", a, b, c);
    printf("\n");

    alterar(&a, &b, &c); // AQUI ESTOU PASSANDO OS ENDEREÇOS, LEVANDO NAO APENAS OS VALORES DAS VARIAVEIS, E SIM O ENDEREÇO DELA

    printf("VALORES FINAIS APOS A FUNCAO: %d, %d, %d\n", a, b, c); // FORAM RETORNADOS POR CONTA DO PONTEIRO, A FUNCAO ACESSOU OS VALORES ORIGINAIS
    printf("\n");

}

// & PASSA O ENDEREÇO E * É O PONTEIRO QUE É PASSADO (ENDEREÇO)