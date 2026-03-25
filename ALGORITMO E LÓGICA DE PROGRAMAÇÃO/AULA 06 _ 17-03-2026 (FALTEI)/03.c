#include <stdio.h>

// 3. Dada a idade de um nadador, informe a sua categoria: infantil (até 10 anos),
// juvenil (até 17 anos) ou sênior (acima de 17 anos).

int main()
{
    int idade = 0;

    printf("Informe a sua idade para saber a categoria em que se enquadra: ");
    scanf("%d", &idade);

    if (idade <=10)
    {
        printf("SUA CATEGORIA E INFANTIL!!! \n");
    } 
    else 
    {
        if (idade <= 17)
        {
            printf("SUA CATEGORIA E JUVENIL!!! \n");
        } else {
            printf("SUA CATEGORIA E SENIOR!!! \n");
        }
    }

}