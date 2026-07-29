// ESTRUTURAS DE REPETIÇÃO
// WHILE - DO WHILE

#include <stdio.h>
#include <stdbool.h>
#include <locale.h>

int main()
{
    setlocale(LC_ALL, "Portuguese");

    int i, n;
    float media = 0, nota;

    printf("Informe a quantidade de notas: ");
    scanf("%d", &n);

    i = 1;

    while (i <= n)
    {
        printf("Informe a %dª nota : ", i);
        scanf("%f", &nota);

        media += nota;
        i++;     
    }

    media = media / n;

    printf("Media: %.2f\n", media);

}