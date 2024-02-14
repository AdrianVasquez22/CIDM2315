namespace HomeWork5Q3;

class Program
{
    static bool checkAge(int birth_year){

        int a = 2024 - birth_year;

        if(a >= 18)
        {
            return true;
        }
        else 
        {
            return false;
        }
} 

    static void createAccount(){
        Console.WriteLine("Enter your username: ");
        string name = Console.ReadLine();
// ask user to input username
        Console.WriteLine("Enter your password: ");
        string pass1 = Console.ReadLine();
// ask user to input password
        Console.WriteLine("Enter your password again: ");
        string pass2 = Console.ReadLine();
// ask user to input password again
        Console.WriteLine("Enter your birthyear: ");
        int birth_year = int.Parse(Console.ReadLine());
// ask user to input birthyear
        checkAge(birth_year);

         if(checkAge(birth_year) == true && pass1 == pass2)
        {
            Console.WriteLine("Account is created successfully");
        }
        else if(checkAge(birth_year) == true && pass1 != pass2)
        {
            Console.WriteLine("Wrong password");
        }
        else
        {
            Console.WriteLine("Could not create account");
        }
        

// call checkAge(birthyear) method to check if age is greater than 18
// if checkAge(birthyear) returns true, 
//then check if two passwords are same, if passwords are same, print “Account is created successfully”
// else print “Wrong password”
	// if checkAge(birthyear) returns false, print “Could not create an account”
} //4 points



    static void Main(string[] args)
    {
        createAccount();
    }
}
