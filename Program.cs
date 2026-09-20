using System;
using System.Collections.Generic;

namespace FinanceLedgerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transaction> transactions = new List<Transaction>(); // Creates a blank list to store the transactions

            while (true)
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View All");
                Console.WriteLine("3. View Total");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice here: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("\t\nYou picked option 1: Add Transaction\n");
                    Transaction transaction = new Transaction();
                    Console.Write($"\tTransaction Description: ");
                    transaction.Description = Console.ReadLine();
                    Console.Write($"\tTransaction Amount: ");
                    transaction.Amount = decimal.Parse(Console.ReadLine());
                    transaction.Date = DateTime.Now;
                    Console.WriteLine($"\tTransaction added: {transaction.Description}, £{transaction.Amount}, {transaction.Date}\n");
                    transactions.Add(transaction);
                }

                else if (choice == "2")
                {
                    Console.WriteLine("\n\tYou picked option 2\n");
                    Console.WriteLine($"\tNumber of transactions: {transactions.Count}\n");
                    foreach (Transaction t in transactions)
                    {
                        Console.WriteLine($"\tTransaction: {t.Description}, £{t.Amount}, {t.Date}");
                    }
                }

                else if (choice == "3")
                {
                    Console.WriteLine("\n\tYou picked option 3\n");
                    decimal total = 0;
                    foreach (Transaction t in transactions)
                    {
                        total += t.Amount;
                    }
                    Console.WriteLine($"\tTotal: £{total}\n");
                }

                else if (choice == "4")
                {
                    Console.WriteLine("Goodbye!");
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