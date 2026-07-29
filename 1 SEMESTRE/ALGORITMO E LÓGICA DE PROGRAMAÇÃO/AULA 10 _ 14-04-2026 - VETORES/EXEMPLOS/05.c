// Ler idades de 40 alunos, contar e exibir os maiores de 18:

#include <stdio.h>

int main()
{
    int i = 0;
    int contador = 0;
    int idade[4];

    for(i = 0; i < 4; i++)
    {
        printf("Digite a sua idade: ");
        scanf("%d", &idade[i]);

        if (idade[i] >= 18)
        {
            contador++;
        }

    }

    printf("Ha um total de %d alunos com idade igual ou maior a 18 anos. \n", contador);

    for (i = 0; i < 4; i++)
    {

        if (idade[i] >= 18)
        {
            printf("O aluno %d: %d anos \n", i, idade[i]);
        }

    }

}
