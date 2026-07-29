// Questão 5 (2 pontos) — Resolução de problema
// Escreva um programa completo em C que use funções para calcular a média de 3 notas informadas pelo usuário e informe se o aluno foi aprovado (média ≥ 7), em recuperação (5 ≤ média < 7) ou reprovado (média < 5).

// O programa deve ter no mínimo duas funções além do main():

// •	uma para calcular a média
// •	uma para exibir o resultado (aprovado, recuperação ou reprovado)

#include <stdio.h>

// FUNÇÃO PARA CALCULAR A MÉDIA:

float calculaMedia(int n1, int n2, int n3)
{
    return (n1 + n2 + n3) / 3;
}

// FUNÇÃO PARA MOSTRAR O RESULTADO;

char exibirResultado(float media)
{
    if (media < 5)

        return printf("O ALUNO ESTA REPROVADO !!!");

    if (media >=5 && media < 7) 

        return printf("O ALUNO ESTA NA MEDIA !!!");

    else
        return printf("O ALUNO ESTA APROVADO !!!");

}

// MAIN, CONTEÚDO PRINCIPAL 

void main()
{

    int a = 0; int b = 0; int c = 0; float media = 0; char resultado;

    printf("VAMOS CALCULAR SUA MEDIA !!!\n\n");

    printf("Digite a primeira nota ");
    scanf("%d", &a);

    printf("Digite a segunda nota ");
    scanf("%d", &b);

    printf("Digite a terceira nota ");
    scanf("%d", &c);

    media = calculaMedia(a, b, c);

    printf("\n AGORA VAMOS SABER SE O ALUNO ESTA APROVADO, REPROVADO OU EM RECUPERACAO !!! \n\n");

    resultado = exibirResultado(media);

    printf("%c",resultado);

}



