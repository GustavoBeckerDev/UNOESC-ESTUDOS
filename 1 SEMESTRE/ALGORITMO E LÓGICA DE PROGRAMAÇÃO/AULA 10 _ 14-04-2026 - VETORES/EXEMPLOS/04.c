#include <stdio.h>

int main()
{
    float notas[10];
    float media=0;
    int i=0;

    for (i=0; i<10; i++)
    {
        printf("Nota do aluno %d: ", i+1);
        scanf("%f", &notas[i]);
        media += notas[i];
    }

    media  = media / 10;
    printf("Media: %.2f\n", media);

}