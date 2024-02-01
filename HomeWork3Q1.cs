namespace HomeWork3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input an integer: ");
        string n = Console.ReadLine();
        int N = Convert.ToInt16(n);
        int a = 0;
        
        for (int i = 1; i <= N; i++) {
            if (N % i == 0) {
               a++;
            }
             }
            if (a == 2) {
                Console.WriteLine(N + " is prime");
            } else {
                Console.WriteLine(N + " is non-prime");
            }
        
    }
}
