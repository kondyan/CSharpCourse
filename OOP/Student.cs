namespace OOP;

public class Student : Person
{
    private string _class;
    private double _avgGrade;

   

    public Student(string name, string surname, DateTime birthday, string Class, double avgGrade) : base(name,
        surname, birthday)
    {
        this._class = Class;
        this._avgGrade = avgGrade;
    }

    void study()
    {
        throw new NotImplementedException();
    }
}