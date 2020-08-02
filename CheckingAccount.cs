using System;

class CheckingAccount : BankAccount
{
  private double balance;

  public double Balance
  {
    get
    {
      return  balance;
    }
    set
    {
      if (value < 500.00)
      Console.WriteLine ("Checking Account must have at least $500.");
      else 
      balance = value;
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
          Console.WriteLine("Total Balance: " + "$" + Balance);
        }
    public override void CalculateInterest()
        {
          double x = 0.0075;
         double balanceI_C = (Balance * x) + Balance;
          Console.WriteLine("Added Interest and Updated Balance: $" + balanceI_C);
        }
    
     public override void Withdraw(double amount)
        {
           double newbalance = Balance - amount;
            if (Balance >= 500.00)
              Console.WriteLine("New Balance is: $" + newbalance);
            else
            Console.WriteLine("Innsuficient Funds. Cannot Withdraw Desired Amount.");
        }
        public void Deposit(double amount)
        {
          double newtotal = (Balance + amount);
           Console.WriteLine ("Deposit Successful.");
           Console.WriteLine ("New Balance is: " + newtotal);
        }
}