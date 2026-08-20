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

// VETORES UNI-DIMENSIONAIS:

// SINTAXE: type[] name;

// DECLARAÇÃO DE SEM INICIALIZAÇÃO:
// OBS: VARIAVEL ALOCADA MAS NULA

int[] numbers;

// INICIALIZANDO O VETOR:

numbers = new int[5]; // ALOCAÇÃO DE MEMÓRIA PARA 5 ELEMENTOS

// ATRIBUINDO VALORES AO VETOR:

numbers[0] = 10;
numbers[1] = 20;
numbers[2] = 30;
numbers[3] = 40;
numbers[4] = 50;

// OUTRA FORMA É DECLARAR O VETOR E JA DEFINIR E ATRIBUIR OS VALORES:

int[] numbers2 = new int[] { 100, 200, 300};

int[] numbers3 = { 1000, 2000, 3000, 4000, 5000 };

// PERCORRENDO UM VETOR E ADICIONANDO VALORES DINAMICAMENTE:

Console.WriteLine("Iniciando com vetores: ");

Console.WriteLine("Informe o tamanho do vetor de inteiros: ");

int size = Convert.ToInt32
    ( Console.ReadLine() );

int[] myArray = new int[size];

int total = 0; // ACUMULADOR DE VALORES
int counter = 0; // CONTADOR DE VALORES

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine("Digite para [ " + i + " ]: ");

    myArray[i] = Convert.ToInt32(Console.ReadLine());

    total += myArray[i]; // ACUMULANDO VALORES
    counter++; // CONTANDO VALORES
}

Console.WriteLine("Soma de valores: " + total);
Console.WriteLine("Contagem de valores: " + counter);