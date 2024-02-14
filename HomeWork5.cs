namespace HomeWork5;

class Program
{
    static void Max(int x,int y){

 
        if (x > y)
        {
           Console.WriteLine("The largest number is: " + x);
        }
        else
        {
            Console.WriteLine("The largest number is: " + y);
        }
    }

    
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        Max(a, b);
    }
}
