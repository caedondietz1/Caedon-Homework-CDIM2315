namespace Homework8_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Test 1: Object Creation and Print ---");
        
        Customer customer1 = new Customer(101, "Alice Smith", 30);
        customer1.PrintCusInfo(); 

        
        Console.WriteLine("\n--- Test 2: ChangeID Method ---");
        customer1.ChangeID(202);
        customer1.PrintCusInfo();

        
        Console.WriteLine("\n--- Test 3: CompareAge Method ---");
        
        Customer customer2 = new Customer(102, "Bob Johnson", 35);
        
        
        customer1.CompareAge(customer2); 

        
        customer2.CompareAge(customer1);
        
        
        Customer customer3 = new Customer(103, "Charlie Brown", 35);
        
        
        customer2.CompareAge(customer3); 
    }

    public class Customer
{
    
    private int cus_id;

    
    public string cus_name;

    
    public int cus_age;

    
    public Customer(int cus_id, string cus_name, int cus_age)
    {
        
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    

    
    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
        Console.WriteLine($"Customer ID changed to: {this.cus_id}");
    }

    
    public void PrintCusInfo()
    {
        Console.WriteLine($"--- Customer Information ---");
        Console.WriteLine($"ID: {this.cus_id}");
        Console.WriteLine($"Name: {this.cus_name}");
        Console.WriteLine($"Age: {this.cus_age}");
        Console.WriteLine("----------------------------");
    }

    
    public void CompareAge(Customer objCustomer)
    {
        Console.Write($"Comparing {this.cus_name} ({this.cus_age}) and {objCustomer.cus_name} ({objCustomer.cus_age}): ");

        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (objCustomer.cus_age > this.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("They are the same age.");
        }
    }
}
}



