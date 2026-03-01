Algoritmo "19"

// 19) Crie um algoritmo que leia o nome e as duas notas de um aluno, calcule a sua
// média e mostre na tela. No final, analise a média e mostre se o aluno teve ou
// não um bom aproveitamento (se ficou acima da média 7.0).

Var

   n1, n2, media: real
   nome:caractere

Inicio

      Escreva("Digite seu nome: ")
      leia(nome)
      Escreva("Digite sua 1ª nota: ")
      leia(n1)
      Escreva("Digite sua 2ª nota: ")
      leia(n2)
      
      media <- (n1 + n2) / 2
      Escreval("Sua média e: ", media:1:2)
      
      Se (media >= 7) Entao
         Escreval("O aluno ", nome, " teve um bom aproveitamento.")
      Senao
         Escreval("O aluno ", nome, " teve um mal aproveitamento.")
      Fimse

Fimalgoritmo