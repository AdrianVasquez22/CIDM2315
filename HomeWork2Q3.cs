namespace HomeWork2Q3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input a year");
        string input = Console.ReadLine();
        int year = Convert.ToInt16(input);

        if(year%4 == 0 || year%400 == 0)
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else if(year%100 == 0 && year%400 == 0)
        {
            Console.WriteLine(year + " is not a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year");
        }
    }
}