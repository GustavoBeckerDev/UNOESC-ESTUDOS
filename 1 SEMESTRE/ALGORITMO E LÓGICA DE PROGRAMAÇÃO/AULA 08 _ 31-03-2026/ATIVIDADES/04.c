// Construa um algoritmo que indique quantos dias tem em um mês.
// Saiba que os meses 4, 6, 9 e 11 possuem 30 dias (31 - 1).
// O mês 2 possui 28 dias (31 - 2).
// Os demais meses possuem 31 dias.

#include <stdio.h>

int main()
{

    int mes;
    int diasmes;
    char op = 'S';

    printf("=============================================\n");
    printf("===== COMO SABER QUANTOS DIAS TEM O MES =====\n");
    printf("=============================================\n");
    printf("\n");

    while (op != 'N')
    {
        diasmes = 31;

        printf("DIGITE O NUMERO DE UM MES (1 A 12) PARA SABER QUANTOS DIAS TEM O MES: ");
        scanf("%d", &mes);

        if (mes < 1 || mes > 12)
        {
            printf("DIGITE UM NUMERO VALIDO DE 1 A 12. \n");
            continue;
        }
        else if (mes == 2)
        {
            diasmes -= 2;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            diasmes -= 1;
        }

        printf("O MES %d POSSUI %d DIAS. \n", mes, diasmes);

        printf("DESEJA CONTINUAR? (S/N): \n");
        scanf(" %c", &op);
    }

    return 0;
}