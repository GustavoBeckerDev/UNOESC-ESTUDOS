Algoritmo "Algoritmo 25"

// 25) [DESAFIO] Crie um programa que leia o tamanho de três segmentos de reta.
// Analise seus comprimentos e diga se é possível formar um triângulo com essas
// retas. Matematicamente, para três segmentos formarem um triângulo, o comprimento
// de cada lado deve ser menor que a soma dos outros dois.

Var

   r1, r2, r3: real

Inicio

      Escreva("Digite o comprimento da 1ª reta: ")
      leia(r1)
      Escreva("Digite o comprimento da 2ª reta: ")
      leia(r2)
      Escreva("Digite o comprimento da 3ª reta: ")
      leia(r3)
      
      Se (r1 >= r2 + r3) OU (r2 >= r1 + r3) OU (r3 >= r1 + r2) Entao
         Escreval("Não é possível formar um triângulo.")
      Senao
         Escreval("É possível formar um triângulo.")
      Fimse

Fimalgoritmo