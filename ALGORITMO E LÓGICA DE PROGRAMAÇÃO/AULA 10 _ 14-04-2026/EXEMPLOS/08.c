#include <stdio.h>

int main()
{
    
    int vetorA[5]={7,8,9,1,5};
    int vetorB[5]={1,2,3,4,5};
    int prod=0, i;

    for(i=0; i<5; i++)
    {
        prod += vetorA[i]*vetorB[i];
    }

    printf("Produto: %d", prod);
    // 7×1+8×2+9×3+1×4+5×5
    // = 7+16+27+4+25 = 79

}