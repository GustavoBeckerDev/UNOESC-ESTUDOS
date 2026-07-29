// 7. Leia 10 números e informe quantos são positivos, quantos são negativos e
// quantos são iguais a zero.

#include <stdio.h>

int main()
{

    int totposi = 0, totneg = 0, totz = 0, i = 0, n = 0;

    for(i=1; i <=3; i++)
    {
        printf("DIGITE UM NUMERO: \n");
        scanf("%d", &n);

        if (n < 0)
        {
            totneg++;
        }
        else 
        {
            if (n > 0)
            {
                totposi++;
            }
            else
            {
                totz++;
            }
        }
    }

    printf("O TOTAL DE NUMEROS POSITIVOS SAO: %d \n", totposi);
    printf("O TOTAL DE NUMEROS NEGATIVOS SAO: %d \n", totneg);
    printf("O TOTAL DE NUMEROS IGUAIS A ZERO SAO: %d \n", totz);

}