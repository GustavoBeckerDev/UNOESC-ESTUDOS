#include <stdio.h>

// 1. Numa papelaria, até 100 folhas, a cópia custa R$0,25, acima de 100 folhas custa R$0,20. 
// Dado o total de cópias, informe o total a ser pago

int main () 
{
    float tot, qtd = 0;
    
    printf("Quantas cópias você precisa tirar?");
    scanf("%f", &qtd);
    
    if (qtd <=100) 
    {
        tot = qtd *= 0.25;
    } else {
        tot = qtd *= 0.2;
    };
    
    printf("O valor total a ser pago será: %f", tot);
    
}