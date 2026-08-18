namespace IO;

public class Participant
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Email { get; set; }
	public string Course { get; set; }

	public override string ToString()
	{
		return $"{Name} | {Surname} | {Email} | {Course}";
	}

	public Participant(string name, string surname, string email, string course)
	{
		this.Name = name;
		this.Surname = surname;
		this.Email = email;
		this.Course = course;
	}
}
