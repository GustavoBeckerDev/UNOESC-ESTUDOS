#include <stdio.h>
#include <string.h>

int main()
{

    char str1[50] = "teste";
    char str2[20];

    fgets(str2, sizeof(str2), stdin);

    str2[strcspn(str2, "\n")] = '\0';

    if (strlen(str1) + strlen(str2) < sizeof(str1))
    {
        strcat(str1, str2);
        puts(str1);
    } else {
        printf("ERRO! \n");
    }

    return 0;

}