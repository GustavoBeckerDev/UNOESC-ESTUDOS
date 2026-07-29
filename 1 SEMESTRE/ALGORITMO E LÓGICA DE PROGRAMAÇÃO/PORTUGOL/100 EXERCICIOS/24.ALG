Algoritmo "Algoritmo 24"

// 24) Faça um algoritmo que pergunte a distância que um passageiro deseja
// percorrer em Km. Calcule o preço da passagem, cobrando R$0.50 por Km para
// viagens até 200Km e R$0.45 para viagens mais longas.

Var

   dist, preco: real

Inicio

      Escreva("Qual a distância que você irá percorrer: ")
      leia(dist)
      
      Se (dist <= 200) Entao
         preco <- dist * 0.5
      Senao
         preco <- dist * 0.45
      Fimse
      
      Escreval("Para percorrer ", dist, "km's você irá pagar R$", preco, " reais.")

Fimalgoritmo