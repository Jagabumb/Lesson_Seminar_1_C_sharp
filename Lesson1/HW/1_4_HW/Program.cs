// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int a = int.Parse(Console.ReadLine()!);
int b = 1;
while (a >= b)
{
  Console.Write($"{b} ");
  b += 1; //счетчик плюс 1
}


//Console.WriteLine(a);
