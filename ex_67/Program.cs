// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.using System;
using System;
Console.Clear();

Console.Write("Input integer number: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNumbersSum(number));

// возвращает сумму цифр
int GetNumbersSum(int number) 
{
      int sum = 0;
      if (number == 0)
            return number % 10;     // возвращает остаток от деления (последний разряд)

      return GetNumbersSum(number / 10) + number % 10;
}