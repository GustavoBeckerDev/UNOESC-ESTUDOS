#include <stdio.h>

int main()
{
    
    // Dados a temperatura em graus Celsius, converta e informe o valor equivalente em
    // graus Fahrenheit e em Kelvin. 
    // Utilize as fórmulas: F = (C * 9/5) + 32 e K = C + 273.15.
    
    float c, f, k = 0;
    
    printf("Digite um valor para a temperadura em °C: ");
    scanf("%f", &c);
    
    f = (c * 9 / 5) + 32;
    k = c + 273.15;
    
    printf("O valor de %.2f°C em Fahrenheit é: %.2f°F, e em Kelvin é: %.2f°K.", c, f, k);
    
    