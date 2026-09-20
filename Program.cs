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
                Console.Write("Enter your choice here: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("You picked option 1");
                    Transaction transaction = new Transaction();
                    Console.Write("Transaction Description: ");
                    transaction.Description = Console.ReadLine();
                    Console.Write("Transaction Amount: ");
                    transaction.Amount = decimal.Parse(Console.ReadLine());
                    transaction.Date = DateTime.Now;
                    Console.WriteLine($"Transaction added: {transaction.Description}, £{transaction.Amount}, {transaction.Date}");
                }

                else if (choice == "2")
                {
                    Console.WriteLine("You picked option 2");
                }

                else if (choice == "3")
                {
                    Console.WriteLine("You picked option 3");
                    break;
                }
                
                else
                {
                    Console.WriteLine("Invalid Choice. Please try again.");
                }
            }
        }
    }
    public class Transaction
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}