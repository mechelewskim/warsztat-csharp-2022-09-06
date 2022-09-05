using System;
using System.Collections.Generic;

int[] numbers = new int[] { 0, 1, 2, 3 };                //tablica liczb
string[] texts = new string[] { "abc", "def", "ghi" };   //tablica napisów

int number = numbers[0]; //0
numbers[1] = 5; //numbers = { 5, 1, 2, 3 }

List<int> listOfNumbers = new List<int>();
listOfNumbers.Add(0);
listOfNumbers.Add(1);
listOfNumbers.Add(2);
listOfNumbers.Remove(1);

List<string> listOfTexts = new()
{
	"abc",
	"def",
	"ghi"
};

Dictionary<string, int> dictionary = new()
{
	{ "Opel", 1 },
	{ "Audi", 2 }
};

int opel = dictionary["Opel"]; //1