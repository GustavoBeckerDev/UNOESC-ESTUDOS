#include <stdio.h>

int main()
{

    float a[2][2];
    a[0][0] = 9.0;
    a[0][1] = 8.0;
    a[1][0] = 7.0;
    a[1][1] = 7.0;

    float quant;

    quant = a[0][0] + a[0][1] + a[1][0] + a[1][1];

    printf("%.2f", quant);
    
}