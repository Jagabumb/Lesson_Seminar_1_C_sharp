// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

//string a = Console.ReadLine()!;
//int num = int.Parse(a);
int a = int.Parse(Console.ReadLine()!);

//string b = Console.ReadLine()!;
//int num = int.Parse(b);
int b = int.Parse(Console.ReadLine()!);

if (a == b * b)
{
  Console.WriteLine("Yes");
}
else
{
  Console.WriteLine("No");
}


Console.WriteLine("Hello, World!");
