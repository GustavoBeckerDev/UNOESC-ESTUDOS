Algoritmo "semnome"

// 16) [DESAFIO] Escreva um programa
// para calcular a redução do tempo
// de vida de um fumante.

// Pergunte a quantidade de cigarros
// fumados por dia e quantos anos
// ele já fumou.

// Considere que um fumante perde
// 10 min de vida a cada cigarro.

// Calcule quantos dias de vida
// um fumante perderá
// e exiba o total em dias.

Var

   cigarroDiario, anosFumados, diasPerdidos: real

Inicio

      Escreva("Quantos cigarros você fuma por dia: ")
      leia(cigarroDiario)
      Escreva("Há quantos anos você fuma: ")
      leia(anosfumados)
      
      diasPerdidos <- (cigarroDiario * 10 * 365 * anosFumados) / 1440
      
      Escreval("Até o momento, você perdeu ", diasPerdidos: 1:0, " dias de vida")

Fimalgoritmo