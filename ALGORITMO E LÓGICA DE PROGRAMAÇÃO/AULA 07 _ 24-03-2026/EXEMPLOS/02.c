#include <stdio.h>

int main()
{
    int n, i;

    for(i = 0; i < n; i++)
    {
        printf("Digite um valor: \n");
        scanf("%d", &n);

        printf("Obrigado por digitar %d na iteracao %d \n", n, i);
    }

}