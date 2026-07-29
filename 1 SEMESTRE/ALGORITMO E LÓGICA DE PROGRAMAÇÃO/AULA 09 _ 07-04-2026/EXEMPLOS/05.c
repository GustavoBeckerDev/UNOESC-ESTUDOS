// #DEFINE (PARA DEFINIR CONSTANTES A SEREM UTILIZADAS NO CÓDIGO).

#include <stdio.h>

#define DEBUG

int main()
{

    #ifdef DEBUG
        printf("Descricao detalhada: ... \n");
    #else
        printf("Nenhuma descricao... \n");
    #endif

}

