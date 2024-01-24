namespace HomeWork2;

class Program
{
    static void Main(string[] args)
    {
      string letter = Console.ReadLine();
    
    switch(letter) 
    {

        case "A":
        Console.WriteLine("4");
        break;

        case "B":
        Console.WriteLine("3");
        break;

        case "C":
        Console.WriteLine("2");
        break;

        case "D":
        Console.WriteLine("1");
        break;

        case "F":
        Console.WriteLine("0");
        break;

        default:
        Console.WriteLine("Wrong Letter Grade!");
        break;
    }
    }
}
