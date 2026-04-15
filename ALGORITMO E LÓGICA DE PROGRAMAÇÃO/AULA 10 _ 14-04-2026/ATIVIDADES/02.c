// Leia 20 notas de alunos e exiba quantos foram aprovados (nota ≥ 7) e a média.

#include <stdio.h>

int main()
{
    int nota[20];
    int i = 0;
    int soma = 0;
    int media = 0;
    int aprovados = 0;

    for (i=0; i<20; i++)
    {

        printf("Digite a sua nota:  ");
        scanf("%d", &nota[i]);

        if (nota[i] >= 7)
        {
            aprovados++;
        }

        soma += nota[i];
        media = soma / 20;

    }

    printf("Houve um total de %d alunos aprovados.\n", aprovados);

    printf("A media de todas as notas foi: %d\n", media);

}