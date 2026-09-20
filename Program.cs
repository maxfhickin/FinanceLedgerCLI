using System;

namespace FinanceLedgerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View All");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("You picked option 1");
                }
                if (choice == "2")
                {
                    Console.WriteLine("You picked option 2");
                }
                if (choice == "3")
                {
                    Console.WriteLine("You picked option 3");
                    break;
                }
            }
        }
    }
}