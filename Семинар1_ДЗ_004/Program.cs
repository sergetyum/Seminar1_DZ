// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число:");
string var = Console.ReadLine();
double number = double.Parse(var);

if (number >= 2)
{
     for (int i = 2; i <= number; i = i+2)
     {
          Console.Write(i + "  ");
     }
}
else
{
Console.Write("Число меньше 2.");
}