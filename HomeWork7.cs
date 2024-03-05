namespace Homework7;

using System;

public class Customer
{
    public int cus_id {get;set;}
    public string cus_name;
    public int cus_age;

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine("Customer ID: " + this.cus_id + " Name: " + this.cus_name + " Age: " + this.cus_age);
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine(this.cus_age + " is older than " + objCustomer.cus_name);
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine(objCustomer.cus_name + " is older than " + this.cus_name);
        }
        else
        {
            Console.WriteLine(this.cus_name + " and " + objCustomer.cus_name + " are of the same age.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Customer cust1 = new Customer(110, "Alice", 28);
        Customer cust2 = new Customer(111, "Bob", 30);

        Console.WriteLine("Initial Customer Information:");
        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.ChangeID(220);
        cust2.ChangeID(221);

        cust1.PrintCusInfo();
        cust2.PrintCusInfo();

        cust1.CompareAge(cust2);
    }
}