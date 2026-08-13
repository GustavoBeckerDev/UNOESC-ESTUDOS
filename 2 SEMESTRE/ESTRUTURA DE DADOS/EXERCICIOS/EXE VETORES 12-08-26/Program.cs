// CRIE UM PROGRAMA QUE SEJA CAPAZ DE LER 10 NÚMEROS INTEIROS E SEPARÁ-LOS EM 2 VETORES
// UM PARA OS ÍMPARES, E OUTRO PARA OS PARES
// AO FINAL, IMPRIMA OS DOIS VETORES

int[] numbers = new int[10];
int[] evenNumbers = new int[10];
int[] oddNumbers = new int[10];

int countEven = 0;
int countOdd = 0;

Console.WriteLine("Digite 10 números inteiros: ");

int par = 0;
int imp = 0;

for (int i = 0; i < numbers.Length; i++)
{

    Console.WriteLine("Digite o "+ (i + 1) + "º número: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());

    if (numbers[i] % 2 == 0)
    {
        evenNumbers[i] = numbers[i];
        countEven++;
    }
    else
    {
        oddNumbers[i] = numbers[i];
        countOdd++;
    }

}

// ODD IMPAR, EVEN PAR

// MOSTRANDO OS NUMEROS PARES SEPARADOS DO ARRAY PRINCIPAL:

Console.WriteLine(" ");
Console.WriteLine("ARRAY DE PARES: ");

for (int i = 0; i < evenNumbers.Length; i++)
{
    Console.WriteLine(evenNumbers[i] + " ");
}

Console.WriteLine("TOTAL DE PARES FOI: ");
Console.WriteLine(countEven);

// MOSTRANDO OS NUMEROS IMPARES SEPARADOS DO ARRAY PRINCIPAL:

Console.WriteLine(" ");
Console.WriteLine("ARRAY DE IMPARES: ");

for (int i = 0; i < oddNumbers.Length; i++)
{
    Console.WriteLine(oddNumbers[i] + " ");
}

Console.WriteLine("TOTAL DE IMPARES FOI: ");
Console.WriteLine(countOdd);

// EXERCICIOS 36 ATE 42