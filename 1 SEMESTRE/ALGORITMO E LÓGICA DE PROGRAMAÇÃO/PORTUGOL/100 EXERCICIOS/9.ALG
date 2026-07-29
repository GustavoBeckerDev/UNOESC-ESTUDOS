Algoritmo "semnome"

// 9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
// e mostre quantos dólares ela pode comprar.
// Considere US$1,00 = R$3,45.

Var

   valor: real

Inicio

      Escreva("Digite quanto você tem em R$ para saber o quanto pode comprar em $:")
      leia(valor)
      Escreval("")
      Escreval("Com ", valor, " você pode comprar: $", valor / 3.45, " dólares.")

Fimalgoritmo