// Escreva um programa que pergunte um número ao usuário e mostre sua tabuada completa de 1 a 10.

#include <stdio.h>

int main()
{

    int i = 1, n, r;

    printf("DIGITE UM NUMERO DE 1 A 10 PARA SABER SUA TABUADA: ");
    scanf("%d", &n);

    while(i <= 10)
    {
        r = n * i;
        printf("%d * %d = %d \n", n, i, r);
        i++;
    }

}