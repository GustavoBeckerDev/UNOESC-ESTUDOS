#include <stdio.h>

int maior (int a, int b)
{
	if (a > b)
	    return a;
	else if (b > a)
	    return b;
	else 
	    printf(“Os valores sao iguais.”);
}

int main( )
{
    int resultado;

    printf(“Digite 2 numeros inteiros: “);
    scanf(“%d %d”, &x, &y);

    resultado = maior(x, y);

    printf(resultado);
}
