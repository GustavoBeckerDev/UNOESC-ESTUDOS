using System;
using System.Globalization;

namespace RestaurantTable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CultureInfo cultureInfo = new CultureInfo("pt-BR");

            Console.WriteLine("The table number: ");
            string table = Console.ReadLine() + "";

            Console.WriteLine("The number of people: ");
            string countPeople = Console.ReadLine() + "";
            int.TryParse(countPeople, out int count);

            Console.Write("The reservation date (MM/DD/YYYY HH:mm): ");
            string dateTimeString = Console.ReadLine() + "";

            if (!DateTime.TryParseExact(
                dateTimeString,
                "M/d/yyy HH:mm",
                cultureInfo,
                DateTimeStyles.None,
                out DateTime dateTime
            ))
            {
                dateTime = DateTime.Now;
            }

            Console.WriteLine(
                "Table {0} has been booked for {1} people on {2} at {3}",
                table,
                count,
                dateTime.ToString("M/d/yyyy", cultureInfo),
                dateTime.ToString("HH:mm", cultureInfo)
            );

        }


    }




}