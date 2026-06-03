#include <stdio.h>

int maior(int *vetor, int tamanho)
{

    int i;
    int max = vetor[0];

    for (i = 1; i < tamanho; i++)
    {
        if (vetor[i] > max)
            max = vetor[i];
    }

    return max;

}

int main()
{

    int vetor[100]; int n, i;

    printf("Digite a quantidadade de elementos do vetor: ");
    scanf("%d", &n);

    printf("Digite os elementos do vetor: \n");
    for (i = 0; i < n; i++)
    {
        scanf("%d", &vetor[i]);
    }

    int resultado = maior(vetor, n); // AQUI NAO PASSA O & POR SER UM VETOR

    printf("O maior valor do vetor e: %d\n", resultado);

    return 0;

}