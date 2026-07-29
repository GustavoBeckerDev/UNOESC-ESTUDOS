Algoritmo "Algoritmo 22"


// 22) Escreva um programa que leia o ano de nascimento de um rapaz e mostre a sua
// situação em relação ao alistamento militar.
// - Se estiver antes dos 18 anos, mostre em quantos anos faltam para o
// alistamento.
// - Se já tiver depois dos 18 anos, mostre quantos anos já se passaram do
// alistamento.

Var

   anoNasc, idade: inteiro

Inicio

   Escreva("Digite o ano de nascimento: ")
   Leia(anoNasc)

   idade <- 2026 - anoNasc

   Se idade < 18 Entao
      Escreval("Faltam ", 18 - idade, " anos para o alistamento.")
   Senao
      Se idade > 18 Entao
         Escreval("Já se passaram ", idade - 18, " anos do alistamento.")
      Senao
         Escreval("Você está no ano do alistamento.")
      FimSe
   FimSe

Fimalgoritmo