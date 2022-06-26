using System;
using System.Globalization;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            string item = vet[0];
            int quantidade = int.Parse(vet[1]);

            if (item == "1")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "2")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 4.50).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "3")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 5.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "4")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 2.00).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (item == "5")
            {
                Console.WriteLine("Total: R$ " + (quantidade * 1.50).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}