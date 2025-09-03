/*

Create an ATM class with private attributes accountBalance and pin. 
Provide methods for deposit(), withdraw(), and checkBalance() 
Implement a private method to verify the PIN before allowing any transaction. 
Ensure that if the PIN is incorrect, no transactions are allowed, and ensure the balance can't be negative.


*/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ATM
    {
        private double accountBalance;
        private int pin;
        private string name;



        public ATM(double Balance, int EnteredPin, string EnteredName)
        {
            accountBalance = Balance;
            pin = EnteredPin;
            name = EnteredName;

        }
        public void SetPin(int pin)
        {
            this.pin = pin;
        }

        public int GetPin()
        {
            return this.pin;
        }

        public string GetName()
        {
            return this.name;
        }


        public double GetAccountBalance()
        {
            return this.accountBalance;
        }

        public void SetAccountBalance(double accountBalance)
        {
            this.accountBalance = accountBalance;
        }

        public double Deposit(double deposit)
        {
            return accountBalance += deposit;
        }

        public double Withdraw(double withdraw)
        {
            return accountBalance -= withdraw;
        }

        public double CheckBalance(double balance)
        {
            return this.accountBalance;
        }

        public bool VerifyPin(int EnteredPin) {
        if (EnteredPin == this.pin)
            {
                return true;
            }
        else
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(string[] args) // after pin, check balance
        {
            ATM Account = new ATM(30000, 5678, "Ruel");

            int Transact;
            do
            {
                Console.Write("Enter your 4-Digit PIN: ");
                int EnteredPin = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Hello, " + Account.GetName());
                Console.WriteLine("Balance is: " + Account.GetAccountBalance());

                if (Account.GetAccountBalance() < 0)
                {
                    Console.WriteLine("Balance is Negative.");
                }

                if (Account.VerifyPin(EnteredPin))
                {
                    Console.WriteLine("Would you like to\n 1 --> Deposit \n 2 --> Withdraw ");
                    int brand = Convert.ToInt32(Console.ReadLine());

                    switch (brand)
                    {
                        case 1:
                            Console.WriteLine("How Much?");
                            int EnteredDeposit = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("New balance is: " + Account.Deposit(EnteredDeposit));
                            break;

                        case 2:
                            Console.WriteLine("How Much?");
                            int EnteredWithdraw = Convert.ToInt32(Console.ReadLine());

                            if (EnteredWithdraw > Account.GetAccountBalance())
                            {
                                Console.WriteLine("Withdrawal amount is too big for your balance.");
                            }
                            else
                            {
                                Console.WriteLine("You have withdrawed: " + EnteredWithdraw);
                                Console.WriteLine("New Balance is: " + Account.Withdraw(EnteredWithdraw));
                            }
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("PIN is incorrect.");
                }


                Console.WriteLine("Would you like to transact again?\n 1 --> Yes \n 2 --> No");
                Transact = Convert.ToInt32(Console.ReadLine());

            }

            while (Transact == 1);
        }
    }
}
