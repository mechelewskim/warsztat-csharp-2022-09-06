using System;
using System.Collections.Generic;

//Pętla for
for (int i = 0; i < 3; i++)
{
	Console.WriteLine("Liczba to: " + i);	
}

//Liczba to: 0
//Liczba to: 1
//Liczba to: 2

//Pętla foreach
int[] numbers = new int[] { 0, 1, 2, 3 };              

int sum = 0;

foreach (var number in numbers)
{
	sum += number;
}

Console.WriteLine("Suma cyfr z tablicy to: " + sum);
//Suma cyfr z tablicy to: 6