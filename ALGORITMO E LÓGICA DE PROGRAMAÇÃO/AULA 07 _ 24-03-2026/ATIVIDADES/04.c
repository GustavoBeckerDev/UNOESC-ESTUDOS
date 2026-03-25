// 4. Dados um capital, uma taxa de juros mensal e um período em meses, informe o
// montante ao final de cada mês.

#include <stdio.h>

int main()
{
    float capital, juros, montante;
    int i, meses;

    printf("DIGITE O SEU CAPITAL INICIAL: \t");
    scanf("%f", &capital);

    printf("DIGITE A TAXA DE JUROS A SER APLICADA: \t");
    scanf("%f", &juros);

    printf("DIGITE A QUANTIDADE DE MESES PARA APLICACAO DO SEU CAPITAL: \t");
    scanf("%d", &meses);

    for(i=1; i <= meses; i++)
    {
        capital += (capital * (juros/100));
    }

    printf("O CAPITAL FINAL E: %.2f", capital);

}