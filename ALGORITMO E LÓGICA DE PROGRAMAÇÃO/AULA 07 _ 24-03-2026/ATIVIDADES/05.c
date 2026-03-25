// 5. Criar um algoritmo que entre com cinco números e imprimir o quadrado de cada número.

#include <stdio.h>
#include <math.h>

int main()
{
    float n, q;
    int i;

    for (i = 1; i <= 5; i++)
    {
        printf("DIGITE O %d NUMERO: \n", i);
        scanf("%f", &n);

        q = pow(n, 2);

        printf("O QUADRADO DE %.2f E %.2f \n", n, q);
    }

}