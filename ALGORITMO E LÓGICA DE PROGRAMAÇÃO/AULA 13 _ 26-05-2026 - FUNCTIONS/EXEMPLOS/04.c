#include <stdio.h>

int fatorial (int n)
{
    if (n == 0)
        return 1; // FALSE
    else   
        return n * fatorial(n-1);
}

int main()
{
    int n;
    printf("Digite um valor para n: ");
    scanf("%d", &n);

    printf("Fatorial: %d", fatorial(n));
    return 0;
}
