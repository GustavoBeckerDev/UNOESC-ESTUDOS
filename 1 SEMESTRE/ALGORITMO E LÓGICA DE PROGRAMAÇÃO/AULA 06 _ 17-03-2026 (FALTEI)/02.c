#include <stdio.h>

// 2. Numa fábrica, uma máquina precisa de manutenção sempre que o número de
// peças defeituosas supera 10% da produção. Dados o total de peças produzidas e o
// total de peças defeituosas, informe se a máquina precisa de manutenção.

int main()
{
    int pecas;

    printf("Qual a porcentagem de pecas defeituosas: ");
    scanf("%d", &pecas);

    if (pecas > 10)
    {
        printf("A MAQUINA PRECISA DE MANUTENCAO. \n");
    } else {
        printf("A MAQUINA NAO PRECISA DE MANUTENCAO. \n");
    }

}