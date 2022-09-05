using System;

Console.BackgroundColor = ConsoleColor.Magenta;  // kolor tła konsoli
Console.ForegroundColor = ConsoleColor.Yellow;   // kolor tekstu

Console.WriteLine("Hello World!");               // wypisanie linii tekstu
string input = Console.ReadLine();               // odczytanie napisu
Console.WriteLine(input);                        // wypisanie linii tekstu

int number = int.Parse(input);                   // zamiana tekstu na liczbę