using System;

int age = 17;

if (age >= 18)
{
	// więcej lub równe 18 lat
}
else if (age > 12)
{
	// mniej niż 18 lat
	// i więcej niż 12 lat
}
else
{
	// wszystkie pozostałe przypadki
}

bool condition = true; // jawne przypisanie wartości true lub false
condition = age >= 21; // warunek logiczny jako wartość bool

if (condition)
{
	// warunek spełniony
}