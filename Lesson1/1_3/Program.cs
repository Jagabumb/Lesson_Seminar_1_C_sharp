﻿// 3. Напишите программу, которая на вход принимает одно число
// (N), а на выходе показывает все целые числа в промежутке от -N до N.

int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a)
{
  Console.Write($"{b} ");
  b += 1; //счетчик плюс 1
}



Console.WriteLine("Hello, World!");
