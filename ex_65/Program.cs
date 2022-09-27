// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
//  промежутке от M до N по убыванию.

using System;
Console.Clear();

Console.Write("Input integer number M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Input integer number N: ");
int N = int.Parse(Console.ReadLine()!);

int rangeMin = Min(M, N);
int rangeMax = Max(M, N);

Console.WriteLine(GetNaturalRowBetweenMN(rangeMin, rangeMax));

int Min(int a, int b)
{
      return a < b ? a : b; 
}

int Max(int a, int b)
{
      return a > b ? a : b; 
}




string GetNaturalRowBetweenMN (int rangeMin, int rangeMax)
{
      {
      if (rangeMax == rangeMin) 
            return rangeMax.ToString();
      
      return rangeMax + ", " + GetNaturalRowBetweenMN(rangeMin, rangeMax - 1);
      }
}