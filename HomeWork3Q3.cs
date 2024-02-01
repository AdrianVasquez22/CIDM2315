namespace HomeWork3Q3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer: ");
        string num = Console.ReadLine();
        int N = Convert.ToInt32(num);

        for(int i = 0;  i < N; i++){
            for(int j = 0; j < N; j++){
                if(i >= j)
                    Console.Write("*");
            }
                Console.WriteLine("");
        }
    }
}

