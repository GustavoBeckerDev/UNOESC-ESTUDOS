// ESTRUTURAS DE REPETIÇÃO
// WHILE - DO WHILE

#include <stdio.h>
#include <conio.h>

int main()
{
    
    int n = 1;
    printf("Os pares de 1 a 100.\n");

    while (n <= 100)
    {
        printf("%d\t", n);

        n += 2;
    }

    getch();

}