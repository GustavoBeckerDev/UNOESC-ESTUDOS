#include <stdio.h>
#include <math.h>

int main()
{
    float b[5];
    int i = 0;

    b[0] = 2;               // B NA POSIÇÃO 0 VALE 2
    b[2] = 5;               // B NA POSIÇÃO 2 VALE 5
    b[1] = b[0] - b[2];     // B NA POSIÇÃO 1 = 2 - 5 = B NA POSIÇÃO 1 É IGUAL A -3
    b[3] = pow(b[2], 2);    // B NA POSIÇÃO 3 É A POTENCIAÇÃO DO B NA POSIÇÃO 2 ELEVADO A 2 = 5^2 = B[3] = 25
    b[4] = b[3] - 1;        // B NA POSIÇÃO 4 É IGUAL AO B NA POSIÇÃO 3 (25) - 1, OU SEJA, B NA POSIÇÃO 4 É 24

    for(i=0; i<5; i++)
    {
        printf("%f\n", b[i]);
    }

}