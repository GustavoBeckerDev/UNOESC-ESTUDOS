Algoritmo "semnome"

// 11) Desenvolva uma lógica que leia os valores de A, B e C de uma equação do
// segundo grau e mostre o valor de Delta.

Var

   a, b, c, delta: real

Inicio


      // LER NÚMEROS E CALCULAR O DELTA
      Escreval("Digite um número para a: ")
      leia(a)
      Escreval("Digite um número para b: ")
      leia(b)
      Escreval("Digite um número para c: ")
      leia(c)
      
      Se a = 0 entao
         Escreval("Isso não é uma equação de 2º grau.")
      Senao
           delta <- b*b - 4 * a * c
           Escreval("O valor de Delta é: ", delta:0:2)
      FimSe
      // Agora realizar a equação de 2º grau
      
      
      
      


Fimalgoritmo