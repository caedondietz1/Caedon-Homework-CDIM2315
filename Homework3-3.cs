namespace Homework3_3;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Assign an int value to N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Outer loop for the number of rows
        for (int i = 1; i <= n; i++)
        {
            // Inner loop for the number of columns (stars)
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            // Move to the next line after each row is printed
            Console.WriteLine();
        }
    }
}

