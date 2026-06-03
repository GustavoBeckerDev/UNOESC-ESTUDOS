#include <stdio.h>

int maior (int a, int b)
{
	if (a > b)
	    return a;
	else if (b > a)
	    return b;
	else 
	    return 1;
}

int main( )
{
	
	int x = 0; 
	int y = 0;

    printf("Digite o 1 numero inteiro: ");
    scanf("%d", &x);

	printf("Digite o 2 numero inteiro: ");
    scanf("%d", &y);

	if (maior(x,y) == 1)
		printf("Os numeros %d e %d sao iguais.", x, y);
	else
		printf("O maior numero e: %d", maior(x, y));

}
