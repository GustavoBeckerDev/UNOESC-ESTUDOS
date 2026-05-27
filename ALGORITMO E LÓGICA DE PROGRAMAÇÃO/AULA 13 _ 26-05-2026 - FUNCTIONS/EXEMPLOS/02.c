#include <stdio.h>
#include <stdbool.h>

int ehPar(int b)
{
    if (b % 2)
        return 0; // VERDADEIRO -> PAR
    else   
        return 1; // FALSO -> IMPAR
}

int main()
{
    int num;

    printf("Digite um numero para saber se ele e par ou impar: ");
    scanf("%d", &num);

    if (ehPar(num))
        printf("E par. \n");
    else
        printf("E impar. \n");   

    return 0;
}