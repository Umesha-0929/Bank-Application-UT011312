using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Of Ceylon");
            Console.WriteLine("================================");
            Console.WriteLine("Welcome To BANK OF CEYLON");
            Console.WriteLine("================================");

            string bankName = "Bank Of Ceylon";
            string accountHolder = "Mr.Paul";
            long accountNumber = 776767836783;
            decimal accountBalance = 5000.00m;

            List<string> transactions = new List<string>();

            Console.WriteLine("======Account Details======");
            Console.WriteLine("Bank Name : " + bankName);
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Current Balance : Rs." + accountBalance);

            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", Welcome To BOC");

            Console.Write("Enter Your Opening Balance: ");
            decimal openingBalance = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Your Opening Balance Is Rs." + openingBalance);

            Console.Clear();
            bool running = true;
            while (running)
            {

                Console.WriteLine("======Simple Banking App======");
                Console.WriteLine("1. View Account");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Transactions");
                Console.WriteLine("6. Exit");
                Console.WriteLine("===============================");
                Console.Write("Choose An Option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {



                    case 1:
                        Console.WriteLine("--- Account Details ---");
                        Console.WriteLine("Bank Name      : " + bankName);
                        Console.WriteLine("Account Holder : " + accountHolder);
                        Console.WriteLine("Account Number : " + accountNumber);
                        break;

                    case 2:
                        Console.WriteLine("Current Balance : Rs." + accountBalance);
                        break;

                    case 3:
                        Console.Write("Enter Deposit Amount: ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());

                        if (deposit > 0)
                        {
                            accountBalance += deposit;
                            transactions.Add("Deposited Rs." + deposit);

                            Console.WriteLine("Deposit Successful!");
                            Console.WriteLine("Updated Balance : Rs." + accountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Deposit Amount!");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Withdraw Amount: ");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());

                        if (withdraw > 0 && withdraw <= accountBalance)
                        {
                            accountBalance -= withdraw;
                            transactions.Add("Withdrawn Rs." + withdraw);

                            Console.WriteLine("Withdraw Successful!");
                            Console.WriteLine("Updated Balance : Rs." + accountBalance);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Withdraw Amount!");
                        }
                        break;


                    case 5:
                        Console.WriteLine("---- Transactions ----");

                        if (transactions.Count > 0)
                        {
                            foreach (string t in transactions)
                            {
                                Console.WriteLine(t);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Transactions Yet");
                        }

                        break;

                    case 6:

                        Console.WriteLine("Exit");
                        if (running)
                            Console.Clear();

                        Console.WriteLine("Thank You For Using BOC Bank!");
                        Console.ReadKey();


                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

                Console.ReadKey();
                Console.Clear();

                static void ShowWelcome()
                {
                    Console.WriteLine("Welcome To BoC Bank");
                }
                static void ShowMenu()
                {
                    Console.WriteLine("1.Deposit:");
                }
                static void ShowDetails()
                {
                    Console.WriteLine("Account Details");
                }
                static void Deposit()
                {
                    Console.WriteLine("Deposit Process");
                }
                static void Withdrawal()
                {
                    Console.WriteLine("Withdarwal Process");
                }

            }
        }


        class BankAccount
        {
            public string AccountHolder { get; set; }

            public long AccountNumber { get; set; }

            public decimal Balance { get; private set; }

            public void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public bool Withdraw(decimal amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    return true;
                }

                return false;

                List<string> transactions = new List<string>();
                foreach (string t in transactions)
                {
                    transactions.Add(t);
                }
                transactions.Add("Deposited 1000");
                transactions.Add("Withdraw 500");
                Console.WriteLine("No Transactions Yet");
            }
        }
    }
}
