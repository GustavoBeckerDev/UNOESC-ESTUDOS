// KEY => VALUE
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;

Hashtable phoneBook = new Hashtable()
{
    {"GUSTAVO BECKER", "47996609058"},
    {"MARCELA ALECRIM", "49999291103"},
    {"ALMIR CARLOS BECKER", "47985458525"}
};

// ADICIONAR ELEMENTOS DENTRO DO DICIONARIO

phoneBook["ACELINO POPÓ DE FREITAS"] = "9696565656";

// TRATANDO POSSÍVEL ERRO DE DUPLICIDADE DE CHAVE

try
{
    phoneBook.Add("GUSTAVO BECKER", "84656545956");
}
catch (System.ArgumentException ae)
{
    Console.WriteLine("Chave já existente" + ae.Message);
}
catch (System.Exception ex)
{
    Console.WriteLine("ERRO IMPREVISTO" + ex.Message);
};

// PERCORRENDO VALORES DENTRO DO HASTABLE

Console.WriteLine("CADERINNHO DE TELEFONE");

if (phoneBook.Count == 0)
{
    Console.WriteLine("AGENDA VAZIA");
}
else
{
    int i = 1;

    // DICTIONARYENTRY É UM TIPO QUE REPRESENTA O PAR CHAVE => VALOR
    foreach(DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine ($"{i}. {entry.Key} - {entry.Value}"); i++;
    };

}

// BUSCA DE VALORES EM CHAVE:

Console.WriteLine("");

Console.WriteLine("=== BUSCA POR NOME ===");

string name = Console.ReadLine();

Console.WriteLine("");

if (phoneBook.Contains(name))
{
    string number = (string) phoneBook [name];
    Console.WriteLine($"{name} - {number}");

}
else
{
    Console.WriteLine($"{name} NÃO ENCONTRADO");
}

// DICIONÁRIOS

// O MAPA HASH SÓ OPERA COM CHAVE DO TIPO STRING, JÁ O DICTIONARY PODE OPERAR COM CHAVE DE QUALQUER TIPO

Dictionary<string, string> dic = new Dictionary<string, string> ()
{
    {"DOM PEDRÃO II", "123456"},
    {"JOAQUIM JOSÉ DA SILVA XAVIER", "112233"}
};

// OBTENDO VALOR DO DICTIONARY

string value = dic["DOM PEDRÃO II"];

// ATRIBUIÇÃO

dic["DOM PEDRÃO II"] = "666";

// PERCORRER

foreach (KeyValuePair<string,string> pair in dic)
{
    Console.WriteLine("" + pair.Key + " " + pair.Value);
}







