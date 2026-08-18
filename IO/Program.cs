

using System.Text;
using System.Text.Json;
using IO;
using Microsoft.VisualBasic.FileIO;

void Task1()
{
	string path = "../../../data/scratch.csv";
	List<Participant> participants = new List<Participant>();
	
	using var parser = new TextFieldParser(path);

	parser.TextFieldType = FieldType.Delimited;

	parser.SetDelimiters(";");

	parser.HasFieldsEnclosedInQuotes = true;

// Skip header
	string[]? headers = parser.ReadFields();
	while (!parser.EndOfData)
	{
		string[]? fields = parser.ReadFields();
		if (fields is not null)
		{
			Participant participant = new Participant(fields[0], fields[1], fields[2], fields[3]);
			participants.Add(participant);
		}
	}
	
	Console.WriteLine("Participants Read: " + participants.Count + '\n');
	foreach(var participant in participants)
	{
		Console.WriteLine(participant.ToString());
	}
	JsonSerializerOptions options = new JsonSerializerOptions {
		WriteIndented = true
	};
	string fileName = "../../../data/participants.json";
	string jsonString = JsonSerializer.Serialize(participants, options);

	File.WriteAllText(fileName,jsonString);
	Console.WriteLine("JSON-File has been saved: " + fileName);
}

void Task2()
{
	string path = "../../../data/text.txt";
	char[] dividers = { ' ', '\n', '\r', '.', ',', '!', '?' };
	string contents = File.ReadAllText(path);
	string[] words = contents.Split(dividers, StringSplitOptions.RemoveEmptyEntries);
	Console.WriteLine("File: data.txt");
	Console.WriteLine("Word count: " + words.Length);

}

void Task3()
{
	string path = "../../../data/text.txt";
	char[] dividers = { ' ', '\n', '\r', '.', ',', '!', '?' };
	string contents = File.ReadAllText(path);
	string[] words = contents.Split(dividers, StringSplitOptions.RemoveEmptyEntries);
	Console.WriteLine("File: data.txt");
	Console.WriteLine("Word count: " + words.Length);
	
	int l = 0;
	string lw = "";
	foreach (var word in words)
	{
		if (word.Length > l)
		{
			l = word.Length;
			lw = word;
		}
	}
	Console.WriteLine("Longest word: " + "\"" + lw + "\"" + " " + l + " characters");
}

void Main()
{
	//Task1();
	// Task2();
	Task3();
}


Main();