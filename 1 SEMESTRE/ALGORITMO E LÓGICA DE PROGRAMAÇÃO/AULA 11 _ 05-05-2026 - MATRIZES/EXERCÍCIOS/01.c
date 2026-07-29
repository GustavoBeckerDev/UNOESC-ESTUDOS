// Elabore  um  algoritmo  que  leia  duas  matrizes,  A  e  B  do  tipo  (3x3)  
// e calcule em uma matriz R sua multiplicação.

#include <stdio.h>

int main()
{

    int i = 0; int j = 0; float mat1[3][3]; float mat2[3][3]; float mat3[3][3];

    printf("PREENCHA 2 MATRIZES E DEPOIS GUARDA OS RESULTADOS NA TERCEIRA MATRIZ: \n\n");

    // PEGANDO OS VALORES PARA A PRIMEIRA MATRIZ

    printf("PRIMEIRA MATRIZ PARA PREENCHER: \n\n");

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3 ; j++)
        {
            printf("DIGITE UM NUMERO PARA A 1 MATRIZ NO INDICE [%d] [%d] : ", i, j);
            scanf("%f", &mat1[i][j]);
        }
    }

    // PEGANDO OS VALORES PARA A SEGUNDA MATRIZ

    printf("SEGUNDA MATRIZ PARA PREENCHER: \n\n");

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3 ; j++)
        {
            printf("DIGITE UM NUMERO PARA A 2 MATRIZ NO INDICE [%d] [%d] : ", i, j);
            scanf("%f", &mat2[i][j]);
        }
    }


    // AQUI EU IREI MULTIPLICAR OS VALORES PARA A TERCEIRA MATRIZ 3x3

    printf("AGORA IREMOS MULTIPLICAR AS MATRIZES 1 PELA 2 E GUARDAR O RESULTADO NA MATRIZ 3: \n\n");

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3 ; j++)
        {
            mat3[i][j] = mat1[i][j] * mat2[i][j];
        }
    }

    // AQUI EU IREI MOSTRAR A NOVA MATRIZ MULTIPLICADA

    printf("MOSTRANDO OS VALORES MULTIPLICADOS: \n");

    for (i = 0; i < 3; i++)
    {
        for (j = 0; j < 3 ; j++)
        {
            printf("| %.2f |", mat3[i][j]);
        }
        printf("\n");
    }

}