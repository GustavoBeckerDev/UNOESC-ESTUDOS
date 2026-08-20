using System.Globalization;

// EXEMPLO DOS NOMES DOS MESES DO ANO:

string[] months = new string[12];

for (int i = 1; i <= 12; i ++)
{
    DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);

    DateTime lastDayMonthBefore = firstDay.AddDays(-1);

    string monthName = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-BR"));

    months[i - 1] = monthName;
}

foreach (string monthName in months) // PARA CADA STRING CONTIDA EM MESES
{
    Console.WriteLine($"---> {monthName}"); // $ O CIFRÃO É UMA INTERPOLAÇÃO, SUBSTITUI A CONCATENAÇÃO
}