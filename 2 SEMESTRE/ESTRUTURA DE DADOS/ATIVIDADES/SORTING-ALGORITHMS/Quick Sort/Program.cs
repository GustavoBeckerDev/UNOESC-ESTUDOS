using QuickSort;

int[] integerValues = {-11, 12, -42, 0, 1, 90, 6, -9};

Console.WriteLine("\n\nVetor Desordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

QuickSort.QuickSort.Sort(integerValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

Console.WriteLine("\n\n====================================================\n\n");

string [] stringValues = {"CARLOS", "ANA", "MAURICIO", "GUSTAVO", "MARCELA", "WALDAIR", "ALMIR"};

Console.WriteLine("Vetor Desordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

QuickSort.QuickSort.Sort(stringValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

Console.WriteLine("\n\n===================================================\n\n");

Console.WriteLine($"Total de Operações: {QuickSort.QuickSort.OperationCount}");

Console.WriteLine($"Total de Swaps: {QuickSort.QuickSort.SwapCount}");

