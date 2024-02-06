namespace HomeWork4;

class Program
{
    static void Input(){
        
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
 
        if (a > b)
        {
            Console.WriteLine("The largest number is: " + a);
        }
        else {
            Console.WriteLine("The largest number is: " + b);
        }
    }
 
    public static void Main() 
    { 
        Input();
    }
    
}
