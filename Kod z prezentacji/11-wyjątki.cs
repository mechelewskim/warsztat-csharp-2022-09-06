using System;

int[] numbers = new int[] { 0, 1, 2, 3 };

int a = numbers[4]; //System.IndexOutOfRangeException: Index was outside the bounds of the array.

int a = 0;
int b = 2 /0; //System.DivideByZeroException: Attempted to divide by zero.