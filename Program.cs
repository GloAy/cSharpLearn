// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* HARDCODED
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Sophia: " + sophiaScore + " A");
Console.WriteLine("Nicolas: " + nicolasScore + " B");
Console.WriteLine("Zahirah: " + zahirahScore + " B");
Console.WriteLine("Jeong: " + jeongScore + " A");

EFFICIENT ***
using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public List<int> Grades { get; set; }

    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0.0;
        }

        return Grades.Average();
    }

    public char GetGradeLetter()
    {
        double average = CalculateAverageGrade();

        if (average >= 90.0)
        {
            return 'A';
        }
        else if (average >= 80.0)
        {
            return 'B';
        }
        else if (average >= 70.0)
        {
            return 'C';
        }
        else if (average >= 60.0)
        {
            return 'D';
        }
        else
        {
            return 'F';
        }
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sophia", Grades = new List<int> { 93, 87, 98, 95, 100 } },
            new Student { Name = "Nicolas", Grades = new List<int> { 80, 83, 82, 88, 85 } },
            new Student { Name = "Zahirah", Grades = new List<int> { 84, 96, 73, 85, 79 } },
            new Student { Name = "Jeong", Grades = new List<int> { 90, 92, 98, 100, 97 } }
        };

        Console.WriteLine("Student\t\tGrade");
        foreach (var student in students)
        {
            double averageGrade = student.CalculateAverageGrade();
            char gradeLetter = student.GetGradeLetter();

            Console.WriteLine($"{student.Name}\t\t{averageGrade:F1}\t{gradeLetter}");
        }
    }
}
*/

using System;
using Classes;

namespace MySuperBank 
{
    class Program 
    {
     static void Main(string[] args)
     {
        var account = new BankAccount("Goncagul", 10000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

        account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        //Console.WriteLine(account.Balance);

        account.MakeWithdrawal(500, DateTime.Now, "Mattress");
        //Console.WriteLine(account.Balance);

        




        // account.MakeDeposit(-300, DateTime.Now, "Stealing");
        // Console.WriteLine(account.Balance);


        // Test for a negative balance.
        try
        {
            account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
        }
        catch (InvalidOperationException e)
        {
           // Console.WriteLine("Exception caught trying to overdraw");
           // Console.WriteLine(e.ToString());
        }

         Console.WriteLine(account.GetAccountHistory());
       // Test that the initial balances must be positive.
        // BankAccount invalidAccount;
        // try
        // {
        //     invalidAccount = new BankAccount("invalid", -55);
        // }
        // catch (ArgumentOutOfRangeException e)
        // {
        //     Console.WriteLine("Exception caught creating account with negative balance");
        //     Console.WriteLine(e.ToString());
        //     return;
        // }

        
       
    
     } 
    }
}


//ONE FILE PER CLASS;