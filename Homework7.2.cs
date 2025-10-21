namespace Homework8_2;

class Program
{
    static void Main(string[] args)
    {
        
        Customer alice = new Customer(110, "Alice", 28);
        
        
        Customer bob = new Customer(111, "Bob", 30);

        
        alice.PrintCusInfo();
        bob.PrintCusInfo();

        
        alice.ChangeID(220);
        bob.ChangeID(221);

        
        alice.PrintCusInfo();
        bob.PrintCusInfo();

        alice.CompareAge(bob);
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
    }

    
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {this.cus_id}, name: {this.cus_name}, age:{this.cus_age}");
    }

    
    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        }
        else if (objCustomer.cus_age > this.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        else
        {
            
            Console.WriteLine("They are the same age");
        }
    }
}
    }

