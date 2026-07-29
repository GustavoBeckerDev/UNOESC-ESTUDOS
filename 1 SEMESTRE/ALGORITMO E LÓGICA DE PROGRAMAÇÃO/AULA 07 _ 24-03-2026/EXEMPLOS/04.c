#include <stdio.h>
#include <math.h>

int main()
{

    int op, num = 0;

    for (op=1; op!=0;)
    {
        printf("DIGITE UM NUMERO: \t");
        scanf("%d", &num);

        num = pow(num,2)*3;

        printf("RESULTADO: %d \n", num);

        printf("CONTINUAR ? \n");
        scanf("%d", &op);
    }
    
    return 0;

}