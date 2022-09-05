using System;

try
{
	string input = Console.ReadLine();
	int a = int.Parse(input);

	int b = 2 / a;
}
catch (FormatException)
{
	Console.WriteLine("Wprowadzona nie została liczba");
}
catch (DivideByZeroException)
{
	Console.WriteLine("Dzielenie przez zero");
}
catch (Exception e)
{
	Console.WriteLine("Wystąpił inny błąd " + e.Message);
}