Algoritmo "semnome"

// 12) Crie um programa que leia o preço de um produto, calcule e mostre o seu
// PREÇO PROMOCIONAL, com 5% de desconto.

Var

   preco: real
   precodesconto: real
Inicio

      Escreval("Digite o preço do produto: ")
      leia(preco)
      
      precodesconto <- preco - (preco*0.05)
      Escreval("O preço promocional com 5% de desconto do pruduto é: ", precodesconto:0:2)

Fimalgoritmo