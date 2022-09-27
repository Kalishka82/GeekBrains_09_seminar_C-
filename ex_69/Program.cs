// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.

using System;
Console.Clear();

Console.Write("Input integer number A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Input integer number B: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{A} ^ {B} = {GetAPowB(A, B)}");

int GetAPowB(int A, int B)
{
      if (B == 0)
            return 1;
      
      return GetAPowB(A, B - 1) * A; 
}


// Задача 42 Перевести число из десятичной системы в двоичную (рекурсия)

Console.WriteLine(ConvertDecToBinaryRec(A));

string ConvertDecToBinaryRec(int A)
{
      if (A == 0)
      return string.Empty;

      return ($"{ConvertDecToBinaryRec(A / 2)}{A % 2}");
}
