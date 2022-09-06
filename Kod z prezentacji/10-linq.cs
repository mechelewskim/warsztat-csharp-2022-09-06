using System;
using System.Collections.Generic;
using System.Linq;

Person[] people = 
	{ 
		new Person { NumberOfChildren = 2, Name = "Nowak" },
		new Person { NumberOfChildren = 2, Name = "Kowalski" },
		new Person { NumberOfChildren = 0, Name = "Basiak" }
	};

var sortedPeople = people.OrderBy(x => x.NumberOfChildren).ThenBy(x => x.Name);

foreach (var person in sortedPeople)
{
	Console.WriteLine($"{person.Name} ({person.NumberOfChildren})");	
}

var parents = people.Where(x => x.NumberOfChildren > 0).OrderBy(x => x.Name);

foreach (var person in parents)
{
	Console.WriteLine($"{person.Name} ({person.NumberOfChildren})");	
}

public class Person
{
	public int NumberOfChildren { get; set; }
	
	public string Name { get; set; }
}