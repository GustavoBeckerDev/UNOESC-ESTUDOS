#include <stdio.h>
#include <stdbool.h>

int main()
{
    int i, op;

    for (i = 0; true; i++)
    {
        printf("Iteracao %d \n", i);
        printf("Continuar? \n");
        scanf("%d", &op);

        if (op != 0)
        {
            printf("EXECUTANDO......\n");
            continue;
        }
        else 
        {
            printf("OBRIGADO POR PARTICIPAR!!! \n");
            break;
        }

    }




}