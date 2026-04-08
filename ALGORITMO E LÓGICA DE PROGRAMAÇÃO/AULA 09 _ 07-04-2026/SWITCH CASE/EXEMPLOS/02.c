// SWITCH PARA INTEIROS E CARACTERES
// COMPARAR IGUALDADE
// NÃO TEM EXPRESSÃO LÓGICA
// MELHOR LEGIBILIDADE

#include <stdio.h>

int main()
{

    int semana = 0;

    printf("=== ESCOLHA UM NUMERO QUE REPRESENTE UM DIA DA SEMANA ===\n");

    printf("Escolha de 1 a 7:  ");
    scanf("%d", &semana);

    if (semana < 1)
    {
        printf("O NUMERO DIGITADO DEVE SER ENTRE 1 E 7 \n");
    }
    else
    {

        switch (semana)
        {
            case 1:
                printf("DOMINGO\n");
                break;
            case 2:
                printf("SEGUNDA\n");
                break;
            case 3:
                printf("TERCA\n");
                break;
            case 4:
                printf("QUARTA\n");
                break;
            case 5:
                printf("QUINTA\n");
                break;
            case 6:
                printf("SEXTA\n");
                break;
            case 7:
                printf("SABADO\n");
                break;
            default:
                printf("O NUMERO DIGITADO DEVE SER ENTRE 1 E 7 \n");
        }

    }

}