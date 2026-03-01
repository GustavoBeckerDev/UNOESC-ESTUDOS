Algoritmo "Algoritmo 23"

// 23) Numa promoção exclusiva para o Dia da Mulher, uma loja quer dar descontos
// para todos, mas especialmente para mulheres. Faça um programa que leia nome,
// sexo e o valor das compras do cliente e calcule o preço com desconto. Sabendo
// que:
//  - Homens ganham 5% de desconto
//  - Mulheres ganham 13% de desconto
 
Var

   nome, sexo: caractere
   vtotal: real

Inicio

      Escreva("Digite o seu nome: ")
      leia(nome)
      Escreva("Digite seu sexo (M/F): ")
      leia(sexo)
      Escreva("Digite o valor total da compra: ")
      leia(vtotal)
      
      sexo <- maiusc(sexo)
      
      Se (sexo = "F") Entao
         vtotal <- vtotal * 0.87
      Senao
      
         Se (sexo = "M") Entao
           vtotal <- vtotal * 0.95
         Fimse
         
      Fimse
      
      Escreval("O valor total da compra de ", nome, " foi: R$", vtotal:1:2)


Fimalgoritmo