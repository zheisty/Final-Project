using System;

class BankAccount
{
private string accountnumber;
private string name;
private double balance;
private DateTime datecreated;


public string Name {get;set;}
public string AccountNumber 
//Account number needs to be 6 figures long
{
  get
  {
    return accountnumber;
  }

set
  {
    if (value.Length == 6)
      accountnumber = value;
    else
      Console.WriteLine ("Invalid Input for Account Number!");
  }
}
public double Balance 
//Balance cannot go under 0.0 without overdraft
{
  get
  {
    return balance;
  }

set
  {
    if (value < 0.0)
      Console.WriteLine("Balance is Overdrawn");
    else
      balance = value;
  }
}

public DateTime DateCreated 
//the date entered cannnot be greater than the present date
{
  get
  {
    return datecreated;
  }

set
  {
    if (value > DateTime.Now)
      Console.WriteLine ("Invalid Date entered");
    else
      datecreated = value;
  }
}
//Constructor with no parameter
public virtual void AccountA()
{

DateCreated = DateTime.Now;
}

public virtual void AccountA(string nameA, string accountnumberA, DateTime dateA)
{
 
DateCreated = DateTime.Now;
}
public virtual void DisplayAccountInfo()
{
Console.WriteLine("Name: " + Name);
Console.WriteLine("Account Number: " + AccountNumber);
Console.WriteLine("Total Balance: " + "$" + Balance);
}
public void Deposit(double amount)
{
  double newtotal = (Balance + amount);
  Console.WriteLine ("Deposit Successful.");
  Console.WriteLine ("New Balance is: " + newtotal);
}
public virtual void Withdrawl(double amount)
{
  double newbalance = Balance - amount;
if (Balance > amount)
  Console.WriteLine("New Balance is: " + newbalance);
else
  Console.WriteLine("Innsuficient Funds. Cannot Withdrawl Desired Amount.");
}
public void Interest()
{
  double x = 0.05;
  double balanceI = (Balance * x) + Balance;
  Console.WriteLine("This method will calculate interest");
}
}