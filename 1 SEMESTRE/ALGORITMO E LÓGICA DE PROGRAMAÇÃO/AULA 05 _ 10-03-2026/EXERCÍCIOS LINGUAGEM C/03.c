#include <stdio.h>

int main()
{
    
    // Dadas as medidas de uma sala em metros (comprimento e largura), informe a sua
    // área em metros quadrados.
    
    float c, l, a = 0;
    
    printf("Digite um valor para o comprimento: ");
    scanf("%f", &c);
    
    printf("Digite um valor para a largura: ");
    scanf("%f", &l);
    
    a = c * l;
    
    printf("O valor total da área em m² é: %.2fm²", a);
    
}