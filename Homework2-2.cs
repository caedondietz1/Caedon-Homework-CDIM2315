namespace Homework2_2;

class Program
{
    int num1 = 12;
    int num2 = 11;
    int num3 = 14; 
    
    public class FindSmallest
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        int smallest = num1;

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest = num3;
        }

        Console.WriteLine("The smallest value is: " + smallest);
    }
}
}
       
