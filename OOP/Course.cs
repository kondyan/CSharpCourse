namespace OOP;

public class Course
{
    private string _description;
    private Teacher _teacher;
    private List<Student> _students;

    public Course()
    {
        
    }

    void AddStudent(Student student)
    {
        this._students.Add(student);
    }
}