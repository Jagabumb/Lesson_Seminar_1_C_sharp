// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N = int.Parse(Console.ReadLine()!);
int b = 2;

while (b <= N)
{
  Console.Write($"{b} ");
  b += 2; //счетчик плюс 1
}


//Console.WriteLine(a);
