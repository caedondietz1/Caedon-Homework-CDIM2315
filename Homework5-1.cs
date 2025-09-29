namespace Homework5_1;

class Program
{
    
    public static int GetLargestNumberFromInput()
    {
        
        Console.Write("Enter the first integer (a): ");
        
        int a = int.Parse(Console.ReadLine()!);

        
        Console.Write("Enter the second integer (b): ");
        int b = int.Parse(Console.ReadLine()!);

        
        Console.WriteLine($"\na = {a}; b = {b}");

        

        
        return Math.Max(a, b);
    }

    
    public static void Main(string[] args)
    {
        

        
        int largest = GetLargestNumberFromInput();

        
        Console.WriteLine($"The largest number is: {largest}");
    }

}
