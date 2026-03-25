// 1. Crie um algoritmo que imprima todos os números pares do intervalo 1-10.

#include <stdio.h>

int main()
{
    int i;

    for (i = 1; i <= 10; i++)
    {
        if (i % 2 == 0)
        {
            printf("%d...", i, "\n");
        }
    }

}