namespace Module2Review;

public class Course
{
    public string? CourseName { get; set; }
    public string? CourseCode { get; set; }
    public List<Student> EnrolledStudents { get; set; }
    
    // Default constructor to initialize the EnrolledStudents list
    public Course()
    {
        EnrolledStudents = new List<Student>();
    }
    
    // Method to enroll students in a course
    public void EnrollStudent(Student student)
    {
        if (!EnrolledStudents.Contains(student))
        {
            // Add student to the list if not already enrolled
            EnrolledStudents.Add(student); 
        }
    }
}