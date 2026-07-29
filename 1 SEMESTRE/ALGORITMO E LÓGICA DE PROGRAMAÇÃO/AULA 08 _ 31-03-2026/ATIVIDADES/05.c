// Escreva um programa que peça um número ‘n’ ao usuário, e que gere um novo ‘n’ de acordo com as seguintes regras, usar comando while:

// a)  Se n é par, n=n/2 
// b)  Se n é impar n=3*n+1 
// c)  Imprime n 
// d)  O programa deve parar quando n for igual a 1

#include <stdio.h>

int n = 0;

int main()
{

    while (n != 1)
    {

        printf("==========================================\n\n");
        printf("=== PROGRAMA PARA ATRIBUIR VALORES A N ===\n\n");
        printf("==========================================\n\n");
        
        printf("Digite um número para representar N ( 1 para finalizar o programa )");
        scanf("%d", &n);

        if (n % 2 == 0)
        {
            n /= 2;
            printf("O valor de N é: %d", n);
        }
        else if (n % 2 == 1)
        {
            n = 3 * (n+1);
            printf("O valor de N é: %d", n);
        }

            printf("O valor de N é: %d", n);

    }

}

