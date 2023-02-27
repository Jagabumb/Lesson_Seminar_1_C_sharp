// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int a = int.Parse(Console.ReadLine()!);

if (a % 2 == 0)
{
  Console.Write("Число четное");
}
else
{
  Console.Write("Число не четное");
}


//Console.WriteLine("Hello, World!");
