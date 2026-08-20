// VETORES MULTIDIMENSIONAIS

// VETOR BI-DIMENSIONAL

int[,] numbersBi = new int[5, 2];

// VETOR TRI-DIMENSIONAL

int[,,] numbersTri = new int[5, 4, 3];

// PODEMOS COMBINAR A DECLARAÇÃO COM A INICIALIZAÇÃO
// EXEMPLO 4 x 3

int[,] newNumbersBi = new int[,]  
{
    { 9, 5, -9 },
    { -11, 4, 0 },
    { 6, 115, 3 },
    { -12, -9, 71 },
    { 1, -6, -1 }
};

// PERCORRENDO A MATRIZ -- EXEMPLO DE REPETIÇÃO FOR ENCADEADA
// NESTED FOR ou CHAINED FOR

for (int i = 0; i < newNumbersBi.GetLength(0); i++)
{
    for (int j = 0; j < newNumbersBi.GetLength(1); j++)
    {
       Console.Write($"[ {newNumbersBi[i,j]} ]"); 
    }
       Console.WriteLine("");
}

// JAGGED ARRAYS ou ARRAY DE JEGUES
// VETOR DE VETORESs

int[][] jaggedNumbers = new int[4][];

// ATRIBUINDO VALORES AOS JAGGEDS ARRAYS

jaggedNumbers[0] = new int[] { 9, 5, -9 };
jaggedNumbers[1] = new int[] { 0, -3, 12, 51, -3 };
jaggedNumbers[3] = new int[] { 51 };

// DECLARACAO COM INCIALIZAÇÃO

int[][] jaggedNumbers2 =
{
    new int [] { 0, 1, 2 },
    new int [] { 3, 4, 5, 6 },
    new int [] { 7, 8, 9, 10 }
};

// PARA ACESSAR UMA POSIÇAO ESPECÍFICA

int number = jaggedNumbers[1][2]; // NESE CASO ACESSOU E PEGOU O VALOR 12
jaggedNumbers[1][2] = 22;

Console.WriteLine("n = " + number);
Console.WriteLine("jaggedNumbers[1][2] = " + jaggedNumbers[1][2]);



// TAREFA 1: PARA FAZER EM CASA: PAGINA 40 ATÉ A PAGINA 42
// TAREFA 2: PAGINAS 47, 48, 49, 50