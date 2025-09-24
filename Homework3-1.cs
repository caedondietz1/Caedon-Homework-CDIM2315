namespace Homework3_1;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Input an integer: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 1)
        {
            Console.WriteLine($"{n} is non-prime");
            return;
        }

        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{n} is prime");
        }
        else
        {
            Console.WriteLine($"{n} is non-prime");
        }
    }
}

