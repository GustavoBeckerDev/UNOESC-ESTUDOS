Algoritmo "semnome"

// 17) Escreva um programa que pergunte a velocidade de um carro. Caso ultrapasse
// 80Km/h, exiba uma mensagem dizendo que o usuário foi multado. Nesse caso, exiba
// o valor da multa, cobrando R$5 por cada Km acima da velocidade permitida.

Var

   velocidade, kmAcima, valorMulta: real

Inicio

       Escreva("Velocidade do carro (Km/h): ")
       leia(velocidade)
       
       Se velocidade > 85 Entao
            kmAcima <- velocidade - 85
            valorMulta <- kmAcima * 5
            Escreval("Você passou ", kmAcima, " quilômetro(s) acima da velocidade permitida (85km/h).")
            Escreval("O valor da multa será: R$", valorMulta, ".")
       Senao
            Escreval("Velocidade dentro da permitida.")
       Fimse

Fimalgoritmo