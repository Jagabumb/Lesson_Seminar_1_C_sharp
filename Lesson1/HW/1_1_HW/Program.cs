﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);

if (a < b)
{
  Console.WriteLine("Ваш ответ");
  Console.WriteLine(b);
}
else if (a > b)
{
  Console.WriteLine("Ваш ответ");
  Console.WriteLine(a);
}
else
{
  Console.WriteLine("Error");
}


Console.WriteLine("Всего доброго!");
