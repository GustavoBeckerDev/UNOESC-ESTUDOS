// Encontre a posição (índice) do menor valor em um vetor de 15 floats.

#include <stdio.h>

int main()
{

    float vetor[15];
    float menor = 1000000.0;   
    int i = 0;
    int indiceMenor = 0;

    for (i=0; i<15; i++)
    {
        printf("Digite um valor para o vetor: ");
        scanf("%f", &vetor[i]);

        if (vetor[i] < menor)
        {
            indiceMenor = i;
            menor = vetor[i];
        }
    }

    printf("O indice do menor valor e: %d\n", indiceMenor);

    printf("O menor valor do vetor que esta no indice %d e: %.2f", indiceMenor, menor);

}