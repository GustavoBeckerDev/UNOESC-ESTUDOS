#include <stdio.h>

#define DEBUG 0

int main()
{

    #ifdef DEBUG == 1
        printf("Descricao detalhada: ... \n");
    #elif DEBUG == 2
        printf("Nenhuma descricao... \n");
    #else
        printf("Outra descricao... \n");
    #endif

}

