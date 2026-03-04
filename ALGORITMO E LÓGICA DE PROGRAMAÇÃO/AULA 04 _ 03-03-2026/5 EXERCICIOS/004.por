programa
{

	// Utilizando o seguinte trecho de algoritmo:

	// inteiro: x, y;
	// real: z;
	// imprima (“Informe o valor de x”);
	// ler (x);
	// imprima (x, “elevado ao cubo=”, pot(x,3));
	// imprima (“Informe o valor de y”);
	// ler (y);
	// imprima (x + y);
	// z = x/y;
	// imprima (“O valor de z é:”, z);
	// z=z+1;
	// x=(y+x) mod 2;
	// escreva (x);
	
	inteiro x, y
	real z
	
	funcao inicio()
	{
		
		escreva("Informe o valor de x: ")
		leia(x)
		
		escreva(x, " elevado ao cubo= ", x * x * x, "\n")

		escreva("Informe o valor de y: \n")
		leia(y)

		escreva("A soma de ", x, " + ", y, " é igual a: ", x + y, "\n")

		z = x / y

		escreva("O valor de z é: ", z, "\n")

		z = z + 1

		x = (x + y) % 2

		escreva("O valor final de x é: ", x, "\n")
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 408; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */