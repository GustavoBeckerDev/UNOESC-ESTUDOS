using BubbleSort;

int[] integerValues = {-11, 12, -42, 0, 1, 90, 6, -9};

Console.WriteLine("\n\nVetor Desordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

BubbleSort.BubbleSort.Sort(integerValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

Console.WriteLine("\n\n====================================================\n\n");

string [] stringValues = {"CARLOS", "ANA", "MAURICIO", "GUSTAVO", "MARCELA", "WALDAIR", "ALMIR"};

Console.WriteLine("Vetor Desordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

BubbleSort.BubbleSort.Sort(stringValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

Console.WriteLine("\n\n===================================================\n\n");

Console.WriteLine($"Total de Operações: {BubbleSort.BubbleSort.OperationCount}");

Console.WriteLine($"Total de Swaps: {BubbleSort.BubbleSort.SwapCount}");

