// ESCREVA UM PROGRAMA QUE LEIA UMA PALAVRA DIGITADA PELO USUARIO, E IDENTIFIQUE SE A PALVRA É OU NÃO UM PALÍMDROMO

Console.WriteLine("IDENTIFIOCAÇÃO DE PALIMDROMOS");

Console.WriteLine("DIGITE UMA PALAVRA QUALQUER: ");

string palavra = Console.ReadLine();

string invertida = string.Empty;

for (int i = palavra.Length - 1; i > 0; i--)
{   
    int j = 0;
    invertida += palavra[i];
    j++;
}

if (invertida == palavra)
{
    Console.WriteLine("A PALAVRA " + palavra + " É UM PALÍMDROMO.");
}
else 
{
    Console.WriteLine("A PALAVRA " + palavra + " NÃO É UM PALÍMDROMO.");
}  
