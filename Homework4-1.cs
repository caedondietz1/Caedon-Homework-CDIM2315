namespace Homework4;

class Program
{       
    public static int FindLargest(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 5;
        
        
        int largestNumber = FindLargest(a, b);
        
        
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}

