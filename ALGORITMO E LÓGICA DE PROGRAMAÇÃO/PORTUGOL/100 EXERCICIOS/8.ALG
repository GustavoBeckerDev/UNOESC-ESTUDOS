Algoritmo "semnome"

// 8) Desenvolva um programa que leia uma distância em metros e mostre os valores
// relativos em outras medidas.
// Ex:
// Digite uma distância em metros: 185.72
// A distância de 185.72m corresponde a:
// 0.18572Km   /1000
// 1.8572Hm    /100
// 18.572Dam   /10
// 1857.2dm    *10
// 18572.0cm   *100
// 185720.0mm  *1000

Var

   distancia: real

Inicio

      Escreva("Digite uma distância em metros: ")
      leia(distancia)
      Escreval("")
      Escreval(distancia, " metros em Km são: ", distancia / 1000, "km")
      Escreval(distancia, " metros em Hm são: ", distancia / 100, "km")
      Escreval(distancia, " metros em Dam são: ", distancia / 10, "km")
      Escreval(distancia, " metros em dm são: ", distancia * 10, "km")
      Escreval(distancia, " metros em cm são: ", distancia * 100, "km")
      Escreval(distancia, " metros em mm são: ", distancia * 1000, "km")

Fimalgoritmo