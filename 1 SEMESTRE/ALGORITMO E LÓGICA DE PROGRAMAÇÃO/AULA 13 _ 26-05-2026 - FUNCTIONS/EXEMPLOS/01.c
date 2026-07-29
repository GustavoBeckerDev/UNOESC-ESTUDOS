#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int quadrado (int a)
{
    return (a*a);
}

int main()
{
    int num = 0;
    printf("Digite um numero inteiro: ");
    scanf("%d", &num);

    printf("\n");

    num = quadrado(num);
    
    printf("Quadrado do numero digitado: %d \n", num);
    return 0;
}