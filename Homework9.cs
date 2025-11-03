namespace Homework10;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        
        Dictionary<string, double> gradebook = new Dictionary<string, double>()
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };

       
        string newStudentName = "Tom";
        double newStudentGpa = 3.3;

        if (!gradebook.ContainsKey(newStudentName))
        {
            gradebook.Add(newStudentName, newStudentGpa);
            Student student5 = new Student(555, newStudentName); 
        }

        

        
        double totalGpa = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGpa += gpa;
        }

        
        double averageGpa = totalGpa / gradebook.Count;
        
        
        Console.WriteLine($"The average GPA is: {averageGpa:F2}"); 

        
        foreach (KeyValuePair<string, double> entry in gradebook)
        {
            
            if (entry.Value > averageGpa) 
            {
                
                Student highAchiever = Student.studentList.Find(s => s.StudentName == entry.Key);
                
                if (highAchiever != null)
                {
                    
                    highAchiever.PrintInfo();
                }
            }
        }
    }

}
class Student
{
    private int studentID;
    private string studentName;
    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this); 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }

    public string StudentName 
    {
        get { return studentName; }
    }
}

