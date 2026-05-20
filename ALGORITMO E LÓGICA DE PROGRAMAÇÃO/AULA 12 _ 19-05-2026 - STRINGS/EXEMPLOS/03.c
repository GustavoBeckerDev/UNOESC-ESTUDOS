#include <stdio.h>
#include <string.h>

//strcpy(s1,s2) COPIA S2 PARA S1

//strcat(s1,s2) CONCATENA S2 AO FINAL DE S1

//strcmp(s1,s2) COMPARA S1 COM S2 (0 = IGUAIS)

//strlen(s1) RETORNA O TAMANHO ATE '\0'

//strcspn(s1,s2) INDICE DO 1º CHAR DE S2 ENCONTRADO EM S1

int main()
{

    char str1[20], str2[20];

    printf("Digite uma string: "); // ESCREVENDO A PERGUNTA
    fgets(str1, 20, stdin);        // PEGANDO O VALOR ESCRITO

    str1[strcspn(str1, "\n")] = '\0'; // AQUI IGNORA O ENTER QUE O USUARIO DA DEPOIS DE ESCREVER E ATRIBUI O '\0' PARA ENCERRAR A STRING

    strcpy(str2, str1); // COPIA O STR1 PARA STR2

    printf("STRING COPIADA: %s \n", str2);
    
    return 0;

}