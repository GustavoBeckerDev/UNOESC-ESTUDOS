// Declare um vetor de 10 inteiros, leia valores com for e exiba a soma de todos.

#include <stdio.h>

int main()
{
    int valor[10];
    int i = 0;
    int soma = 0;

    for (i=0; i<10; i++)
    {
        printf("Digite um valor para o vetor: ");
        scanf("%d", &valor[i]);

        soma += valor[i];
    }

    printf("A soma dos valores digitados e: %d", soma);

}