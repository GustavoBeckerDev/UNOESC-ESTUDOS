// PILHAS SEGUEM O PRINCÍPIO LIFO
// LAST IN FIRTS OUT - O ÚLTIMO QUE ENTROU SERÁ O PRIMEIRO A SAIR
// A OPERAÇÃO PUSH PARA COLOCAR UM ELEMENTO NO TOPO DA PILHA
// POP PARA RETIRAR O PRIMEIRO ELEMENTO DA PILHA

// PARA UTILIZAR RECURSOS DA PILHA VOCÊ PODE UTILIZAR
// O RECURSO System.Collections.Generic
// HÁ 3 MÉTODOS
// PUSH PARA INSERIR UM ELEMENTO NO TOPO DA PILHA
// POP PARA REMOVER O ELEMENTO DO TOPO DA PILHA
// PEEK PARA OBSERVAR O ELEMENTO DO TOPO SEM REMOVÊ-LO

// PODEMOS UTILIZAR OUTROS METODOS:

// CLEAR PARA LIMPAR A PILHA INTEIRA
// CONTAINS PARA CHECAR UM ELEMENTO ESPECÍFICO NA PILHA
// VER QUANTOS NUMEROS DE UM ELEMENTO ESPECÍFO COUNT

// O PUSH É UMA OPERAÇÃO O(1) CASO SEJA UMA ÚNICA OPERAÇÃO
// POP E PEEK TAMBÉM 
// CASO CONTRÁRIO SERÁ O(n), POIS TEM QUE PERCORRER OS ELEMENTOS DA PILHA

using System.Collections.Generic;

Stack<char> chars = new Stack<char>(); // AQUI NÓS INSTACIAMOS O OBJETO CHARS

string text = string.Empty;
Console.WriteLine("DIGITE UMA PALAVRA: ");
text = Console.ReadLine();

string reversedText = string.Empty;
foreach (char c in text)
    chars.Push(c); 

while (chars.Count > 0)
    reversedText += chars.Pop();

Console.WriteLine(reversedText);

string isPalindromo = text == reversedText 
    ? "É PALINDROMO"
    : "NÃO É PALINDROMO";

Console.WriteLine(isPalindromo);

// ==========================================================

//