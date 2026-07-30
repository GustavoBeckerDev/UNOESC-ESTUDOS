using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

// COMENTÁRIO DE UMA LINHA

/*

COMENTÁRIO DE BLOCO COMPELTO

*/

// ALGUNS TIPOS DE DADOS:

int number = 10;
string name = "Gustavo Becker";
double quantity = 0.0;
bool hasMoney = true;
char letter = 'G';

// CONSTANTES:

const int DAYS_IN_WEEK = 7;

// Console.WriteLine ("INFORME O SEU NOME: ");

// name = Console.ReadLine();

// Console.WriteLine("Seja bem-vinbdo " + name);

// ENUMERADORES (É COMO UM TIPO DE DADO)

// enum Language { PT, EN, ES }

// Language language = Language.PT;

// CONCATENANDO STRINGS:

string firstName = "Gustavo", lastName = "";

lastName = "Becker";

string fullName = firstName + " " + lastName;

Console.WriteLine(fullName);

string middleName = "de Abreu";

// INTERPOLAÇÃO DE STRINGS:

string message = $"Nome completo: {firstName} {middleName} {lastName}";

Console.WriteLine(message);















