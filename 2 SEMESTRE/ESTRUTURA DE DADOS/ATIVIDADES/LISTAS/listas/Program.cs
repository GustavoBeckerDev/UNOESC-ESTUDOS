// ArrayLists

using System.Collections;
using System.Globalization;
using System.Linq;

// ArrayList arrayList = new ArrayList();

// // ADICIONANDO ITENS A LISTA

// arrayList.Add(5);

// // ADICIONANDO QUANTIAS DE ITENS A LISTA

// arrayList.AddRange(new int[]{ 1, 2, 3 });

// // INSERE O VALOR 7.8 NA POSICAO 3 DA LISTA

// arrayList.Insert( 3, 7.8);

// // PERCORRENDO ITENS DA LISTA DE FORMA GENÉRICA

// foreach (object obj in arrayList)
// {
//     Console.WriteLine(obj);
// }

// 26-08-2026 CONTINUIDADE EM ARRAY LIST

// LISTAS GENÉRICAS

List<double> numbers = new List<double>(); // NEW EU ESTOU INSTANCIANDO A VARIÁVEL 
Console.WriteLine("Digite 'sair' para encerrar.");

bool run = true;

do
{
    Console.WriteLine("\n\nDigite um número: ");
    string numberStr = Console.ReadLine() + "";

    if(numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("PROCESSO ENCERRADO");
        break;
    }
    else
    {
        // VALIDACAO DA ENTRADA DO USUARIO PARA CHECAR SE É DE FATO MUM NÚMERO:
        if(!double.TryParse(numberStr, System.Globalization.NumberStyles.Float, new NumberFormatInfo(), out double number))
        {
            Console.WriteLine("O VALOR DIGITADO NÃO É NUMÉRICO");
            continue;
        }

        numbers.Add(number);
        Console.WriteLine("A MÉDIA DOS VALORES INFORMADOS É: {0}", numbers.Average());


    }

} while(run);

 foreach (object obj in numbers)
{
    Console.Write(obj + " ");
    
}
// LISTAS DE TIPOS ABSTRATOS DE DADOS (TAD)
// CRIAR LISTA DO TIPO PERSON, UM TIPO ABSTRATO

List<Person> people = new List<Person>();

// CRIAR UMA VARIAVEL DO TIPO PERSON

// P1 É UMA VARIAVEL HETEROGENEA, ONDE ENCAPSULAMOS VÁRIAS INFORMAÇÕES DENTRO DELA
Person p1 = new Person();

p1.Name = "GUSTAVO";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

// ADICIONANDO À LISTA INLINE

people.Add( new Person()
{
    Name = "MARCELA",
    Age = 33,
    Nationality = CountryEnum.US
});

people.Add( new Person()
{
    Name = "CARLITOS",
    Age = 24,
    Nationality = CountryEnum.AR
});

people.Add( new Person()
{
    Name = "RUANITO",
    Age = 71,
    Nationality = CountryEnum.PY
});

// EXEMPLO DE ORDENAÇÃO DE LSITA GENÉRICA UTILIZANDO O LINQ

List<Person> results = 
    people.OrderBy( p => p.Name).ToList(); // ORDERBY É CRESCENTE POR PADRÃO

// PERCORRENDO A LISTA

foreach (Person p in results)
{
    Console.WriteLine
    (
        $"Nome: {p.Name} | Idade: {p.Age} | Nac: {p.Nationality}" 
    );
}

// ATIVIDADE, CRIAR UM PROJETO NOVO E FAZER A ATIVIDADE DAS LISTAS ORDENADAS DO CAPITULO 2 - PAG 68, 69 ATÉ LISTAS LINKADAS

