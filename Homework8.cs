namespace homework8;

class Program
{
    static void Main(string[] args)
    
        { // Please use following code to create Customer objects and customer_list
 Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
 Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
 Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
 Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
 Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
 Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
 Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);


 	 Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};


 // call Q1 method
 TotalCredits(customer_list);
 // call Q2 method
 AmarilloAverageAge(customer_list);
 // call Q3 method
 CanyonAge(customer_list);
    }
// Q1. Create a method to calculate and print the total credit of all customers in the customer_list.
    static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = 0.0;
        foreach (Customer customer in customer_list)
        {
            totalCredit += customer.customerCredit;
        }
        Console.WriteLine($"\nQ1: Total credit of all customers: ${totalCredit:F2}");

    
}
// Q2 Create a method to calculate and print the average age of customers living in Amarillo.
    static void AmarilloAverageAge(Customer[] customer_list){
// Use LINQ to filter and select ages
        var amarilloAges = customer_list
                           .Where(c => c.customerCity == "Amarillo")
                           .Select(c => c.customerAge);

        if (amarilloAges.Any())
        {
            double averageAge = amarilloAges.Average();
            Console.WriteLine($"Q2: Average age of customers in Amarillo: {averageAge:F2} years");
        }
        else
        {
            Console.WriteLine("Q2: No customers found in Amarillo.");
        }
    }

// Q3 Create a method to print the names of customers who live in Canyon and are older than 30.
    static void CanyonAge(Customer[] customer_list){
Console.WriteLine("\nQ3: Customers in Canyon older than 30:");
        
        // Filter for both city and age
        var qualifiedCustomers = customer_list
                                 .Where(c => c.customerCity == "Canyon" && c.customerAge > 30)
                                 .ToList();

        if (qualifiedCustomers.Any())
        {
            foreach (Customer customer in qualifiedCustomers)
            {
                Console.WriteLine($"- {customer.customerName}");
            }
        }
        else
        {
            Console.WriteLine("None found.");
        }
    }


// Q0: Create a class called Customer
class Customer
{
public String customerName;
    public int customerAge;
    public String customerCity;
    public double customerCredit;

    // constructor
    public Customer(String customerName, int customerAge, String customerCity, double customerCredit) 
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }

    // You'll likely need better methods for the other methods to work
    public String getCustomerCity()
    {
        return customerCity;
    }

    public double getCustomerCredit()
    {
        return customerCredit;
    }
    
    public int getCustomerAge()
    {
        return customerAge;
    }
    
    public String getCustomerName()
    {
        return customerName;
    }
}
}

