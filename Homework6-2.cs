namespace Homework7_2;

class Program
{
public class Professor 
{
    
    public string profName { get; set; }
    public string classTeach { get; set; }
    
    
    private double salary; 

    
    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    
    public Professor(string name, string teachClass, double initialSalary)
    {
        profName = name;
        classTeach = teachClass;
        Salary = initialSalary;
    }
}


public class Student 
{
    
    public string studentName { get; set; }
    public string classEnroll { get; set; }
    
    
    private double studentGrade; 

    
    public double StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }

    
    public Student(string name, string enrolledClass, double initialGrade)
    {
        studentName = name;
        classEnroll = enrolledClass;
        StudentGrade = initialGrade;
    }
}


    static void Main(string[] args)
    {
        
        Professor alice = new Professor("Alice", "Java", 9000);
        Professor bob = new Professor("Bob", "Math", 8000);

        
        Student lisa = new Student("Lisa", "Java", 90);
        Student tom = new Student("Tom", "Math", 80);

        
        Console.WriteLine($"Professor {alice.profName} teaches {alice.classTeach}, and the salary is: {alice.Salary:N0}");
        Console.WriteLine($"Professor {bob.profName} teaches {bob.classTeach}, and the salary is: {bob.Salary:N0}");

        
        Console.WriteLine($"Student {lisa.studentName} enrolls {lisa.classEnroll}, and the grade is: {lisa.StudentGrade:N0}");
        Console.WriteLine($"Student {tom.studentName} enrolls {tom.classEnroll}, and the grade is: {tom.StudentGrade:N0}");

        
        double salaryDifference = alice.Salary - bob.Salary;
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDifference:N0}");

        
        double totalGrade = lisa.StudentGrade + tom.StudentGrade;
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade:N0}");
    }
}


