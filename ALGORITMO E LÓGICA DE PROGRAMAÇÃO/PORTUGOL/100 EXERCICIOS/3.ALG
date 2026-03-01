Algoritmo "semnome"

// 3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
// final uma mensagem.
// Ex:
// Nome do Funcionário: Maria do Carmo
// Salário: 1850,45
// O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.

Var

   nome: caractere
   salario: real

Inicio

      Escreval("Bom dia, qual o seu nome?")
      leia(nome)
      Escreval("Muito obrigado, vamos para a próxima pergunta.")
      Escreval("Qual o seu salário?")
      leia(salario)
      
      Escreval("Nome do funcionário: ", nome, ".")
      Escreval("Salário: R$",salario:0:2, ".")
      
      Escreval("O funcionário ", nome, " tem um salário de R$",salario:0:2, " em Fevereiro.")

Fimalgoritmo