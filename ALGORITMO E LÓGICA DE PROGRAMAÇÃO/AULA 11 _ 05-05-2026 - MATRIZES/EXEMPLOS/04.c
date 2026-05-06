#include <stdio.h>
#include <conio.h>

int main() 
{
    int i, j;
    float mat[4][4];

    for(i=0; i<4; i++)
    {
        for(j=0; j<4; j++)
        {
            mat[i][j] = i * j;
        }
    }
    
    for(i=0; i<4; i++)  // Imprime toda a matriz
    { 
        for(j=0; j<4; j++)
        {
            printf("| %0.2f | ", mat[i][j]);
            printf("\a"); // Emite um som de bipe
        }
            printf("\n");
    }
    
    for(i=0; i<4; i++) 
    {
        // Diagonal principal: somente quando i==j
        for(j=0; j<4; j++)
        {
            if(i == j)
                printf("| %.2f | ", mat[i][j]);
                printf("\a"); // Emite um som de bipe
        }     
    }

    getch();
}
