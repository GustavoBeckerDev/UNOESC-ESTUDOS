#include <stdio.h>

int main()
{

    int i, vetorA[15], vetorB[15];

    for(i=0; i<15; i++)
    {
        printf("Digite um valor: ");
        scanf("%d", &vetorA[i]);

        if(vetorA[i] % 2 == 0)
        {
            vetorB[i] = vetorA[i] * 5;
        }    
        else
        {
            vetorB[i] = vetorA[i] + 5;
        }
    }

    for(i=0; i<15; i++)
    {
        printf("B[%d]=%d\n", i, vetorB[i]);
    }
}