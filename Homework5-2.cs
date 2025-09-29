namespace Homework5_2;

class Program
{
    
    public static int LargestOfTwo(int a, int b)
    {
        return Math.Max(a, b);
    }

    
    public static int GetLargestOfFourFromInput()
    {
        

        Console.Write("Enter the first integer (a): ");
        int a = int.Parse(Console.ReadLine()!); 
        
        Console.Write("Enter the second integer (b): ");
        int b = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter the third integer (c): ");
        int c = int.Parse(Console.ReadLine()!);
        
        Console.Write("Enter the fourth integer (d): ");
        int d = int.Parse(Console.ReadLine()!);
        
        
        Console.WriteLine($"\na = {a}; b = {b}; c = {c}; d = {d}");

        
        
        
        int max1 = LargestOfTwo(a, b); 
        
        
        int max2 = LargestOfTwo(c, d); 
        
        
        return LargestOfTwo(max1, max2); 
    }

    
    public static void Main(string[] args)
    {
        
        int largest = GetLargestOfFourFromInput(); 
        
        
        Console.WriteLine($"The largest number is: {largest}");
}
}
