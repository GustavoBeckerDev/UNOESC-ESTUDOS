// 6. Crie um algoritmo que leia um número inteiro e exiba a tabuada completa desse número (de 1 a 10).

#include <stdio.h>

int main()
{
    int n, r, i;

    printf("DIGITE UM NUMERO PARA SABER A SUA TABUADA: ");
    scanf("%d", &n);

    for (i=1; i<=10; i++)
    {
        r = n * i;
        printf("%d * %d = %d \n", n, i, r);
    }

}