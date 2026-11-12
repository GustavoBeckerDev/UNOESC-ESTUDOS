using InsertionSort;

int[] integerValues = {-11, 12, -42, 0, 1, 90, 6, -9};

Console.WriteLine("\n\nVetor Desordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

InsertionSort.InsertionSort.Sort(integerValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", integerValues));

Console.WriteLine("\n\n====================================================\n\n");

string [] stringValues = {"CARLOS", "ANA", "MAURICIO", "GUSTAVO"};

Console.WriteLine("Vetor Desordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

InsertionSort.InsertionSort.Sort(stringValues);

Console.WriteLine("\n\nVetor Ordenado: ");
Console.WriteLine(string.Join(" | ", stringValues));

Console.WriteLine($"Total de Operações: {InsertionSort.InsertionSort.OperationCount}");

Console.WriteLine($"Total de Swaps: {InsertionSort.InsertionSort.SwapCount}");

