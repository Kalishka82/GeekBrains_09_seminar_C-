// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N.

using System;
Console.Clear();

Console.Write("Input integer number: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalRow(N));

string GetNaturalRow (int N)
{
      if (N == 1) 
            return "1";
      
      return GetNaturalRow(N - 1) + ", " + N;
}