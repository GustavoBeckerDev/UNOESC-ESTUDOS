// SWITCH PARA INTEIROS E CARACTERES
// COMPARAR IGUALDADE
// NÃO TEM EXPRESSÃO LÓGICA
// MELHOR LEGIBILIDADE

#include <stdio.h>

int main()
{

    int mes = 0;
    char OP = 0;

    printf("=== ESCOLHA UM NUMERO DE 1 A 12 PARA SABER QUANTOS DIAS TEM O MES ===\n");

    printf("Escolha de 1 a 12:  ");
    scanf("%d", &mes);

    do 
    {

        if (mes < 0 || mes > 12)
        {
            printf("DIGITE UM NUMERO VALIDO ENTRE 1 E 12 \n");
        }
        else
        {

            switch (mes)
            {
        
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    printf("O MES %d TEM 31 DIAS\n", mes);
                    continue;
                case 4: case 6: case 9: case 11:
                    printf("O MES %d TEM 30 DIAS\n", mes);
                    continue;
                case 2:
                    printf("O MES %d TEM 28 DIAS\n", mes);
                    continue;
                default:
                    printf("O NUMERO DIGITADO DEVE SER ENTRE 1 E 12 \n");
            }

        }

        printf("PARA FINALIZAR A EXECUÇÃO DIGITE 0: \n");
        scanf("%d", &OP);

    } while (OP != 0);

}