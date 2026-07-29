// 2. Dadas às notas dos alunos de uma turma, informe a média da turma.

#include <stdio.h>

int main()
{
    float media, nota;
    int i, alunos;

    printf("DIGITE AS NOTAS DOS ALUNOS DE UMA TURMA !!!\n");

    printf("Quantos alunos tem na turma? \n");
    scanf("%d", &alunos);

    for(i=1; i <= alunos; i++)
    {
        printf("DIGITE A %d NOTA: ", i);
        scanf("%f", &nota);

        media += nota;
    }
    
    media /= alunos;
    
    printf("A MEDIA E: %f", media);

}