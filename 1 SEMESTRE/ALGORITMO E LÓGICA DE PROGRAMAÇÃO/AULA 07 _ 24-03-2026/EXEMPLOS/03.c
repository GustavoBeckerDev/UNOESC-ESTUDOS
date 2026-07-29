#include <stdio.h>

int main()
{
    int i, n;
    float media=0, nota;

    printf("Quantos alunos tem na turma: \n");
    scanf("%d", &n);

    for(i=1; i <= n; i++)
    {
        printf("Nota do aluno %d: ", i);
        scanf("%f", &nota);

        media += nota;
    }

    media = media / n;

    printf("Media: %.2f \n", media);

}