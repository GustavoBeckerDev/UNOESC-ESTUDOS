#include <stdio.h>

int main()
{
    int fruta = 0;

    do
    {

        printf("ESCOLHA A FRUTA: ");
        printf("(1) MAMAO (2) ACABAXI (3) LARANJA (0) FINALIZAD A EXECUCAO: ");
        scanf("%d", &fruta);

        if (fruta < 1 || fruta > 3)
        {
            if (fruta == 0)
            {
                printf("PROGRAMA FINALIZADO. \n");
                printf("OBRIGADO POR PARTICIPAR DESTE ALGORITMO. \n");
                break;
            }

            printf("ESCOLHA UMA OPCAO VALIDA. \n");
        }
        else        
        {

            switch (fruta)
            {
                case 1:
                    printf("MAMAO \n");
                    // break;
                case 2:
                    printf("ABACAXI \n");
                    // break;
                case 3:
                    printf("LARANJA \n");
                    // break;
            }

        }

    } while (fruta != 0);

}