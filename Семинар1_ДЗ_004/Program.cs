// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string var = Console.ReadLine();
int number = int.Parse(var);

if (number > 1)
{
     int n = number;
     for (int i = 2; i <= n; i++);
          Console.Write($"{n}");
}
else
{
Console.Write("Число меньше или равно 1.");
}