Algoritmo "semnome"

// 13) Faça um algoritmo que leia o salário de um funcionário, calcule e mostre o
// seu novo salário, com 15% de aumento.

Var

   salario, novosalario: real

Inicio

      Escreva("Digite seu salário atual: ")
      leia(salario)
      
      novosalario <- salario + (salario * 0.15)
      
      Escreval("Seu salário com 15% de aumento ficará: ", novosalario:0:2)

Fimalgoritmo