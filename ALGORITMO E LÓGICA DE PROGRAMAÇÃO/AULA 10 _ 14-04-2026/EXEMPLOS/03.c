#include <stdio.h>

int main()
{

    int b[5], i;

    for (i=0; i<5; i++)
    {
        printf("Valor %d: ", i+1);
        scanf("%d", &b[i]);
    }

    printf("\n");
    printf("==============================================\n");
    printf("\n");

    for(i=0; i<5; i++)
    {
        printf("Posicao %d: %d\n", i, b[i]);
    }

}