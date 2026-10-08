using System.Collections;
using System.Collections.Generic;

Dictionary<string, string> products = new Dictionary<string, string> ()
{
    {"59000000000", "A1"},
    {"59111111111", "B1"},
    {"59222222222", "C1"}
};

products["59333333333"] = "D7";

try
{
  products.Add("59444444444", "A3");  
}
catch (ArgumentException)
{
    Console.WriteLine("THE ENTRY ALREADY EXISTS");
};

Console.WriteLine("");
Console.WriteLine("ALL PRODUCTS: ");

if (products.Count == 0)
{
    Console.WriteLine("THE PRODUCTS LIST HAS EMPTY");
}
else
{
    int i = 1;
    foreach (KeyValuePair<string, string> prd in products)
    {
        Console.WriteLine($"{i} . {prd.Key} - {prd.Value}"); i++;
    }
}

Console.WriteLine("");
Console.WriteLine("SEARCH BY BARCODE: ");

string barcode = Console.ReadLine();

if (products.TryGetValue(barcode, out string location))
{
    Console.WriteLine($"THE PRODUCT IS IN THE AREA {location}");
}
else
{
    Console.WriteLine("THE PRODUCT DOES NOT EXIST");

    Console.WriteLine("DESEJA ADICIONAR O PRODUTO? [S/N]");
    string op = Console.ReadLine();

    if (op == "S")
    {
        Console.Write("LOCATION: ");
        string lc = Console.ReadLine();
        products.Add(barcode, lc);
    }
    else
    {
        Console.WriteLine("OK, THANKS");
    }
};

Console.WriteLine("");
Console.WriteLine("LISTAGEM FINAL DOS PRODUTOS.");

int j = 1;
foreach (KeyValuePair<string, string> prd in products)
{
    Console.WriteLine($"{j}. {prd.Key} | {prd.Value}");
};
