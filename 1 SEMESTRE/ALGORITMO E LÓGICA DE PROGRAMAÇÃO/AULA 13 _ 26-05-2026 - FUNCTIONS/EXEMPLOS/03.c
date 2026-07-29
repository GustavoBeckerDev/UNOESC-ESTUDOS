#include <stdio.h>
#include <stdlib.h>

int quadrado(int a);

int main()
{
    int num;

    printf("Digite um numero: ");
    scanf("%d", &num);

    num = quadrado(num);

    printf("Quadrado: %d\n", num);

    return 0;
}

int quadrado(int a)
{   
    return (a * a);
}