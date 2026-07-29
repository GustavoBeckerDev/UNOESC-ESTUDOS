#include <stdio.h>

int main()
{
    
    // Dada uma distância percorrida (em quilômetros), bem como o total de combustível
    // gasto (em litros), informe o consumo médio do veículo.
    
    float d, l, cm = 0;
    
    printf("Qual a distância percorrida (km): ");
    scanf("%f", &d);
    
    printf("Total de combustível gasto (litros): ");
    scanf("%f", &l);
    
    cm = d / l;
    
    printf("O consumo médio é: %.2fkm/l.", cm);
    
}