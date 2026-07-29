#include <stdio.h>

int main()
{

    int op = 1;
    
    while (op != 0)
    {

        printf("Digite (0 p/ sair): ");
        scanf("%d", &op);

        if (op > 0)
        {
            printf("POSITIVO. \n");
        }
        else if (op < 0)
        {
            printf("NEGATIVO. \n");
        }
        else
        {
            printf("DIGITE APENAS NÚMEROS. \n");
        }

    }

    printf("TCHAU !!!");

}