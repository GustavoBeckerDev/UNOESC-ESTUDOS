// Entrar  com  valores  para  a matriz  A[3][4].  
// Gerar e imprimir uma matriz B com o triplo da matriz A.

#include <stdio.h>

int main()
{

    int i = 0; int j = 0; float mat1[3][4]; float matTrip[3][4];

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 4; j++)
        {
            printf("DIGITE UM VALOR PARA A POSICAO [%d][%d] DA MATRIZ: ", i, j);
            scanf("%f", &mat1[i][j]);
        }
    }

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 4; j++)
        {
            matTrip[i][j] = mat1[i][j] * 3;
        }
    }

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 4; j++)
        {
            printf("| %.2f |", matTrip[i][j]);
        }
    }

}