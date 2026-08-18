// ESCREVA UM PROGRAMA QUE LEIA UMA PALAVRA DIGITADA PELO USUARIO, E IDENTIFIQUE SE A PALVRA É OU NÃO UM PALÍMDROMO

Console.WriteLine("IDENTIFIOCAÇÃO DE PALIMDROMOS");

Console.WriteLine("DIGITE UMA PALAVRA QUALQUER: ");

string palavra = Console.ReadLine() + "";

string invertida = string.Empty;

for (int i = palavra.Length - 1; i >= 0; i--)
{   
    invertida += palavra[i];
}

bool palimdroma = string.Equals(
    palavra, 
    invertida, 
    StringComparison.OrdinalIgnoreCase
);

if (palimdroma == true)
{
    Console.WriteLine("A palavra {0} É uma palavra PALÍMDROMA", palavra);
}
else {
    Console.WriteLine("A palavra {0} NÃO É uma palavra PALÍMDROMA", palavra);
}