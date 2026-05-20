// Fazer  um  algoritmo  que  leia  uma  matriz  5x5  com  números  inteiros,  após  troque  os 
// elementos  desta  até  obter  a  sua  transposta  (exemplo  matriz  m  x  n  ficaria  n  x  m)  e 
// escreva a matriz obtida.

#include <stdio.h>

int main()
{

    int i = 0; int j = 0; float matNormal[5][5]; float matTransp[5][5];

    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 5; j++)
        {
            printf("DIGITE UM VALOR PARA A POSICAO [%d][%d] DA MATRIZ: ", i, j);
            scanf("%f", &matNormal[i][j]);
        }
    }

    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 5; j++)
        {
            matTransp[j][i] = matNormal[j][i];
        }
    }

    for (i = 0; i < 5; i++)
    {
        for (j = 0; j < 5; j++)
        {
            printf("|%.2f|", matTransp[i][j]);
        }
    }

}