using System;
using System.Xml.Linq;

class Day03
{
    static void Main()
    {
        Student s1 = new Student("Hasan", 23, "A");
        s1.Display();

        Console.WriteLine("Bank Account");

        BankAccount acc = new BankAccount(1000);

        acc.Deposit(500);
        acc.Withdraw(300);
        acc.Withdraw(1500);

        Console.WriteLine("Employee");

        Employee emp = new Employee("Hasan", 5000, 800);
        emp.Display();
    }
}
class Student
{
    public string Name;
    public int Age;
    public string Grade;

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Depsited: " + amount);
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
            Console.WriteLine("Insufficient balance!");
        else
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
    }

    public double GetBalance()
    {
        return balance;
    }
}

public class Employee
{
    private string name;
    private double salary;
    private double bonus;

    public Employee(string name, double salary, double bonus)
    {
        this.name = name;
        SetSalary(salary);
        this.bonus = bonus;
    }

    public void SetSalary(double value)
    {
        if (value <= 0)
        {
            Console.WriteLine("Invalid salary!");
            salary = 0;
        }
        else
            salary = value;
    }

    public double GetTotalSalary()
    {
        return salary + bonus;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("Bonus: " + bonus);
        Console.WriteLine("Total Salary: " + GetTotalSalary());
    }
}