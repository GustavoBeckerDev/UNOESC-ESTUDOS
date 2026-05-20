// Crie um algoritmo que leia os elementos de uma matriz e 4x4 
// e escreva os elementos da diagonal principal.

#include <stdio.h>

int main()
{

    int i = 0; int j = 0; float mat[4][4];

    printf("PREENCHA OS CAMPOS PARA AS MATRIZES: \n\n");

    // PEGANDO OS VALORES PARA A MATRIZ 4x4

    for (i = 0; i < 4; i++)
    {
        for (j = 0; j < 4 ; j++)
        {
            printf("DIGITE UM NUMERO PARA A MATRIZ NO INDICE [%d] [%d] : ", i, j);
            scanf("%f", &mat[i][j]);
        }
    }

    printf("MOSTRANDO OS ELEMENTOS DA DIAGONAL PRINCIPAL: \n");

    for (i = 0; i < 4; i++)
    {
        for (j = 0; j < 4 ; j++)
        {
            if (i == j)
            {
                printf("| %.2f |", mat[i][j]);
            }
        }
        printf("\n");
    }

}