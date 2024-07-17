using System.Runtime.Loader;

namespace Module2Review;

class Program
{
    static void Main()
    {
        //create a list of students
        var students = new List<Student>();
        
        //create instances
        var student1 = new Student(){Name="Kelly", Id=1};
        var student2 = new Student(){Name="Anne", Id=2};
        var student3 = new Student(){Name="Salle", Id=3};
        var student4 = new Student(){Name="Robyn", Id=4};
        
        //populate students
        students.Add(student1);
        students.Add(student2);
        students.Add(student3);
        students.Add(student4);
        
        //call methods
        student1.AddGrade(94.3);
        student1.AddGrade(90.0, 78.9, 95.4);
        
        student2.AddGrade(90.1);
        student2.AddGrade(87.0, 76.9, 85.4);
        
        student3.AddGrade(80.6);
        student3.AddGrade(81.0, 74.9, 88.8);
        
        student4.AddGrade(70.5);
        student4.AddGrade(70.0, 68.9, 72.6);
        
        //loop through list of students to display info
        foreach (var s in students)
        {
            Console.WriteLine($"ID: {s.Id}, Name: {s.Name}");
            Console.Write("Grades: ");
            foreach (var grade in s.Grades)
            {
                Console.Write($"{grade} ");
            }
            Console.WriteLine($"\nAverage Grade: {s.CalculateAverageGrade():F2}\n");
        }
        
        //Courses
        var course1 = new Course();
        
        course1.CourseName = "c#";
        course1.CourseCode = "CS87654";
        
        //Enroll students
        course1.EnrollStudent(student1);
        course1.EnrollStudent(student2);
        
        //display course info and students enrolled
        
        Console.WriteLine("---------Course-------------");
        Console.WriteLine($"Course {course1.CourseCode} is {course1.CourseName}");
        Console.WriteLine("Students enrolled:");
        foreach (var student in course1.EnrolledStudents)
        {
            Console.WriteLine(student.Name);
        }
    }
}