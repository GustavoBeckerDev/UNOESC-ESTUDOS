programa
{

	//  Entrar com dois números inteiros (dividendo e divisor) e imprimir a seguinte saída:
	
	// a) Dividendo;
	// b) Divisor;
	// c) Quociente;
	// d) Resto.
	
	inteiro divd, divs
	real quo, rest
	
	funcao inicio()
	{
		escreva("ALGORITMO DIVIDENDO / DIVISOR / QUOCIENTE / RESTO \n")

		escreva("Digite o número dividendo: ")
		leia(divd)
		escreva("Digite o número divisor: ")
		leia(divs)

		quo = divd / divs

		rest = divd % divs
		
		escreva("A divisão que iremos fazer é: ", divd, " / ", divs, ". \n")

		escreva("O número divivendo é: ", divd, "\n")
		escreva("O número divisor é: ", divs, "\n")
		escreva("O número quociente é: ", quo, "\n")
		escreva("O número resto é: ", rest, "\n")
		
	}

}
	
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 514; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */