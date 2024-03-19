namespace HomeWork8;

class Program
{

    public static void Main (string[] args) {
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);

        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        PrintAllOddNumber(array_2d);

        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }


    public static void ArraySum(int[] int_array)
    {
        int sum = 0;
        foreach (int num in int_array)
        {
            sum += num;
        }
        Console.WriteLine("The sum of int_array is: " + sum);
    }


    public static void PrintAllOddNumber(int[ , ] array_2d){
        for(int num1 = 0; num1 < array_2d.GetLength(0); num1++)
        {
            for(int num2 = 0; num2 < array_2d.GetLength(1); num2++)
            {   
                if(array_2d[num1, num2] % 2 != 0)
                {
                    Console.Write(array_2d[num1, num2] + " ");
                }
            }
        }

    }

    public static int ElementSum(int[ , ] array_2d){
        int sum = 0;
        for(int num1 = 0; num1 < array_2d.GetLength(0); num1++)
        {
            for(int num2 = 0; num2 < array_2d.GetLength(1); num2++)
            { 
                sum += array_2d[num1, num2];
            }

        }
        return sum;
    }

    public static int[ , ] DoubleArray(int[ , ] array_2d){
        int[,] doubledArray = new int[array_2d.GetLength(0), array_2d.GetLength(1)];
        for (int num1 = 0; num1 < array_2d.GetLength(0); num1++)
        {
            for (int num2 = 0; num2 < array_2d.GetLength(1); num2++)
            {
                doubledArray[num1, num2] = array_2d[num1, num2] * 2;
            }
       
        }  
        return doubledArray;
    }
}

