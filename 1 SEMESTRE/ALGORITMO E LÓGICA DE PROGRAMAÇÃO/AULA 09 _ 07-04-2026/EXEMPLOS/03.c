// #DEFINE (PARA DEFINIR CONSTANTES A SEREM UTILIZADAS NO CÓDIGO).
// NESSE CASO ESTOU DEFININDO UMA FUNÇÃO, ONDE RECEBE 2 PARÂMETROS, E EU ISOLO OS ELEMENTOS DOS PARÂMETROS ((X) + (Y)) SENÃO DARÁ ERRO

#include <stdio.h>

#define SOMA(x,y) ((x) + (y))
#define PI 3.14

int main()
{
    int a = SOMA(1,2);
    double b = SOMA(1.5, 2.5);

    double RESULTADO = SOMA(PI, 3.5);

    printf("a = %d\n", a);
    printf("b = %.2f\n", b);
    printf("Resultado = %.2f\n", RESULTADO);

    return 0;
} 

