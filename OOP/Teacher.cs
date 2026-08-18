namespace OOP;

public class Teacher : Person
{
    private string _subject;
    private int _workload;

 

    public Teacher(string name, string surname, DateTime birthday, string subject, int workload):         base(name, surname, birthday)
    {
        this._subject = subject;
        this._workload = workload;
    }
    void teach()
    {
        throw new NotImplementedException();
    }
}