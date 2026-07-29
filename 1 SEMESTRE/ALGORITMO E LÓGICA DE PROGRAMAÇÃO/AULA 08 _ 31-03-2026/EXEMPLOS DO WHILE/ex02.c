#include <stdio.h>

int main()
{

    int nr;

    do
    {
      
        printf("Digite (0 p/ sair): ");
        scanf("%d", &nr);

        if (nr % 2 == 0)
            printf("Par\n");
        else
            printf("Impar\n");

    } while (nr != 0);

}