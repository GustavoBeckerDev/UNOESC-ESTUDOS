#include <stdio.h>

// EXEMPLO DE PASSAGEM POR VALOR

void alterar(int x, int y, int z)
{
    
    printf("VALORES RECEBIDOS NA FUNCAO: %d, %d, %d \n", x, y, z);
    printf("\n");

    x++; y++; z++;
    
    printf("VALORES ALTERADOS DENTRO DA FUNCAO: %d, %d, %d\n", x, y, z);
    printf("\n");
}

int main()
{   
    int a=1, b=2, c=3;

    printf("\n");
    printf("VALORES ANTES DA CHAMADA DA FUNCAO: %d, %d, %d\n", a, b, c);
    printf("\n");

    alterar(a, b, c);

    printf("VALORES APOS A CHAMADA DA FUNCAO: %d, %d, %d\n", a, b, c);
    printf("\n");
    
    return 0;

}