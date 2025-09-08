namespace Homework1;

class Program
{
   { // 1. Get the first number from the user
        Console.WriteLine("Please input the first num:");
        short num1 = Convert.ToInt16(Console.ReadLine());

        // 2. Get the second number
        Console.WriteLine("Please input the second num:");
        short num2 = Convert.ToInt16(Console.ReadLine());
        
        // 3. Get the third number
        Console.WriteLine("Please input the third num:");
        short num3 = Convert.ToInt16(Console.ReadLine());

        // 4. Find the smallest number using a nested if statement
        short smallest;

        if (num1 = num2)
        {
            if (num1 = num3)
            {
                smallest = num1;
            }
            else
            {
                smallest = num3;
            }
        }
        else
        {
            if (num2 = num3)
            {
                smallest = num2;
            }
            else
            {
                smallest = num3;
            }
        }

        // 5. Print the smallest value
        Console.WriteLine("The smallest value is: " + smallest);
    }
}