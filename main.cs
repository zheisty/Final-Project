using System;

class MainClass
{
  public static void Main (string[] args) 
  {
   Console.WriteLine("Bank Information:");
   BankAccount b1 = new BankAccount();
   b1.Name = "Zachary Heisterkamp";
   b1.AccountNumber = "123456";
   b1.DateCreated = Convert.ToDateTime("07/29/2005");
   b1.Balance = 10000;
   b1.DisplayAccountInfo();
   

  Console.WriteLine("");

  Console.WriteLine("Savings Account Information:");
   SavingsAccount s1 = new SavingsAccount();
   s1.Name = "Zachary Heisterkamp";
   s1.AccountNumber = "123456";
   s1.DateCreated = Convert.ToDateTime("07/29/2005");
   s1.Balance = 2500;  
   s1.DisplayAccountInfo();
   s1.Withdraw(500);
   s1.Deposit(111);
   s1.CalculateInterest();
   

   Console.WriteLine("");

   Console.WriteLine("Checking Account Information:");
   CheckingAccount c1= new CheckingAccount();
   c1.Name = "Zachary Heisterkamp";
   c1.AccountNumber = "123456";
   c1.DateCreated = Convert.ToDateTime("07/29/2005");
   c1.Balance = 500;
   c1.DisplayAccountInfo();
   c1.Withdraw(10);
   c1.Deposit(111);
   c1.CalculateInterest();
  }
}