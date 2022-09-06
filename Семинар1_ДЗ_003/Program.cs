// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число:");
string var = Console.ReadLine();
double number = double.Parse(var);
if (number % 2 == 0)
{
    Console.Write("Число четное.");
}
else
{
    Console.Write("Число нечетное.");
}