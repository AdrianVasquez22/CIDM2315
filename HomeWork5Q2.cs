namespace HomeWork5Q2;

class Program
{
    static int Max(int x,int y){

 
        if (x > y)
        {
           return x;
        }
        else
        {
            return y;
        }
    }

    
    static void Main(string[] args)
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("D = ");
        int d = int.Parse(Console.ReadLine());

        int max1 = Max(a, b);
        int max2 = Max(c, d);
        int max3 = Max(max1, max2);

        Console.WriteLine("The largest number is: " + max3);
    }
}
