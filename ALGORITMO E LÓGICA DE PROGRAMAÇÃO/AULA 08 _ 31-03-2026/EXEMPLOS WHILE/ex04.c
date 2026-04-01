#include <stdio.h>

int main()
{
    int i, n;
    float media = 0, nota;
    
    printf("Informe a quantidade de ntoas: ");
    scanf("%d", &n);

    i = 1;

    while (i <= n)
    {

        printf("Informe a nota %d: ", i);
        scanf("%f", &nota);
        media += nota;
        i++;

    }

    media = media / n;

    printf("Média: %.2f \n", media);

}