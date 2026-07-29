#include <stdio.h>
#include <conio.h>

int main() 
{

    int i, j;
    float mat[3][4], soma=0, media=0;

    for(i=0; i<3; i++) 
    {
        for(j=0; j<4; j++) 
        {
            mat[i][j] = i * j; // atribui i×j
        }
    }

    for(i=0; i<3; i++) 
    {
        for(j=0; j<4; j++) 
        {
            soma += mat[i][j]; // acumula soma
        }
    }

    printf("%d", soma);

    media = soma / (i * j);
    
    printf("media: %f", media);

    getch();

}

