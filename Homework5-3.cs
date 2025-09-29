namespace Homework5_3;

class Program
{
    
    public static bool checkAge(int birth_year)
    {
        
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;

        
        return age >= 18;
    }

   

    
    public static void createAccount()
    {
        
        Console.Write("Enter username: ");
        string username = Console.ReadLine()!; 

       
        Console.Write("Enter password: ");
        string password = Console.ReadLine()!;

        
        Console.Write("Confirm password: ");
        string password_confirm = Console.ReadLine()!;

        
        Console.Write("Enter birth year (e.g., 2000): ");
      
        if (!int.TryParse(Console.ReadLine(), out int birthyear))
        {
            Console.WriteLine("Invalid year entered. Could not create an account.");
            return; 
        }

        
        if (checkAge(birthyear))
        {
            
            if (password.Equals(password_confirm)) 
            {
                
                Console.WriteLine("\nAccount is created successfully! Welcome, " + username + ".");
            }
            else
            {
                
                Console.WriteLine("\nWrong password. Passwords do not match.");
            }
        }
        else
        {
            
            Console.WriteLine("\nCould not create an account. Must be 18 years or older.");
        }
    }

    
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Starting Account Creation Process ---");
        createAccount();
}
}
