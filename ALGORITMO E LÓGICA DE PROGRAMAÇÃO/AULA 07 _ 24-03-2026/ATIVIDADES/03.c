// 3. Dadas às idades dos pacientes de uma clínica, informe a idade daquele mais
// idoso. Considere que todas as idades são distintas e que o número de pacientes é
// informado pelo usuário, no momento da execução do programa.

#include <stdio.h>

int main()
{
    
    int pacientes, idade, i, maioridade;

    printf("QUANTOS PACIENTES TEM NA CLINICA: \t");
    scanf("%d", &pacientes);

    for(i=1; i <= pacientes; i++)
    {
        printf("DIGITE A SUA IDADE: ");
        scanf("%d", &idade);

        if (idade > maioridade){
            maioridade = idade;
        }
    }

    printf("A MAIOR IDADE E: %d", maioridade);

}