#include <stdio.h>

int main()
{
    int soma = 0, parcela;

    do
    {

        printf("Digite (0 p/ sair) ou qualquer outro numero para somar: ");
        scanf("%d", &parcela);
        soma += parcela;

    } while (parcela != 0);

    printf("Soma: %d\n", soma);
    
}