Algoritmo "Algoritmo 21"

// 21) Faça um algoritmo que leia um determinado ano e mostre se ele é ou não
// BISSEXTO.

Var

   ano: inteiro

Inicio

      Escreva("Digite um ano: ")
      leia(ano)
      
      Se (((ano mod 4 = 0) E (ano mod 100 <> 0)) OU (ano mod 400 = 0)) Entao
         Escreval("O ano ", ano, " é BISSEXTO.")
      Senao
         Escreval("O ano ", ano, " não é BISSEXTO.")
      Fimse

Fimalgoritmo