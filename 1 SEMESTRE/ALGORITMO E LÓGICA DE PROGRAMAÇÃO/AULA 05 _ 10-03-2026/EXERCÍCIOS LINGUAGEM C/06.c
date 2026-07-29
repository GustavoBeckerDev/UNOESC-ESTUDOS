#include <stdio.h>

int main()
{
    
    // Dados o valor de um produto e o percentual de desconto oferecido, calcule e
    // informe o valor final a ser pago pelo cliente após o desconto.
    
    float p, d, vf = 0;
    
    printf("Vamos calcular o seu desconto! \n");
    
    printf("Qual o valor do produto: ");
    scanf("%f", &p);
    
    printf("Qual o percentual (%) de desconto: ");
    scanf("%f", &d);
    
    d = p * d / 100;
    vf = p - d;
    
    printf("O valor final será: %.2f.", vf);
    
}