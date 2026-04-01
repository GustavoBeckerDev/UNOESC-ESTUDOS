// Construa um algoritmo que indique quantos dias tem em um mês. 
// Saiba que os meses 4, 6, 9 e 11 é subtraído 1 dia (pois possuem 30 dias). 
// O mês 2 devem ser subtraídos 2 dias. Os demais meses possuem 31 dias.

#include <stdio.h>
#include <conio.h>

int main()
{

    int i, mes;
    int diasmes = 31;
    char op;

    printf("=============================================\n");
    printf("===== COMO SABER QUANTOS DIAS TEM O MES =====\n");
    printf("=============================================\n");
    printf("\n");

    while (op != 'N')
    {

        printf("DIGITE O NUMERO DE UM MES (1 A 12) PARA SABER QUANTOS DIAS TEM O MES: ");
        scanf("%d", &mes);

        if (mes < 1 || mes > 31)
        {
            printf("DIGITE UM NUMERO VALIDO DE 1 A 12. \n");
            continue;
        }
        else if (mes == 2)
        {
            diasmes -= 2;
            printf("O MES %d POSSUI %d DIAS. \n", mes, diasmes);
            // continue;
        }
        else if (mes == 4 && mes == 6 && mes == 9 && mes == 11)
        {
            diasmes -= 1;
            printf("O MES %d POSSUI %d DIAS. \n", mes, diasmes);
            // continue;
        }
        else {
            printf("O MES %d POSSUI %d DIAS. \n", mes, diasmes);
            // continue;
        }

        printf("DESEJA CONTINUAR? (S/N): \n");
        scanf("%c", &op);
        
    }

}
        