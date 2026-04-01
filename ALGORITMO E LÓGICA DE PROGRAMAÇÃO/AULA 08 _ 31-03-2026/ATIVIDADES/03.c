// Ache o primeiro número, entre 1 e 1 milhão que é divisível por 11, por 13 e por 17 dê o resto da divisão nulo.

#include <stdio.h>

int main()
{

    int i = 1;

    while (i <= 1000000)
    {

        if (i % 11 == 0 &&  i % 13 == 0 && i % 17 == 0)
        {
            printf("ACHAMOS O NUMERO DIVIDIVEL POR 11, 13 E 17 COM RESTO 0 \n");
            printf("O NUMERO E: %d", i);
            break;
        }

        i++;
    }

}