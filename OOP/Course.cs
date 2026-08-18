namespace OOP;


public class Course
{
    public string Description { get; set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; private set; }

    public Course(string description)
    {
        this.Description = description;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}