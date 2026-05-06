#include <stdio.h>

int main()
{

    int b[5];
    int i = 0;

    printf("Digite o valor 0: ");
    scanf("%d", &b[0]);

    printf("Digite o valor 1: ");
    scanf("%d", &b[1]);

    printf("Digite o valor 2: ");
    scanf("%d", &b[2]);

    printf("Digite o valor 3: ");
    scanf("%d", &b[3]);

    printf("Digite o valor 4: ");
    scanf("%d", &b[4]);

    for(i=0; i<5; i++)
    {
        printf("POSICAO %d: %d\n", i, b[i]);
    }

}