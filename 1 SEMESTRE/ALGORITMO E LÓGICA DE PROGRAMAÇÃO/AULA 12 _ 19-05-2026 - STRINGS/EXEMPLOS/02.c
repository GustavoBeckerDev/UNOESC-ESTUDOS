// AULA DE STRINGS (VETORES DE CARACTERES)

#include <stdio.h>
#include <string.h>

int main()
{

    char Palavra[200];
    int i = 0;

    // printf("Digite o seu nome: ");
    scanf("%s", Palavra);

    // PERCORRE ATE ENCONTRAR '\O'

    for (i=0; Palavra[i] != '\0'; i++)
    {
        printf("%c\n\n", Palavra[i]);
    }

    printf("%d\n\n", i);
    printf("%s\n", Palavra);
    return 0;

}