#include <stdio.h>

int main()
{
    
    // O índice de massa corpórea (IMC) de uma pessoa é igual ao seu peso (em
    // quilogramas) dividido pelo quadrado de sua altura (em metros). Dados o peso e a
    // altura de uma pessoa, informe o valor de seu IMC.
    
    float p, a, imc = 0;
    
    printf("Vamos calcular o seu IMC \n");
    
    printf("Qual o seu peso: ");
    scanf("%f", &p);
    
    printf("Qual a sua altura: ");
    scanf("%f", &a);
    
    imc = p / (a * a);
    
    printf("O seu IMC é: %.2f.", imc);
    
}