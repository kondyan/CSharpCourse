// See https://aka.ms/new-console-template for more information

using OOP;

void Main()
{
    var teacher = new Teacher("Almin", "Ahmatovik", new DateTime(2000, 12, 30), "Mathe", 80);
    var student1 = new Student("Levin", "Iljazi", new DateTime(2010,5,30),"AE25",4.5);
    var student2 = new Student("Devis", "Koneswaran", new DateTime(2015, 1,1), "AE25", 2.3);

    Course course = new Course("Some Test Course" );
    course.Teacher = teacher;
    course.AddStudent( student1);
    course.AddStudent( student2);
    

    foreach (Student student in course.Students)
    {
        Console.WriteLine("Name and Surname: " + student.NameAndSurname());
    }
    
}


Main();