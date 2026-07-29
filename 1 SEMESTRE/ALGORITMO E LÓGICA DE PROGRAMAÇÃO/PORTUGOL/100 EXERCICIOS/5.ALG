Algoritmo "semnome"

// 5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
// na tela a sua média na disciplina.
// Ex:
// Nota 1: 4.5
// Nota 2: 8.5
// A média entre 4.5 e 8.5 é igual a 6.5

Var

   materia: caractere
   n1, n2, m: real

Inicio

      Escreval("Vamos calcular sua média.")
      Escreval("Qual a sua matéria?")
      leia(materia)

      Escreval("Digite a 1ª nota: ")
      leia(n1)
      
      Escreval("Digite a 2ª nota: ")
      leia(n2)
      
      m <- (n1 + n2) / 2

      Escreval("A média entre ", n1, " e ", n2, " é igual a: ", m:0:2)


Fimalgoritmo