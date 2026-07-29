Algoritmo "semnome"

// 10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e
// mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
// sabendo que cada litro de tinta pinta uma área de 2metros quadrados.

Var

  altura, largura, area: real

Inicio

      Escreva("Qual a altura da sua parede: ")
      leia(altura)
      Escreva("Qual a largura da sua parede: ")
      leia(largura)
      
      area <- altura * largura
      
      Escreval("A área total a ser pintada é: ", area)
      Escreval("O total de tinta necessário é: ", area/2, " litros.")

Fimalgoritmo