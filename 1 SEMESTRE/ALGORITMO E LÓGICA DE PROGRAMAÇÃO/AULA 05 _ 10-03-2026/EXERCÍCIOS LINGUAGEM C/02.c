#include <stdio.h>

int main()
{
    // Dado o total de vendas de um vendedor, calcule a sua comissão. Suponha que a
    // comissão do vendedor seja de 10% do total de vendas.
    
    float v, c = 0;
    
    printf("Digite o valor total de vendas: ");
    scanf("%f", &v);
    
    c = v * 0.1; // 10%
    
    printf("O valor total de comissão será: %f", c);
    
}