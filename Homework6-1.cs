namespace Homework7_1;
    

public class Person
{
    
}


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

    public void DisplayProfessorDetails()
    {
        Console.WriteLine($"Professor: {profName}, Teaches: {classTeach}, Salary: ${Salary:N0}");
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

    public void DisplayStudentDetails()
    {
        Console.WriteLine($"Student: {studentName}, Enrolled in: {classEnroll}, Grade: {StudentGrade}");
    }
}


public class Program
{
    static void Main(string[] args)
    {
        Professor alice = new Professor("Alice", "Java", 9000);

        Professor bob = new Professor("Bob", "Math", 8000);

        Student lisa = new Student("Lisa", "Java", 90);

        Student tom = new Student("Tom", "Math", 80);

        
    Console.WriteLine("--- Verification of Objects ---");
    
   
    alice.DisplayProfessorDetails(); 
    bob.DisplayProfessorDetails();
    lisa.DisplayStudentDetails();
    tom.DisplayStudentDetails();
    }


}

