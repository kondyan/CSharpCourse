namespace OOP;

public abstract class Person : IPerson
{
    protected string _name { get; set; }
    private string _surname { get; set; }
    private DateTime _birthday { get; set; }

    public Person()
    {
        
    }

    public Person(string name, string surname, DateTime birthday)
    {
        this._name = name;
        this._surname = surname;
        this._birthday = birthday;
    }

    public string NameAndSurname()
    {
        return _name + " " + _surname;
    }

    public int Age()
    {
        throw new NotImplementedException();
    }
}