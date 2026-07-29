#include <stdio.h>

int main()
{
    // Dado um número real, informe qual o seu dobro.

    float a, dobro;
    
    printf("Informe um número real para saber o seu dobro: ");
    scanf("%f", &a);
    
    dobro = a * 2;
    
    printf("O dobro de %f é: %f", a, dobro);
    
}