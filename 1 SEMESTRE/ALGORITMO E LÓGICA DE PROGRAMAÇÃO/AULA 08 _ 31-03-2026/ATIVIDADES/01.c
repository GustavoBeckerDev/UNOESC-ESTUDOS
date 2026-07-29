// Utilizando o laço while, elabore um algoritmo que mostre quais números são ímpares, quando se é percorrida a lista de 1 a 100.

#include <stdio.h>

int main()
{

    int i = 1;

    while (i <= 100)
    {

        if (i % 2 == 1)
        {
            printf("%d e um numero impar. \n", i);
        }

        i++;
    }

}