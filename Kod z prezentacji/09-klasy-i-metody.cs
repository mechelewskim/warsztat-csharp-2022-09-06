using System;
		
var person = new Person
{
	FirstName = "Marek",
	LastName = "Nowak",
	Birthday = new DateTime(2005, 01, 01)
};

int age = person.GetAge();

Console.WriteLine(age);

public class Person
{
	public DateTime Birthday { get; set; } 
	
	public string FirstName { get; set; }
	
	public string LastName { get; set; }
	
	public int GetAge()
	{
		var today = DateTime.Today;
		var age = today.Year - Birthday.Year;

		// Go back to the year in which the person was born in case of a leap year
		if (Birthday.Date > today.AddYears(-age)) 
		{
			age -= 1; 
		}
		
		return age;
	}
}