using System;
using System.Collections.Generic;
using System.Text;

//The namespace declaration provides a way to logically organize your code.


namespace Classes;
//bank account is a class
//public means that other files in the application can talk to them 

public class BankAccount
{
    //Number, Owner, Balance are properties
    //There are five members of the BankAccount class. The first three are properties. Properties are data elements and can have code that enforces validation or other rules.
    public string Number { get; }
   //can get the number but once it is defined i cant set the number;
    public string Owner { get; set; }
    public decimal Balance { get {
      decimal balance = 0;
      foreach(var item in allTransactions)
      {
        // console.WriteLine($"item{item}");
         balance += item.Amount;
      }
      return balance;
    } }

    private static int accountNumberSeed = 1234567890;
   //  private List<Transaction> allTransactions = new List<Transaction>();
    private List<Transaction> allTransactions = new List<Transaction>();


     /*Creating a new object of the BankAccount type means defining a constructor that assigns those values. A constructor is a member that has the same name as the class. It's used to initialize objects of that class type. Add the following constructor to the BankAccount type. Place the following code above the declaration of MakeDeposit:
    */
    public BankAccount(string name, decimal initialBalance){

      //The this qualifier is only required when a local variable or parameter has the same name as that field or property. The this qualifier is omitted throughout the remainder of this article unless it's necessary.
         this.Owner = name;
         this.Number = accountNumberSeed.ToString();
         //increment so that the next bank account has a different acccount number;
         accountNumberSeed++;

        // DateTime.Now is a property that returns the current date and time. Test this code by adding a few deposits and withdrawals in your Main method, following the code that creates a new BankAccount:
         MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

         // account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
         // Console.WriteLine(account.Balance);
         // account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
         // Console.WriteLine(account.Balance); 
         
    }

    // makeDeposit and MakeWithdrawal are methods
    //he last two are methods. Methods are blocks of code that perform a single function. Reading the names of each of the members should provide enough information for you or another developer to understand what the class does.

   public void MakeDeposit(decimal amount, DateTime date, string note)
   {
      if (amount <= 0)
      {
         throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
      }
      var deposit = new Transaction(amount, date, note);
      allTransactions.Add(deposit);
   }

   public void MakeWithdrawal(decimal amount, DateTime date, string note)
   {
      if (amount <= 0)
      {
         throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
      }
      if (Balance - amount < 0)
      {
         throw new InvalidOperationException("Not sufficient funds for this withdrawal");
      }
      var withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
   }



   public string GetAccountHistory()
{
    var report = new System.Text.StringBuilder();

    decimal balance = 0;
    report.AppendLine("Date\t\tAmount\tBalance\tNote");
    foreach (var item in allTransactions)
    {
        balance += item.Amount;
        report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
    }

    return report.ToString();
}

      // public string GetAccountHistory()
      //   {
      //    //system builder for building strings.
      //       var report = new System.Text.StringBuilder();
      //       //HEADER in the REPORT
      //       report.AppendLine("Date\t\tAmount\tBalance\tNote");
      //       foreach(var item in allTransactions)
      //       {
      //          balance += item.Amount;
      //           //ROWS in the report
      //          report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");

      //       }
      //       return report.ToString();
      //   }

   

  // The throw statement throws an exception. Execution of the current block ends, and control transfers to the first matching catch block found in the call stack. You'll add a catch block to test this code a little later on.

  //THROWS AN EXCEPTION - STOPS THE PROGRAM!!!


}




    