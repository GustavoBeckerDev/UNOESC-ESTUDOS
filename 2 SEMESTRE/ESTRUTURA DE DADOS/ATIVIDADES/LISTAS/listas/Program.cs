// ArrayLists

using System.Collections;

ArrayList arrayList = new ArrayList();

// ADICIONANDO ITENS A LISTA

arrayList.Add(5);

// ADICIONANDO QUANTIAS DE ITENS A LISTA

arrayList.AddRange(new int[]{ 1, 2, 3 });

// INSERE O VALOR 7.8 NA POSICAO 3 DA LISTA

arrayList.Insert( 3, 7.8);

// PERCORRENDO ITENS DA LISTA DE FORMA GENÉRICA

foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
}

