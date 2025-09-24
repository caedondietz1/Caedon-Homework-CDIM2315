namespace Homework4_2;

class Program
{

 
    public static void PrintTriangle(int N, string shape)
    {
        
        Console.WriteLine($"N is: {N}; shape is {shape}");

        if (shape.ToLower() == "left")
        {
            
            for (int i = 1; i <= N; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
        else if (shape.ToLower() == "right")
        {
            
            for (int i = 1; i <= N; i++)
            {
                
                for (int j = 1; j <= N - i; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
        else
        {
            
            Console.WriteLine("Invalid shape. Please choose 'left' or 'right'.");
        }
    }

    
    public static void Main(string[] args)
    {
        
        PrintTriangle(5, "left");
        Console.WriteLine(); 

        
        PrintTriangle(5, "right");
    }
}
