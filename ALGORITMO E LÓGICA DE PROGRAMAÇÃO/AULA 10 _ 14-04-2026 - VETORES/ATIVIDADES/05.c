// Leia 10 números. Inverta a ordem dos elementos e exiba o vetor invertido

#include <stdio.h>

int main()
{

    int valores[10];
    int i = 0;

    for (i=0; i<10; i++)
    {
        printf("Digite o %d numero: ", i+1);
        scanf("%d", &valores[i]);
    }

    for (i=9; i>=0; i--)
    {
        printf("%d \t", valores[i]);
    }

}