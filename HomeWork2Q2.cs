namespace HomeWork2Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num: ");
        string input1 = Console.ReadLine();
        int num1 = Convert.ToInt16(input1);
        Console.WriteLine("Please input the second num: ");
        string input2 = Console.ReadLine();
        int num2 = Convert.ToInt16(input2);
        Console.WriteLine("Please input the third num: ");
        string input3 = Console.ReadLine();
        int num3 = Convert.ToInt16(input3);

        if(num1 < num2 && num1 < num3)
        {
            Console.WriteLine("The smallest value is " + num1);
        }
        else if(num2 < num1 && num2 < num3)
        {
            Console.WriteLine("The smallest value is " + num2);
        }
        else if(num3 < num1 && num3 < num2)
        {
            Console.WriteLine("The smallest value is " + num3);
        }
        else
        {
            Console.WriteLine("There is not a smallest value");
        }
    }
}
