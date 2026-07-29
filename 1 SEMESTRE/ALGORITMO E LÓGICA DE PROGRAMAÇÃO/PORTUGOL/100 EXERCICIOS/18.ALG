Algoritmo "semnome"

// 18) Faça um programa que leia o ano de nascimento de uma pessoa, calcule a idade
// dela e depois mostre se ela pode ou não votar.

Var

   ano, mes, dia, idade: real

Inicio

      Escreva("Qual o seu ano de nascimento: ")
      leia(ano)
      Escreva("Qual o seu mês de nascimento: ")
      leia(mes)
      Escreva("Qual o seu dia de nascimento: ")
      leia(dia)

      idade <- 2026 - ano

      Se (mes > 2) OU ((mes = 2) E (dia > 15)) Entao
         idade <- idade - 1
      Fimse

      Se (idade < 18) Entao
         Escreval("Você ainda não pode votar.")
      Senao
         Escreval("Você já pode votar.")
      Fimse

Fimalgoritmo