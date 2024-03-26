namespace HomeWork9;

public class Student
{
    public int studentID {get; set;}
    public string studentName {get;set;}

    public static List<Student> studentList = new List<Student>();

    public Student(int id, string name)
    {
        studentID = id;
        studentName = name;
        studentList.Add(this);
    }

    public void PrintInfo()
    {
        Console.WriteLine("Student ID: " + studentID + " Student Name: " + studentName);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

         Dictionary<string, double> gradebook = new Dictionary<string, double>();

        // Add name-grade pairs to the gradebook
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // Check if "Tom" exists in the gradebook and insert if not
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        // Calculate the average GPA of all students
        double sum = 0;
        foreach (var i in gradebook)
        {
            sum += i.Value;
        }
        double averageGPA = sum / gradebook.Count;

        Console.WriteLine("Average GPA: " + averageGPA);

       foreach (var student in Student.studentList)
{
    foreach (var i in gradebook)
    {
        if (i.Value > averageGPA && i.Key == student.studentName)
        {
            student.PrintInfo();
            break;
        }
    }
}
    }
}
