namespace Homework3_2;

class Program
{
public class SquarePattern
{
    public static void Main(string[] args)
    {
        Console.Write("Assign an int value to N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Outer loop for the number of rows
        for (int i = 0; i < n; i++)
        {
            // Inner loop for the number of columns
            for (int j = 0; j < n; j++)
            {
                Console.Write("#");
            }
            // Move to the next line after each row is printed
            Console.WriteLine();
        }
    }
}
}

