using System;

class CheckingAccount : BankAccount
{
  private double cbalance;

  public double CBalance
  {
    get
    {
      return  cbalance;
    }
    set
    {
      if (value < 500.00)
      Console.WriteLine ("Checking Account must have at least $500.");
      else 
      cbalance = value;
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
          Console.WriteLine("Total Balance: " + "$" + CBalance);
        }
    public void CalculateInterest()
        {
          double x = 0.0075;
          double balanceI_C = (CBalance * x) + CBalance;
          Console.WriteLine("Added Interest and Updated Balance: $" + balanceI_C);
        }
    
     public void Withdraw(double amount)
        {
           double newbalanceC = CBalance - amount;
            if (CBalance >= 500.00)
              Console.WriteLine("New Balance is: $" + newbalanceC);
            else
            Console.WriteLine("Innsuficient Funds. Cannot Withdraw Desired Amount.");
        }
}