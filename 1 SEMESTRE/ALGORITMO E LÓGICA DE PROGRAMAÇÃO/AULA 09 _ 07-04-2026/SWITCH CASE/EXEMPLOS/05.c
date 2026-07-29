#include <stdio.h>

int main()
{

    int op = 0;
    float juros = 0, valorFinal = 0;
    int valorInicial = 0;
    

    printf("DIGITE O VALOR INICIAL DA OPERACAO: ");
    scanf("%d", &valorInicial);

    printf("DIGITE UMA OPCAO PARA CALCULAR O JUROS ACUMULADO: \n");
    printf("5 -> 5%% | 4 -> 4%% | 3 -> 3%% | 2 -> 2%% | 1 -> 1%%: ");
    scanf("%d", &op);

    switch (op)
    {
        case 5:
            juros++;
        case 4:
            juros++;
        case 3:
            juros++;
        case 2:
            juros++;
        case 1:
            juros++;
            break;
        default:
            printf("VALOR INVALIDO. \n");
    }

    valorFinal = (1 + juros / 100.0) * valorInicial;

    printf("O VALOR FINAL APOS OS JUROS APLICADOS E: %.2f", valorFinal);

}