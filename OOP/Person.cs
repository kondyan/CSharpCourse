namespace OOP;

public abstract class Person : IPerson
{
    private string _name;
    private string _surname;
    private DateTime _birthday;

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