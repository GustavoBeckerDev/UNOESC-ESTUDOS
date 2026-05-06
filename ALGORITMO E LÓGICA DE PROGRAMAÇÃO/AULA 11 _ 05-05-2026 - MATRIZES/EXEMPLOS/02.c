#include <stdio.h>

int main()
{

    int i = 0, j = 0;
    int A[3][4];

    for(i = 0; i < 3; i++) // percorre as LINHAS
    {

        for(j = 0; j < 4; j++) // percorre as COLUNAS
        {
            printf("A [%d] [%d] = %d\n", i, j, A[i][j]);
        }

    }
    
}