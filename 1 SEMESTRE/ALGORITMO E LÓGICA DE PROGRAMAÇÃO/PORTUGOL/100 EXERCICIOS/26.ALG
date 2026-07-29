Algoritmo "Algoritmo 26"

// 26) Escreva um algoritmo que leia dois números inteiros e compare-os, mostrando
// na tela uma das mensagens abaixo:
//  - O primeiro valor é o maior
//  - O segundo valor é o maior
//  - Não existe valor maior, os dois são iguais
 
Var

    n1, n2: real

Inicio

      Escreva("Digite o 1º número: ")
      leia(n1)
      Escreva("Digite o 2º número: ")
      leia(n2)
      
      Se (n1 > n2) Entao
         Escreval("O número ", n1, " é maior que o número ", n2, ".")
      Senao
           Se (n2 > n1) Entao
              Escreval("O número ", n1, " é maior que o número ", n2, ".")
           Senao
              Escreval("Ambos os números são iguais.")
           Fimse
      Fimse

Fimalgoritmo