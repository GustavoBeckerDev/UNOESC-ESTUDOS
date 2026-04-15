// Crie dois vetores de tamanho 10. Some elemento a elemento e guarde e um 3º vetor.

#include <stdio.h>

int main()
{
    int vetorA[10];
    int vetorB[10];
    int vetorC[10];
    int i = 0;

    for (i=0; i<10; i++)
    {
        printf("Digite o %d valor para o vetor A: ",i+1);
        scanf("%d", &vetorA[i]);
    }

    printf("===========================================\n");

    for (i=0; i<10; i++)
    {
        printf("Digite o %d valor para o vetor B: ",i+1);
        scanf("%d", &vetorB[i]);

        vetorC[i] = vetorA[i] + vetorB[i];
    }

    printf("===========================================\n");

    printf("Segue valores do terceiro vetor: \n");

    for (i=0; i<10; i++)
    {
        printf("%i valor: %d \n", i+1, vetorC[i]);
    }
    









}
