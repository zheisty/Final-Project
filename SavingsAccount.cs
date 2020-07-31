using System;

 class SavingsAccount : BankAccount
    {
        private double sbalance;

        public double SBalance
        //Balance cannot be under 2500.0 
        {
            get
            {
                return sbalance;
            }

            set
            {
                if (value < 2500.0)
                     Console.WriteLine("Innsuficient Funds for Savings Account");
                else
                    sbalance = value;
            }
        }

        public override void AccountA ()
        {
          base.AccountA();
        }

        public override void AccountA (string nameA, string accountnumberA, DateTime dateA)
        {
          base.AccountA();
        }

        public override void DisplayAccountInfo()
        {
          Console.WriteLine("Name: " + Name);
          Console.WriteLine("Account Number: " + AccountNumber);
          Console.WriteLine("Total Balance: " + "$" + SBalance);
        }

        public void CalculateInterest()
        {
          double x = 0.05;
          double balanceI_S = (SBalance * x) + SBalance;
          Console.WriteLine("Added Interest and Updated Balance: $" + balanceI_S);
        }

        public void Withdraw(double amount)
        {
           double newbalanceS = SBalance - amount;
            if (SBalance >= 2500.00)
              Console.WriteLine("New Balance is: $" + newbalanceS);
            else
            Console.WriteLine("Innsuficient Funds. Cannot Withdraw Desired Amount.");
        }
    }