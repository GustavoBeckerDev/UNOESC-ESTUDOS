#include <stdio.h>

int main()
{
    int vetor[10];
    int i = 0;
    int maior = -1000000;

    for(i=0; i<10; i++)
    {
        printf("Valor %d: ", i+1);
        scanf("%d", &vetor[i]);

        if (vetor[i] > maior)
        {
            maior = vetor[i];
        }
    }
        printf("Maior valor: %d", maior);
}
